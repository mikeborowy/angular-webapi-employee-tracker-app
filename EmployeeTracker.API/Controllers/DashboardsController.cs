using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EmployeeTracker.Services.Dashboards;
using System.Web.Http.Cors;

namespace EmployeeTracker.API.Controllers
{
    [RoutePrefix("api/dashboards")]
    [EnableCorsAttribute("http://localhost:52036", "*", "*")]
    public class DashboardsController : ApiController
    {
        private readonly IDashboardService _service;

        public DashboardsController(IDashboardService service)
        {
            _service = service;
        }

        [Route("")]
        [HttpGet]
        [ResponseType(typeof(IDashboard))]
        public async Task<IHttpActionResult> GetDashboardSetting()
        {
            var result = await _service.GetDashboardSettingAsync();
            return Ok(result);
        }
    }
}
