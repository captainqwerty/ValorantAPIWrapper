using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantAPI.Models
{
    public class VoiceLineModel
    {
        public double minDuration { get; set; }
        public double maxDuration { get; set; }
        public List<MediaListModel> mediaList { get; set; }
    }
}
