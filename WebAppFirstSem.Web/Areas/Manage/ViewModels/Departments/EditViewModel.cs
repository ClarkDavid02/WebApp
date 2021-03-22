using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppFirstSem.Web.Areas.Manage.ViewModels.Departments
{
    public class EditViewModel
    {
        public Guid? Id { get; set; }

        public Guid? EmployeeId { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DepartmentStatus DepartmentStatus { get; set; }

    }
}
