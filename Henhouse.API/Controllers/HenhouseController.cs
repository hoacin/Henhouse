using Henhouse.Logic.Animals;
using Henhouse.Logic.Manipulations;
using Henhouse.Logic.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Henhouse.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HenhouseController : ControllerBase
    {
        private readonly IHenhouse _henhouse;

        public HenhouseController(IHenhouse henhouse)
        {
            _henhouse = henhouse;
        }
        [HttpGet("AllChickens")]
        public Task<IEnumerable<Chicken>> GetAllChickensAsync() 
            => _henhouse.GetAllChickensAsync();
        [HttpGet("ChickenCategory/{chickenName}")]
        public Task<string> GetChickenCategoryAsync(string chickenName)
            => _henhouse.GetChickenCategoryAsync(chickenName);
        [HttpPost("AddChicken/{chickenName}/{chickenCategory}")]
        public async Task<ActionResult> AddChickenAsync(string chickenName, string chickenCategory) 
            => await _henhouse.AddChickenAsync(chickenName, chickenCategory) ? StatusCode(200) : StatusCode(404);
        [HttpDelete("RemoveChicken/{chickenName}")]
        public async Task<ActionResult> RemoveChickenAsync(string chickenName) 
            => await _henhouse.RemoveChickenAsync(chickenName) ? StatusCode(200) : StatusCode(404);
        [HttpPost("AddEgg/{chickenName}/{weightInGrams}/{isWhite}/{creationTime}")]
        public async Task<ActionResult> AddEggAsync(string chickenName, int weightInGrams, bool isWhite, DateTime creationTime) 
            => await _henhouse.AddEggAsync(chickenName, weightInGrams, isWhite, creationTime) ? StatusCode(200) : StatusCode(404);
        [HttpGet("GetAllEggs/{chickenName}")]
        public Task<IEnumerable<Egg>> GetAllEggsAsync(string chickenName)
            => _henhouse.GetAllEggsAsync(chickenName);
        

    }
}
