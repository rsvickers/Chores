
namespace Chores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimeCharactersController : ControllerBase
    {

        private readonly AnimeCharactersService _animeCharactersService;

        public AnimeCharactersController(AnimeCharactersService animeCharactersService)
        {
            _animeCharactersService = animeCharactersService;
        }

        [HttpGet]
        public ActionResult<List<AnimeCharacter>> GetCharacters()
        {
            try
            {
                List<AnimeCharacter> animeCharacters = _animeCharactersService.GetCharacters();
                return Ok(animeCharacters);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


        [HttpGet("{characterId}")]
        public ActionResult<AnimeCharacter> GetCharacterById(int characterId)
        {
            try
            {
                AnimeCharacter animeCharacter = _animeCharactersService.GetCharacterById(characterId);
                return Ok(animeCharacter);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }


        [HttpPost]
        public ActionResult<AnimeCharacter> CreateCharacter([FromBody] AnimeCharacter characterData)
        {
            try
            {
                AnimeCharacter animeCharacter = _animeCharactersService.CreateCharacter(characterData);
                return Ok(animeCharacter);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


        [HttpDelete("{characterId}")]
        public ActionResult<string> DestroyCharacter(int characterId)
        {
            try
            {
                string message = _animeCharactersService.DestroyCharacter(characterId);
                return Ok(message);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

    }
}