namespace Chores.Models;

public class AnimeCharacter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AnimeTitle { get; set; }
    public bool HasPower { get; set; }
    public bool HasSadBackStory { get; set; }
    public int NumberOfParents { get; set; }


    public AnimeCharacter(int id, string name, string animeTitle, bool hasPower, bool hasSadBackStory, int numberOfParents)
    {
        Id = id;
        Name = name;
        AnimeTitle = animeTitle;
        HasPower = hasPower;
        HasSadBackStory = hasSadBackStory;
        NumberOfParents = numberOfParents;
    }
}

