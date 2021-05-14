using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppFirstSem.Web.Infrastructures.Domain.Models
{
    public class UserRole : BaseModel
    {

        public Guid? UserId { get; set; }

        public Role Role { get; set; }
    }
}

