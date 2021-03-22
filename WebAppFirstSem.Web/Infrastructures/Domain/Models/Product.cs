using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppFirstSem.Web.Infrastructures.Domain.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public bool IsPublished { get; set; }

        public ProductStatus ProductStatus { get; set; }

    }
}
