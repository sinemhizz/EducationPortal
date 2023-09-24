using EducationPortal.Entities.Dtos;
using EducationPortal.Entities.Entities;
using System.Runtime.CompilerServices;

namespace EducationPortal.WEB.Service
{
    public class UserApiService
    {
        private readonly HttpClient _httpClient;

        public UserApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<User>> GetUser()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<User>>>("Users/all");

            return response.Data;
        }
    }
}
