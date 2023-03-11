using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using ValorantAPI.Models;

namespace ValorantAPI
{
    public class AgentsResponse
    {
        public List<AgentModel> Data { get; set; }
    }

    public class MapResponse
    {
        public List<MapModel> Data { get; set; }
    }

    public class ValorantAPI
    {
        public static List<AgentModel> GetAllAgents()
        {
            List<AgentModel> agents;

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("https://valorant-api.com/v1/agents");
                AgentsResponse response = JsonConvert.DeserializeObject<AgentsResponse>(json);
                agents = response.Data;
            }

            return agents;
        }

        public static AgentModel GetAgentByName(string AgentName)
        {
            var agents = GetAllAgents();
            var agent = agents.Where(a => a.displayName.Equals(AgentName.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            return agent;
        }

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
            var maps = GetAllMaps ();
            var map = maps.Where(a => a.displayName.Equals(MapName.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            return map;
        }
    }
}
