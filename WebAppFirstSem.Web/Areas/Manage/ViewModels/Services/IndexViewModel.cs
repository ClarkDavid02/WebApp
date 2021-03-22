using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppFirstSem.Web.Areas.Manage.ViewModels.Services
{
    public class IndexViewModel
    {
        public Page<Service> Services { get; set; }

        public ServiceStatus ServiceStatus { get; set; }

        public List<ServiceStatus> serviceStatuses
        {
            get
            {
                return Enum.GetValues(typeof(ServiceStatus)).Cast<ServiceStatus>().ToList();
            }
        }
    }
}