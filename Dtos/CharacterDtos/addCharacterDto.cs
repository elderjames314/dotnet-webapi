using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos.CharacterDtos
{
    public class addCharacterDto
    {
        
        public int id {get; set;} 
        public string name { get; set; } = "Fredo";
        public int hitPoints { get; set; } = 100;
        public int strength { get; set; } = 10;
        public int defense { get; set; } = 10;
        public int intelligence { get; set; } = 10;
        public RpgClass characterClass { get; set; } = RpgClass.Cleric;
    }
}