using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ValorantAPI.Models;

namespace ValorantAPI
{
    public class ValorantAPI
    {
        public static List<AgentModel> GetAgents()
        {
            string json;
            using (var webClient = new System.Net.WebClient())
            {
                json = webClient.DownloadString("https://valorant-api.com/v1/agents");
            }

            List<AgentModel> data = JsonConvert.DeserializeObject<List<AgentModel>>(json);
            List<AgentModel> agents = data;

            return agents;
        }
    }
}
