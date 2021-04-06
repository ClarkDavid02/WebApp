using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebAppFirstSem.Web.Areas.Manage.ViewModels.Departments;
using WebAppFirstSem.Web.Infrastructures.Domain.Data;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppFirstSem.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class DepartmentsController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;

        public DepartmentsController(DefaultDbContext context, IConfiguration iConfiguration)
        {
            _context = context;
            this._config = iConfiguration;



        }
        [HttpGet, Route("manage/departments")]
        [HttpGet, Route("manage/departments/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string status = "Available")
        {
            Enum.TryParse(status, out DepartmentStatus departmentStatus); ;


            Page<Department> result = new Page<Department>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Department> deptQuery = (IQueryable<Department>)this._context.Departments.Where(s => s.DepartmentStatus == departmentStatus);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                deptQuery = deptQuery.Where(s => s.Name.Contains(keyword)
                                               );

            }

            long queryCount = deptQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Department> departments = deptQuery.ToList();

            result.Items = departments.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Departments = result,
                DepartmentStatus = departmentStatus
            });
        }

        [HttpGet, Route("manage/departments/delete/{departmentId}")]
        public IActionResult Delete(Guid? departmentId)
        {
            var department = this._context.Departments.FirstOrDefault(s => s.Id == departmentId);

            if (department != null)
            {
                this._context.Departments.Remove(department);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        [HttpGet, Route("manage/departments/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = this._context.Departments.FirstOrDefault(s => s.Id == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        [HttpGet, Route("manage/departments/create")]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost, Route("manage/departments/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Department department = new Department()
            {
                        
                Id = Guid.NewGuid(),
                Budget = model.Budget,
                Name = model.Name,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,

            };
                
         
            this._context.Departments.Add(department);
            this._context.SaveChanges();

            return RedirectToAction("Index");

        }


        [HttpGet, Route("manage/departments/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {

            var department = this._context.Departments.FirstOrDefault(s => s.Id == id);

            if (department == null)
            {
                return RedirectToAction("Index");
            }


            if (department != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = department.Id.Value,
                        Budget = department.Budget,
                        Name = department.Name,
                        DepartmentStatus = department.DepartmentStatus,
                       

                    }
                );
            }

            return View();
        }
        [HttpPost, Route("manage/departments/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var department = this._context.Departments.FirstOrDefault(s => s.Id == model.Id);

            if (department != null)
            {
                department.Name = model.Name;
                department.DepartmentStatus = model.DepartmentStatus;
                department.Budget = model.Budget;
             


                this._context.Departments.Update(department);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }
    }
}