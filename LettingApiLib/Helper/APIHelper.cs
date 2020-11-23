using LettingApiLib.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace LettingApiLib.Helper
{
    public class APIHelper
    {
  

        private HttpClient _apiClient;

        public HttpClient ApiClient
        {
            get
            {
                return _apiClient;
            }
        }
        public APIHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            // https://groups.google.com/g/devtargetprocess/c/1R1niz_WCFE?pli=1
            System.Net.ServicePointManager.SecurityProtocol = System.Net.ServicePointManager.SecurityProtocol | System.Net.SecurityProtocolType.Tls12;
            string api = ConfigurationManager.AppSettings["api"];
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
     
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        }

        public async Task<House> GetHouseById(int Id)
        {
            return await _apiClient.GetFromJsonAsync<House>($"/api/Houses/GetHouseById/{Id}");
        }
        public async Task<House[]> GetHouses()
        {
           return await _apiClient.GetFromJsonAsync<House[]>("/api/Houses/GetHouses");
        }

        public async Task UpdateHome(House home)
        {
            await _apiClient.PutAsJsonAsync($"/api/Houses/UpdateHouse/{home.Id}", home);
        }
        public async Task<House> AddHome(House Home)
        {
            var result = await _apiClient.PostAsJsonAsync("/api/Houses/AddHouse", Home);
            var ResultHome = await result.Content.ReadFromJsonAsync<House>();
            return ResultHome;
        }
        public async Task DelateHouse(int Id)
        {
            await _apiClient.DeleteAsync($"/api/Houses/DeleteHouse/{Id}");
        }
        // Landlords
        public async Task<Landlord[]> GetLandlords()
        {
            return await _apiClient.GetFromJsonAsync<Landlord[]>("/api/Landlords/GetLandlords");
        }
        public async Task<Landlord> GetLandlordById(int Id)
        {
            return await _apiClient.GetFromJsonAsync<Landlord>($"/api/Landlords/GetLandlord/{Id}");
        }
        public async Task SaveLandlord(Landlord landlord)
        {
            await _apiClient.PutAsJsonAsync($"/api/Landlords/UpdateLandlord/{landlord.Id}", landlord);
        }
        public async Task<Landlord> AddLandlord(Landlord landlord)
        {
            var result = await _apiClient.PostAsJsonAsync("/api/Landlords/AddLandlord", landlord);
            var Resultlandlord = await result.Content.ReadFromJsonAsync<Landlord>();
            return Resultlandlord;
        }
        public async Task DelateLandlord(int Id)
        {
            await _apiClient.DeleteAsync($"/api/Landlords/DeleteLandlord/{Id}");
        }
        public async Task<Landlord> GetLandlordWithHouse(int Id)
        {
            return await _apiClient.GetFromJsonAsync<Landlord>($"api/Landlords/GetLandlordWithHouse/{Id}");
        }
    }
}
