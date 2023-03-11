using System.Collections.Generic;

namespace ValorantAPI.Models
{
    public class MapResponse
    {
        public List<MapModel> Data { get; set; }
    }

    public class MapModel
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public string coordinates { get; set; }
        public string displayIcon { get; set; }
        public string listViewIcon { get; set; }
        public string splash { get; set; }
        public string assetPath { get; set; }
        public string mapUrl { get; set; }
        public double xMultiplier { get; set; }
        public double yMultiplier { get; set; }
        public double xScalarToAdd { get; set; }
        public double yScalarToAdd { get; set; }
        public List<Callout> callouts { get; set; }
    }

    public class Callout
    {
        public string regionName { get; set; }
        public string superRegionName { get; set; }
        public Location location { get; set; }
    }

    public class Location
    {
        public double x { get; set; }
        public double y { get; set; }
    }
}
