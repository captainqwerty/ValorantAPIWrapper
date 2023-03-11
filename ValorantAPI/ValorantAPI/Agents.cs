using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using ValorantAPI.Models;

namespace ValorantAPI
{
    public class Agents
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
    }
}
