using MauiStarterapp.Models;
using System.Diagnostics.Contracts;
using System.Net.Http.Json;
using System.Text.Json;

namespace MauiStarterapp.Services
{
    public class MonkeyService
    {
        private HttpClient _httpClient;
        private List<Monkey> _monkeyList = new();
        public MonkeyService()
        {
            this._httpClient = new HttpClient();
        }
        public async Task<List<Monkey>> GetRemoteMonkeys()
        {
            if (_monkeyList?.Count > 0)
                return _monkeyList;

            var response = await _httpClient.GetAsync("https://www.montemagno.com/monkeys.json");

            if (response.IsSuccessStatusCode)
            {
                _monkeyList = await response.Content.ReadFromJsonAsync(MonkeyContext.Default.ListMonkey);
            }

            return _monkeyList;
        }

        public async Task<List<Monkey>> GetLocalMonkeys()
        {
            if (_monkeyList?.Count > 0)
                return _monkeyList;
            using var stream = await FileSystem.OpenAppPackageFileAsync("monkeys.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            _monkeyList = JsonSerializer.Deserialize(contents, MonkeyContext.Default.ListMonkey); 
            return _monkeyList;
        }
    }
}
