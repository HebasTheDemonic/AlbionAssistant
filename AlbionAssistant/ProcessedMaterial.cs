using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionAssistant
{
    internal class ProcessedMaterial : ICraftableItem
    {
        internal string Name { get; set; }
        internal double Tier { get; set; }
        internal int Price { get; set; }

        internal ProcessedMaterial(string name, double tier)
        {
            this.Name = name;
            this.Tier = tier;
        }
    }
}
