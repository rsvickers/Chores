

namespace Chores.Services;

public class AnimeCharactersService
{

    private readonly AnimeCharactersRepository _animeCharactersRepository;
    public AnimeCharactersService(AnimeCharactersRepository animeCharactersRepository)
    {
        _animeCharactersRepository = animeCharactersRepository;
    }


    internal List<AnimeCharacter> GetCharacters()
    {
        List<AnimeCharacter> animeCharacters = _animeCharactersRepository.GetCharacters();
        return animeCharacters;
    }
    internal AnimeCharacter GetCharacterById(int characterId)
    {
        AnimeCharacter animeCharacter = _animeCharactersRepository.GetCharacterById(characterId);
        if (animeCharacter == null)
        {
            throw new Exception($"Invalid idL {characterId}");
        }
        return animeCharacter;
    }

    internal AnimeCharacter CreateCharacter(AnimeCharacter characterData)
    {
        if (characterData.Name == null)
        {
            throw new Exception("Please provide a name");
        }
        AnimeCharacter animeCharacter = _animeCharactersRepository.CreateCharacter(characterData);
        return animeCharacter;
    }

    internal string DestroyCharacter(int characterId)
    {
        AnimeCharacter animeCharacter = GetCharacterById(characterId);
        _animeCharactersRepository.DestroyCharacter(animeCharacter);

        return $"{animeCharacter.Name} has been destroyed!";
    }
}
