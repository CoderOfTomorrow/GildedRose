using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Items
{
    public class AgedItem : Item
    {
        public override void UpdateQuality()
        {
            if (Quality < 50)
                Quality--;

            SellIn--;

            if (SellIn < 0 && Quality < 50)
                Quality++;
        }
    }
}
