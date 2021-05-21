using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_rpg.Dtos.CharacterDtos;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {

            new Character(),
            new Character{name = "Sam", id=1}

        };

        public IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public  async Task<ServiceResponse<List<Character>>> addCharacter(Character character)
        {
            characters.Add(character);
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.message = "Data added successfully";
            serviceResponse.Data = characters;
            return serviceResponse;
        
        }

        public async Task<ServiceResponse<List<Character>>> getAllCharacters()
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.message = "Fetch all data successfully";
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<getCharacterDto>> getCharacterById(int id)
        {
           Character character =  characters.FirstOrDefault(c => c.id == id);
           ServiceResponse<getCharacterDto> serviceResponse = new ServiceResponse<getCharacterDto>();
           serviceResponse.message = "Fetch single data successfully";
           serviceResponse.Data = _mapper.Map<getCharacterDto>(character);
           return serviceResponse;
        }
    }
}