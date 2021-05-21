using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.CharacterDtos;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
         Task< ServiceResponse<List<Character>>> getAllCharacters();
         Task<ServiceResponse<getCharacterDto>> getCharacterById(int id);
         Task<ServiceResponse<List<Character>>> addCharacter(Character character);
         
    }
}