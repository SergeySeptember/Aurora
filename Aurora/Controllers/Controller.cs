using Aurora.Entity;
using Aurora.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Aurora.Controllers
{
    [ApiController]
    [Route("api")]
    public class Controller : ControllerBase
    {

        [HttpGet("get-ads")]
        public IEnumerable<Ads> Get()
        {
            var ads = ProductRepository.GetAds().OrderByDescending(s => s.Id);
            return ads;
        }

        [HttpGet("get-ad-by-id/{id}")]
        public Ads GetAdById(int id)
        {
            var ad = ProductRepository.GetAdById(id);
            return ad;
        }

        [HttpPost("post-ad")]
        public string Post([FromBody] BodyData data)
        {
            string result = ProductRepository.InsertAd(data);
            return result;
        }
    }
}