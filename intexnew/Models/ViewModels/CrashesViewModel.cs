﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intexnew.Models.ViewModels
{
    public class CrashesViewModel
    {
        public IQueryable<Crash> Crashes { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}