using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppFirstSem.Web.Infrastructures.Domain.Models
{
    public class Service : BaseModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public bool IsPublished { get; set; }

        public ServiceStatus ServiceStatus { get; set; }

    }
}
