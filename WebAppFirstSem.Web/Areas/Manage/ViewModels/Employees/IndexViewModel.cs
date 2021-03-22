using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppFirstSem.Web.Areas.Manage.ViewModels.Employees
{
    public class IndexViewModel
    {
        public Page<Employee> Employee { get; set; }

        public EmployeeStatus EmployeeStatus { get; set; }

        public List<EmployeeStatus> EmployeeStatuses
        {
            get
            {
                return Enum.GetValues(typeof(EmployeeStatus)).Cast<EmployeeStatus>().ToList();
            }
        }
    }
}