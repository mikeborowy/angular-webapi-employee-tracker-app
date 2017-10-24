using EmployeeTracker.Services.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracker.Services.Dashboards
{
    public class Dashboard:IDashboard
    {
        public int TotalPositions { get; set; }
        public int TotalOffices { get; set; }
        public int TotalEmployees { get; set; }
        public IEnumerable<ChartData> EmployeesPerYear { get; set; }
        public IEnumerable<ChartData> EmployeesPerOffice { get; set; }
    }
}
