using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using ValorantAPI.Models;

namespace ValorantAPI
{
    public class Maps
    {
        /// <summary>
        /// Retrieves a list of all maps in Valorant from the Valorant API.
        /// </summary>
        /// <returns>A list of MapModel objects representing each map in Valorant.</returns>
        public static List<MapModel> GetAllMaps()
        {
            List<MapModel> maps;

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("https://valorant-api.com/v1/maps");
                MapResponse response = JsonConvert.DeserializeObject<MapResponse>(json);
                maps = response.Data;
            }

            return maps;
        }

        /// <summary>
        /// Retrieves a map in Valorant with the specified name.
        /// </summary>
        /// <param name="MapName">The name of the map to retrieve.</param>
        /// <returns>A MapModel object representing the map with the specified name, or null if no map is found.</returns>
        public static MapModel GetMapByName(string MapName)
        {
            return GetAllMaps().Where(a => a.displayName.Equals(MapName.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves a random map in Valorant from the list of available maps.
        /// </summary>
        /// <returns>A MapModel object representing the randomly selected map.</returns>
        public static MapModel GetRandomMap()
        {
            var maps = GetAllMaps();
            Random random = new Random(Guid.NewGuid().GetHashCode()); // Use a unique seed value
            int randomIndex = random.Next(0, maps.Count); // Generate a random index

            return maps[randomIndex];
        }
    }
}
