using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos.CharacterDtos
{
    public class getCharacterDto
    {
        
        public int id {get; set;} 
        public string name { get; set; } = "Fredo";
        public int hitPoints { get; set; } = 100;
    
    }
}