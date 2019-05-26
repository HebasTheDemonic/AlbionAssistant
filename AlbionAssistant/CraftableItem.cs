using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionAssistant
{
    internal class CraftableItem 
    {
        internal ProcessedResource PrimaryMaterialCraftable { get; set; }
        public RawResource PrimaryMaterialRaw { get; set; }
        internal int PrimaryAmount { get; set; }
        internal ProcessedResource SecondaryMaterial { get; set; }
        internal int SecondaryAmount { get; set; }

        internal CraftableItem()
        {

        }

        internal CraftableItem(ProcessedResource primary, ProcessedResource secondary, int primaryAmount, int secondaryAmount)
        {
            this.PrimaryMaterialCraftable = primary;
            this.SecondaryMaterial = secondary;
            this.PrimaryAmount = primaryAmount;
            this.SecondaryAmount = secondaryAmount;
        }

        internal CraftableItem(RawResource primary, ProcessedResource secondary, int primaryAmount, int secondaryAmount)
        {
            this.PrimaryMaterialRaw = primary;
            this.SecondaryMaterial = secondary;
            this.PrimaryAmount = primaryAmount;
            this.SecondaryAmount = secondaryAmount;
        }
    }
}
