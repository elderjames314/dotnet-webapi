using dotnet_rpg.Models;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService icharacterService;
        public CharacterController(ICharacterService _icharacterService)
        {
            icharacterService = _icharacterService;
        }
        
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Character>>> Get() {
            return Ok( await icharacterService.getAllCharacters());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> getSingleCharacter(int id) {
            return Ok( await icharacterService.getCharacterById(id));
        }
        [HttpPost]
        public async Task<ActionResult<List<Character>>> addCharacter(Character newCharacter) {
            return Ok(await icharacterService.addCharacter(newCharacter));
        }

        [HttpGet]
        public ActionResult GetDemo() {
            return Ok("James Oladimeji");
        }
    }
}