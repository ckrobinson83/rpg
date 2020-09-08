using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rpg.Models;
using rpg.Services.CharacterService;

namespace rpg.Controllers
{
    //If we were adding things like views, we'd just drive from Controller instead of ControllerBase
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
       
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }

        [HttpGet("GetAll")]
        public IActionResult GetAction()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
           
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}