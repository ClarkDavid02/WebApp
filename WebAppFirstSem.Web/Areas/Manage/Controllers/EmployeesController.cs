using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebAppFirstSem.Web.Areas.Manage.ViewModels.Employees;
using WebAppFirstSem.Web.Infrastructures.Domain.Data;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppFirstSem.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class EmployeesController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;

        public EmployeesController(DefaultDbContext context, IConfiguration iConfiguration)
        {
            _context = context;
            this._config = iConfiguration;



        }
        [HttpGet, Route("manage/employees")]
        [HttpGet, Route("manage/employees/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string status = "Active")
        {
            Enum.TryParse(status, out EmployeeStatus employeeStatus); ;


            Page<Employee> result = new Page<Employee>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Employee> empQuery = (IQueryable<Employee>)this._context.Employees.Where(s => s.EmployeeStatus == employeeStatus);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                empQuery = empQuery.Where(s => s.FirstName.Contains(keyword)
                                                 || s.LastName.Contains(keyword)
                                                 || s.FullName.Contains(keyword)
                                                 || s.UserName.Contains(keyword));

            }

            long queryCount = empQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Employee> employees = empQuery.ToList();

            result.Items = employees.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Employee = result,
                EmployeeStatus = employeeStatus
            });
        }


        [HttpGet, Route("manage/employees/delete/{employeeId}")]
        public IActionResult Delete(Guid? employeeId)
        {
            var employee = this._context.Employees.FirstOrDefault(s => s.Id == employeeId);

            if (employee != null)
            {
                this._context.Employees.Remove(employee);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }


        [HttpGet, Route("manage/employees/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = this._context.Employees.FirstOrDefault(s => s.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }


        [HttpGet, Route("manage/employees/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("manage/employees/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Employee emp = new Employee()
            {

                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Address = model.Address,
                EmailAddress = model.EmailAddress,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,
                IsPublished = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,



            };
            this._context.Employees.Add(emp);
            this._context.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet, Route("manage/employees/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {

            var employee = this._context.Employees.FirstOrDefault(s => s.Id == id);

            if (employee == null)
            {
                return RedirectToAction("Index");
            }


            if (employee != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = employee.Id.Value,
                        FirstName = employee.LastName,
                        LastName = employee.LastName,
                        Address = employee.Address,
                        EmailAddress = employee.EmailAddress,
                        Password = employee.Password,
                        PhoneNumber = employee.Password,
                        UserName = employee.UserName

                    }
                );
            }

            return View();
        }
        [HttpPost, Route("manage/employees/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var employee = this._context.Employees.FirstOrDefault(s => s.Id == model.Id);

            if (employee != null)
            {
                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.UserName = model.UserName;
                employee.Address = model.Address;
                employee.PhoneNumber = model.PhoneNumber;
                employee.EmailAddress = model.EmailAddress;
                employee.Password = model.Password;


                this._context.Employees.Update(employee);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }


    }
}