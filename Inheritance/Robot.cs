﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Robot : InorganicBeing
    {
        public string VersionNumber { get; set; }
        public Robot()
        {
            greeting = "BZZZZT TERMINATE ALL HUMANS";
        }
    }
}
