using LogicServices.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Api.DTO;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class DataController : Controller
    {
        private readonly DataService _dataService;
        public DataController(DataService dataService)
        {
            _dataService = dataService;
        }
        
     
        [HttpGet("GetLastVideos")]
        public IActionResult GetLastVideos()
        {
            return Ok(_dataService.GetLastVideos());
        }

        [HttpPost("GetVideosByCategory")]
        public IActionResult GetVideosByCategory([FromBody]SearchByCategoryDTO s)
        {
            if(s.Category is null){return BadRequest();}

            return Ok(_dataService.GetVideosByCategoryService(s.Category.Value));
        }

        [HttpPost("GetVideosBySpeaker")]
        public IActionResult GetVideosBySpeaker([FromBody]SearchByCategoryDTO s)
        {
             if(s.SpeakerId is null) { return BadRequest(); }
             
            return Ok(_dataService.GetVideosBySpeaker(s.SpeakerId.Value));
        }
    }
}