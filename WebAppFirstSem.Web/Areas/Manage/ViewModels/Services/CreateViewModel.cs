using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstSem.Web.Areas.Manage.ViewModels.Services
{
    public class CreateViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
       
        [Required]
        public decimal Price { get; set; }


    }
}
