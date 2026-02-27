using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<string> Fruits = new List<string>()
        {
            "apple",
            "banana",
            "orange",
            "grape",
        };
        [HttpGet]
        public List<string> GetFruits()
        {
            return Fruits;
        }

        [HttpGet("{id}")]
        public string GetFruitsByIndex(int id)
        {
            return Fruits.ElementAt(id);
        }
    }
}
