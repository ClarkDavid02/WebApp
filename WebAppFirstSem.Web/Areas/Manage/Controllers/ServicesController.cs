using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebAppFirstSem.Web.Areas.Manage.ViewModels.Services;
using WebAppFirstSem.Web.Infrastructures.Domain.Data;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppFirstSem.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ServicesController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;

        public ServicesController(DefaultDbContext context, IConfiguration iConfiguration)
        {
            _context = context;
            this._config = iConfiguration;



        }
        [HttpGet, Route("manage/services")]
        [HttpGet, Route("manage/services/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string status = "Available")
        {
            Enum.TryParse(status, out ServiceStatus serviceStatus); ;


            Page<Service> result = new Page<Service>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Service> serQuery = (IQueryable<Service>)this._context.Services.Where(s => s.ServiceStatus == serviceStatus);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                serQuery = serQuery.Where(s => s.Name.Contains(keyword)
                                                 || s.Description.Contains(keyword));

            }

            long queryCount = serQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Service> services = serQuery.ToList();

            result.Items = services.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Services = result,
                ServiceStatus = serviceStatus
            });
        }

        [HttpGet, Route("manage/services/delete/{serviceId}")]
        public IActionResult Delete(Guid? serviceId)
        {
            var service = this._context.Services.FirstOrDefault(s => s.Id == serviceId);
            
            if (service != null)
            {
                this._context.Services.Remove(service);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }



        [HttpGet, Route("manage/services/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = this._context.Services.FirstOrDefault(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }


        [HttpGet, Route("manage/services/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("manage/services/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Service ser = new Service()
            {

                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                ServiceStatus = Infrastructures.Domain.Enums.ServiceStatus.Available,
                IsPublished = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,



            };
            this._context.Services.Add(ser);
            this._context.SaveChanges();

            return RedirectToAction("Index");

        }



        [HttpGet, Route("manage/services/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {

            var service = this._context.Services.FirstOrDefault(s => s.Id == id);

            if (service == null)
            {
                return RedirectToAction("Index");
            }


            if (service != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = service.Id.Value,
                        Name = service.Name,
                        Description = service.Description,
                        ServiceStatus = service.ServiceStatus,
                        Price = service.Price,
                        
                    }
                );
            }

            return View();
        }
        [HttpPost, Route("manage/services/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var service = this._context.Services.FirstOrDefault(s => s.Id == model.Id);

            if (service != null)
            {
                service.Name = model.Name;
                service.Description = model.Description;
                service.ServiceStatus = model.ServiceStatus;
                service.Price = model.Price;
               

                this._context.Services.Update(service);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }



    }
}