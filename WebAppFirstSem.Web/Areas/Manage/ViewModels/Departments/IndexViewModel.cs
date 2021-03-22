using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppFirstSem.Web.Areas.Manage.ViewModels.Departments
{
    public class IndexViewModel
    {
        public Page<Department> Departments { get; set; }

        public DepartmentStatus DepartmentStatus { get; set; }

        public List<DepartmentStatus> DepartmentStatuses
        {
            get
            {
                return Enum.GetValues(typeof(DepartmentStatus)).Cast<DepartmentStatus>().ToList();
            }
        }
    }
}