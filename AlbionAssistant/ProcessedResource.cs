using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionAssistant
{
    internal class ProcessedResource : CraftableItem
    {
        internal string Type { get; set; }
        internal double Tier { get; set; }
        internal int Price { get; set; }

        internal ProcessedResource(string type, double tier, bool craftMe = false)
        {
            this.Type = type;
            this.Tier = tier;
            if (craftMe)
            {

            }
        }
    }
}
