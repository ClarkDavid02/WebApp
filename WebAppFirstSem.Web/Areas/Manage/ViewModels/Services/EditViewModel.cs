using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppFirstSem.Web.Areas.Manage.ViewModels.Services
{
    public class EditViewModel
    {
        [Required]
        public Guid? Id { get; set; }
        [Required]
        public ServiceStatus ServiceStatus { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
     
        [Required]
        public decimal Price { get; set; }


    }
}
