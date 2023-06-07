using Aurora.Entity;
using Aurora.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Aurora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Controller : ControllerBase
    {

        [HttpGet("/About")]
        public IEnumerable<Ads> Get()
        {
            var ads = ProductRepository.GetAds().OrderByDescending(s => s.Id);
            return ads;
        }

        [HttpPost]
        public string Post([FromBody] BodyData data)
        {
           string result = ProductRepository.InsertAd(data);
           return result;
        }

    }
}