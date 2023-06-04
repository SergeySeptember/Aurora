using Aurora.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Aurora.Repository;
using Aurora.DBContext;
using System.Reflection.PortableExecutable;

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
        public string Post([FromBody] LoginData data)
        {
           string result = ProductRepository.InsertAd(data);
           return result;
        }

    }
}