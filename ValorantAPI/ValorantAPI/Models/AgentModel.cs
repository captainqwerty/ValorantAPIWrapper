using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantAPI.Models;

namespace ValorantAPI.Models
{
    public class AgentModel
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string developerName { get; set; }
        public string displayIcon { get; set; }
        public string displayIconSmall { get; set; }
        public List<AbilityModel> abilities { get; set; }
    }
}
