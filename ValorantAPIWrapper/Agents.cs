using Newtonsoft.Json;
using ValorantAPIWrapper.Models;

namespace ValorantAPIWrapper
{
    // https://dash.valorant-api.com/endpoints/agents
    public class Agents
    {
        /// <summary>
        /// Retrieves a list of all playable agents in Valorant from the Valorant API.
        /// </summary>
        /// <returns>A list of AgentModel objects representing each playable agent in Valorant.</returns>
        public static async Task<List<AgentModel>> GetAllAgents()
        {
            var agents = new List<AgentModel>();

            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://valorant-api.com/v1/agents?isPlayableCharacter=true");
                var response = await httpClient.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();
                var agentsResponse = JsonConvert.DeserializeObject<AgentsResponse>(json);
                agents = agentsResponse.Data;
            }

            return agents;
        }

        /// <summary>
        /// Searches for a playable agent in Valorant whose name contains the specified search term.
        /// </summary>
        /// <param name="agentName">The search term to look for in agent names.</param>
        /// <returns>An AgentModel object representing the agent whose name contains the search term, or null if no agent is found.</returns>
        public async static Task<AgentModel> GetAgentByName(string agentName)
        {
            var agents = await GetAllAgents();
            return agents.FirstOrDefault(a => a.displayName.ToLower().Contains(agentName.Trim().ToLower()));
        }

        /// <summary>
        /// Retrieves a random playable agent in Valorant from the list of available agents.
        /// </summary>
        /// <returns>An AgentModel object representing the randomly selected agent.</returns>
        public async static Task<AgentModel> GetRandomAgent()
        {
            var randomAgents = await GetRandomAgents();
            return randomAgents[0];
        }

        /// <summary>
        /// Retrieves a list of randomly selected playable agents in Valorant from the list of available agents.
        /// </summary>
        /// <param name="n">The number of agents to retrieve. Default is 1.</param>
        /// <returns>A list of AgentModel objects representing the randomly selected agents.</returns>
        public async static Task<List<AgentModel>> GetRandomAgents(int n = 1)
        {
            var agents = await GetAllAgents();
            Random random = new Random(Guid.NewGuid().GetHashCode()); // Use a unique seed value
            HashSet<AgentModel> selectedAgents = new(); // Generate a random index
            List<AgentModel> result = new();

            if (n >= agents.Count)
            {
                result.AddRange(agents.OrderBy(a => random.Next()));
                return result;
            }

            while (result.Count < n && selectedAgents.Count < agents.Count)
            {
                int randomIndex = await Task.Run(() => random.Next(0, agents.Count));
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