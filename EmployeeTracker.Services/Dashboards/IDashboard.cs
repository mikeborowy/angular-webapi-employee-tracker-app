﻿using EmployeeTracker.Services.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracker.Services.Dashboards
{
    public interface IDashboard
    {

        int TotalPositions { get; set; }
        int TotalOffices { get; set; }
        int TotalEmployees { get; set; }
        // a set of data points on a chart that represent historical growth of employees yearly
        IEnumerable<ChartData> EmployeesPerYear { get; set; }
        // a set of data points on a chart that represent the number of employees per office
        IEnumerable<ChartData> EmployeesPerOffice { get; set; }
    }
}
