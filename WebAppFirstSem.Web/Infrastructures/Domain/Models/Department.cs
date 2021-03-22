using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppFirstSem.Web.Infrastructures.Domain.Models
{
    public class Department : BaseModel 
    {
        public Department()
        {
            this.DepartmentStatus = DepartmentStatus.Closed;
           
        }
        public Guid? EmployeeId { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DepartmentStatus DepartmentStatus { get; set; }


        public List<Employee> Employee { get; set; }
        
        public bool IsPublished { get; set; }
    }
}
