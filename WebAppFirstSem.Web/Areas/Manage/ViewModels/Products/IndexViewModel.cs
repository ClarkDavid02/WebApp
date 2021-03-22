using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppFirstSem.Web.Areas.Manage.ViewModels.Products
{
    public class IndexViewModel
    {
        public Page<Product> Products { get; set; }

        public ProductStatus productStatus { get; set; }

        public List<ProductStatus> productStatuses
        {
            get
            {
                return Enum.GetValues(typeof(ProductStatus)).Cast<ProductStatus>().ToList();
            }
        }
    }
}