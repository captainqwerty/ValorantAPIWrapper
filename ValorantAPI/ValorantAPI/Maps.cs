using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using ValorantAPI.Models;

namespace ValorantAPI
{
    public class Maps
    {
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

        public static MapModel GetMapByName(string MapName)
        {
            var maps = GetAllMaps();
            var map = maps.Where(a => a.displayName.Equals(MapName.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            return map;
        }

        public static MapModel GetRandomMap()
        {
            var maps = GetAllMaps();
            Random random = new Random(Guid.NewGuid().GetHashCode()); // Use a unique seed value
            int randomIndex = random.Next(0, maps.Count); // Generate a random index
            var randomMap = maps[randomIndex]; // Access the object at the random index

            return randomMap;
        }
    }
}
