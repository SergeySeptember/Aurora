using Aurora.Entity;
using Aurora.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Aurora.Controllers
{
    [ApiController]
    [Route("board")]
    public class Controller : ControllerBase
    {

        [HttpGet("ads")]
        public IEnumerable<Ads> Get()
        {
            var ads = ProductRepository.GetAds().OrderByDescending(s => s.Id);
            return ads;
        }

        [HttpGet("ad-by-id/{id}")]
        public IActionResult GetAdById(int id)
        {
            var ad = ProductRepository.GetAdById(id);
            if (ad == null)
            {
                return BadRequest("Id not found");
            }
            return Ok(ad);
        }

        [HttpPost("ad")]
        public IActionResult Post([FromBody] BodyData data)
        {
            string result = ProductRepository.InsertAd(data);
            if (result == "Success!")
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}