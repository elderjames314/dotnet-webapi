namespace dotnet_rpg.Models

{
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric 
    }
}