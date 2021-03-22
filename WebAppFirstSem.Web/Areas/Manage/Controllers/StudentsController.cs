using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebAppFirstSem.Web.Infrastructures.Domain.Data;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppFirstSem.Web.Infrastructures.Domain.Models;
using WebAppFirstSem.Web.Areas.Manage.ViewModels.Students;

namespace WebAppFirstSem.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class StudentsController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;

        public StudentsController(DefaultDbContext context, IConfiguration iConfiguration)
        {
            _context = context;
            this._config = iConfiguration;



        }
        [HttpGet, Route("manage/students")]
        [HttpGet, Route("manage/students/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string status = "Active")
        {
            Enum.TryParse(status, out StudentStatus studentStatus); ;


            Page<Student> result = new Page<Student>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Student> stuQuery = (IQueryable<Student>)this._context.Students.Where(s => s.StudentStatus == studentStatus);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                stuQuery = stuQuery.Where(s => s.FirstName.Contains(keyword)
                                                 || s.LastName.Contains(keyword)
                                                 || s.FullName.Contains(keyword)
                                                 || s.UserName.Contains(keyword));

            }

            long queryCount = stuQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Student> students = stuQuery.ToList();

            result.Items = students.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Students = result,
                StudentStatus = studentStatus
            });
        }


        [HttpGet, Route("manage/students/delete/{studentId}")]
        public IActionResult Delete(Guid? studentId)
        {
            var student = this._context.Students.FirstOrDefault(s => s.Id == studentId);

            if (student != null)
            {
                this._context.Students.Remove(student);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }


        [HttpGet, Route("manage/students/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = this._context.Students.FirstOrDefault(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpGet, Route("manage/students/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("manage/students/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Student stu = new Student()
            {

                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Address = model.Address,
                EmailAddress = model.EmailAddress,
                Password  = model.Password,
                PhoneNumber = model.PhoneNumber,
                IsPublished = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,



            };
            this._context.Students.Add(stu);
            this._context.SaveChanges();

            return RedirectToAction("Index");

        }


        [HttpGet, Route("manage/students/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {

            var student = this._context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return RedirectToAction("Index");
            }


            if (student != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = student.Id.Value,
                        FirstName = student.LastName,
                        LastName = student.LastName,
                        Address = student.Address,
                        EmailAddress = student.EmailAddress,
                        Password = student.Password,
                        PhoneNumber = student.Password,
                        UserName = student.UserName

                    }
                );
            }

            return View();
        }
        [HttpPost, Route("manage/students/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var student = this._context.Students.FirstOrDefault(s => s.Id == model.Id);

            if (student != null)
            {
                student.FirstName = model.FirstName;
                student.LastName = model.LastName;
                student.UserName = model.UserName;
                student.Address = model.Address;
                student.PhoneNumber = model.PhoneNumber;
                student.EmailAddress = model.EmailAddress;
                student.Password = model.Password;
         

                this._context.Students.Update(student);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }
    }
}