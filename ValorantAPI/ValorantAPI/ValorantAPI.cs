using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ValorantAPI.Models;

namespace ValorantAPI
{
    public class AgentsResponse
    {
        public List<AgentModel> Data { get; set; }
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
            var agent = agents.Where(a => a.displayName == AgentName).FirstOrDefault();

            return agent;
        }

        //public static SingleAgent GetAgentByUUID(string AgentUuid)
        //{
        //    var url = $"https://valorant-api.com/v1/agents/{AgentUuid}";
        //    var agent = new SingleAgent();
        //    using (var webClient = new System.Net.WebClient())
        //    {
        //        var json = webClient.DownloadString(url);
        //        agent = JsonConvert.DeserializeObject<SingleAgent>(json);
        //    }

        //    return agent;
        //}
    }
}
