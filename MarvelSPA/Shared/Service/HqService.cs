using MarvelSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MarvelSPA.Shared.Service
{
    public static class HqService
    {
        public static async Task<Resposta> BuscarHqsByCharacterId(int id)
        {
            var _http = new HttpClient();
            var url = $"http://gateway.marvel.com/v1/public/characters/{id}/comics?apikey=d659481d3f02d81e5ec1b11d8f40a089&hash=f4cc18f4da2791ef5d1d06b6a8d5c7d0&ts=1637856513";

            var httpRequestMessage = new HttpRequestMessage()
            {
                Method = new HttpMethod("GET"),
                RequestUri = new Uri(url),
            };

            httpRequestMessage.Headers.Add("Accept", "*/*");

            var response = await _http.SendAsync(httpRequestMessage);

            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Resposta>(content);
        }
    }
}