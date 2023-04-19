using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Newtonsoft.Json;
using ValorantAPI.Models;

namespace ValorantAPI
{
    public class Agents
    {
        /// <summary>
        /// Retrieves a list of all playable agents in Valorant from the Valorant API.
        /// </summary>
        /// <returns>A list of AgentModel objects representing each playable agent in Valorant.</returns>
        public static List<AgentModel> GetAllAgents()
        {
            var agents = new List<AgentModel>();

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("https://valorant-api.com/v1/agents?isPlayableCharacter=true");
                AgentsResponse response = JsonConvert.DeserializeObject<AgentsResponse>(json);
                agents = response.Data;
            }

            return agents;
        }

        /// <summary>
        /// Searches for a playable agent in Valorant whose name contains the specified search term.
        /// </summary>
        /// <param name="agentName">The search term to look for in agent names.</param>
        /// <returns>An AgentModel object representing the agent whose name contains the search term, or null if no agent is found.</returns>
        public static AgentModel GetAgentByName(string agentName)
        {
            return GetAllAgents().FirstOrDefault(a => a.displayName.ToLower().Contains(agentName.Trim().ToLower()));
        }

        /// <summary>
        /// Searches for a playable agent in Valorant by UUID.
        /// </summary>
        /// <param name="agentUuid">The specific agent UUID to search for.</param>
        /// <returns>An AgentModel object representing the agent whose UUID matches that which was searched for, or null if no agent is found.</returns>
        public static AgentModel GetAgentByUUID(string agentUuid)
        {
            var agent = new List<AgentModel>();

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString($"https://valorant-api.com/v1/agents/{agentUuid}");
                AgentsResponse response = JsonConvert.DeserializeObject<AgentsResponse>(json);
                agent = response.Data;
            }
            
            return agent.FirstOrDefault();
        }

        /// <summary>
        /// Retrieves a random playable agent in Valorant from the list of available agents.
        /// </summary>
        /// <returns>An AgentModel object representing the randomly selected agent.</returns>
        public static AgentModel GetRandomAgent()
        {
            var randomAgent = GetRandomAgents();
            return randomAgent[0];
        }

        /// <summary>
        /// Retrieves a list of randomly selected playable agents in Valorant from the list of available agents.
        /// </summary>
        /// <param name="n">The number of agents to retrieve. Default is 1.</param>
        /// <returns>A list of AgentModel objects representing the randomly selected agents.</returns>
        public static List<AgentModel> GetRandomAgents(int n = 1)
        {
            var agents = GetAllAgents();
            Random random = new Random(Guid.NewGuid().GetHashCode()); // Use a unique seed value
            HashSet<AgentModel> selectedAgents = new HashSet<AgentModel>(); // Generate a random index
            List<AgentModel> result = new List<AgentModel>();

            if (n >= agents.Count)
            {
                result.AddRange(agents.OrderBy(a => random.Next()));
                return result;
            }

            while (result.Count < n && selectedAgents.Count < agents.Count)
            {
                int randomIndex = random.Next(0, agents.Count);
                var randomAgent = agents[randomIndex];
                if (!selectedAgents.Contains(randomAgent))
                {
                    selectedAgents.Add(randomAgent);
                    result.Add(randomAgent);
                }
            }

            return result;
        }
    }
}
