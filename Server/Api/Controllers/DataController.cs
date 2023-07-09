using LogicServices.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Api.DTO;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly DataService _dataService;
        public DataController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("test/serch")]
        public IActionResult test(string serch)
        {
            return Ok(_dataService.test(serch));
        }
        [HttpGet("GetLastVideos")]
        public IActionResult GetLastVideos()
        {
            return Ok(_dataService.GetLastVideos());
        }
        [HttpGet("GetAllSpeakers")]
        public IActionResult GetAllSpeakers()
        {
            return Ok(_dataService.GetSpeakers());
        }
        [HttpGet("GetAllChannles")]
        public IActionResult GetAllChannles()
        {
            return Ok(_dataService.GetAllChannles());
        }

        [HttpPost("GetVideosByCategory")]
        public IActionResult GetVideosByCategory([FromBody] SearchByCategoryDTO s)
        {
            if (s.Category is null) { return BadRequest(); }

            return Ok(_dataService.GetVideosByCategoryService(s.Category.Value));
        }

        [HttpPost("GetVideosBySpeaker")]
        public IActionResult GetVideosBySpeaker([FromBody] SearchByCategoryDTO s)
        {
            if (s.SpeakerId is null) { return BadRequest(); }

            return Ok(_dataService.GetVideosBySpeaker(s.SpeakerId.Value));
        }
    }
}