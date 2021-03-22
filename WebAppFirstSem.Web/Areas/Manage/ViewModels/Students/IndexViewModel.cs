using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppFirstSem.Web.Areas.Manage.ViewModels.Students
{
    public class IndexViewModel
    {
        public Page<Student> Students { get; set; }

        public StudentStatus StudentStatus { get; set; }

        public List<StudentStatus> StudentStatuses
        {
            get
            {
                return Enum.GetValues(typeof(StudentStatus)).Cast<StudentStatus>().ToList();
            }
        }
    }
}