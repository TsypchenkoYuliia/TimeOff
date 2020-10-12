﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeOffTracker.WebApi.AuthHelpers
{
    public class AppSettings
    {
        public string Secret { get; set; }

        public double TokenExpiresTimeHours { get; set; }
    }
}
