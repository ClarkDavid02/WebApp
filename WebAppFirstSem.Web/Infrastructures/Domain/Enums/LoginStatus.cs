﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstSem.Web.Infrastructures.Domain.Enums
{
    public enum LoginStatus
    {
        Active,
        InActive,
        NeedToChangePassword,
        AccountLocked
    }
}
