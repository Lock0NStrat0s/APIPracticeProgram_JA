using MainPracticeProgram.API;
using MainPracticeProgram.API.Responses;
using MainPracticeProgram.Models;

namespace MainPracticeProgram.ViewModels
{
    internal class NarutoViewModel
    {
        public async Task<CharacterModel> GetCharacterInfo(int extension)
        {

            var client = new HttpClient();
            var character = new CharacterModel();

            string url = $"https://dattebayo-api.onrender.com/characters/{extension}";

            var narutoApiService = new NarutoApiService(url, client);
            var response = await narutoApiService.GetApiResponse<NarutoSingleModelApiResponse>();
            NarutoCharacterMapper(character, response);

            return character;
        }

        private static void NarutoCharacterMapper(CharacterModel character, NarutoSingleModelApiResponse response)
        {
            character.Id = response.id;
            character.Name = response.name;

            if (response.tools.Count > 0)
            {
                foreach (var tool in response.tools)
                {
                    character.Tools.Add(tool);

                }
            }
        }
    }
}
