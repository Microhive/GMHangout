namespace WebApplication7.Shared
{
    public interface ICharacter
    {
        Class Class { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        Race Race { get; set; }
        Status Status { get; set; }
    }
}