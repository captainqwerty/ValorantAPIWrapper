using System.Collections.Generic;

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
        public Role role { get; set; }
        public List<Ability> abilities { get; set; }
        public VoiceLine voiceLine { get; set; }
    }

    public class MediaList
    {
        public int id { get; set; }
        public string wwise { get; set; }
        public string wave { get; set; }
    }

    public class VoiceLine
    {
        public double minDuration { get; set; }
        public double maxDuration { get; set; }
        public List<MediaList> mediaList { get; set; }
    }

    public class Ability
    {
        public string displayName { get; set; }
        public string description { get; set; }
        public string displayIcon { get; set; }
    }

    public class Role
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string displayIcon { get; set; }
        public string assetPath { get; set; }
    }
}
