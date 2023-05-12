using Newtonsoft.Json;
using ValorantAPIWrapper.Models;

namespace ValorantAPIWrapper
{
    public class Maps
    {
        /// <summary>
        /// Retrieves a list of all maps in Valorant from the Valorant API.
        /// </summary>
        /// <returns>A list of MapModel objects representing each map in Valorant.</returns>
        public async static Task<List<MapModel>> GetAllMaps()
        {
            List<MapModel> maps;

            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://valorant-api.com/v1/maps");
                var response = await httpClient.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();
                var mapResponse = JsonConvert.DeserializeObject<MapResponse>(json);
                maps = mapResponse.Data;
            }

            return maps;
        }

        /// <summary>
        /// Retrieves a map in Valorant with the specified name.
        /// </summary>
        /// <param name="MapName">The name of the map to retrieve.</param>
        /// <returns>A MapModel object representing the map with the specified name, or null if no map is found.</returns>
        public async static Task<MapModel> GetMapByName(string MapName)
        {
            var maps = await GetAllMaps();
            var map = maps.Where(a => a.displayName.Equals(MapName.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            return map;
        }

        /// <summary>
        /// Retrieves a random map in Valorant from the list of available maps.
        /// </summary>
        /// <returns>A MapModel object representing the randomly selected map.</returns>
        public async static Task<MapModel> GetRandomMap()
        {
            var maps = await GetAllMaps();
            Random random = new Random(Guid.NewGuid().GetHashCode()); // Use a unique seed value
            int randomIndex = await Task.Run(() => random.Next(0, maps.Count)); // Generate a random index

            return maps[randomIndex];
        }
    }
}
