﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Utils
{
    /// <summary>
    /// claim keys constants
    /// </summary>
    public static class ClaimConstants
    {
        public const string ObjectId = "http://schemas.microsoft.com/identity/claims/objectidentifier";
        public const string TenantId = "http://schemas.microsoft.com/identity/claims/tenantid";
        public const string tid = "tid";
    }
}