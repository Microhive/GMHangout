namespace WebApplication7.Shared
{
    public class PC : ICharacter
    {
        public int Level { get; set; }

        public string Name { get; set; }

        public string Player { get; set; }

        public Class Class { get; set; }

        public Race Race { get; set; }

        public Status Status { get; set; }
    }
}
