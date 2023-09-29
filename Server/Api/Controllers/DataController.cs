using LogicServices.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Api.DTO;
using System.Reflection.PortableExecutable;
using Microsoft.IdentityModel.Tokens;

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
        public async Task<IActionResult> testAsync(string serch)
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
            var list = _dataService.GetSpeakers();
            return list.IsNullOrEmpty() ? BadRequest() : Ok(list);
        }
        [HttpGet("GetAllChannles")]
        public IActionResult GetAllChannles()
        {
            return Ok(_dataService.GetAllChannles());
        }

        [HttpPost("GetVideosByChannel")]
        public IActionResult GetVideosByChannel([FromBody] SearchByChannelDTO s)
        {
            return Ok(_dataService.GetVideosByChannel(s.Category));
        }

        [HttpPost("GetVideosBySpeaker")]
        public IActionResult GetVideosBySpeaker([FromBody] SearchBySpeakerDTO s)
        {
            return Ok(_dataService.GetVideosBySpeaker(s.SpeakerId));
        }
    }
}