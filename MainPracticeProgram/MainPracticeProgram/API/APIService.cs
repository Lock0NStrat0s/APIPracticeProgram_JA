using Newtonsoft.Json;
using System;

namespace MainPracticeProgram.API
{
    public abstract class APIService : IAPIService
    {
        private string _url { get; set; }
        private readonly HttpClient _httpClient;

        protected APIService(string url, HttpClient httpClient)
        {
            _url = url;
            _httpClient = httpClient;
        }

        public async Task<TResponse> GetApiResponse<TResponse>()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(_url);
                var results = JsonConvert.DeserializeObject<TResponse>(response);
                if (results is null) return Activator.CreateInstance<TResponse>();
                return results;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
