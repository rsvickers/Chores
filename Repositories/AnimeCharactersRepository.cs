



namespace Chores.Repositories;

public class AnimeCharactersRepository
{
    private List<AnimeCharacter> _animeCharacters;

    public AnimeCharactersRepository()
    {
        _animeCharacters = [
            new AnimeCharacter(1, "Kaneki", "Tokyo Ghoul", true, true, 0),
    new AnimeCharacter(2, "Emilia", "Re Zero", true, true, 0),
    new AnimeCharacter(3, "Luffy", "One Piece", true, false, 1),
    new AnimeCharacter(4, "Hinata", "Haikyuu", false, false, 2)
        ];
    }


    internal List<AnimeCharacter> GetCharacters()
    {
        return _animeCharacters;
    }
    internal AnimeCharacter GetCharacterById(int characterId)
    {
        AnimeCharacter foundCharacter = _animeCharacters.Find(c => c.Id == characterId);
        return foundCharacter;
    }

    internal AnimeCharacter CreateCharacter(AnimeCharacter characterData)
    {
        AnimeCharacter lastCharacter = _animeCharacters[_animeCharacters.Count - 1];
        if (lastCharacter == null)
        {
            characterData.Id = 1;
        }
        else
        {
            characterData.Id = lastCharacter.Id + 1;
        }
        _animeCharacters.Add(characterData);
        return characterData;
    }

    internal void DestroyCharacter(AnimeCharacter animeCharacter)
    {
        _animeCharacters.Remove(animeCharacter);
    }
}