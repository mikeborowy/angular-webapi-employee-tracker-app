﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracker.Services.Charts
{
    public class ChartData :IChartData
    {
        public string Key { get; set; }
        public int Value { get; set; }
    }
}
