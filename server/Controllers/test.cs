using LogicServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [Route("[controller]")]
    public class Test : Controller
    {

        private readonly DataService _dataService;
        public Test(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult test1()
        {
            return Ok(_dataService.GetLastVideos());
        }
    }
}