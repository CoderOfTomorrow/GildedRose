using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Items
{
    public class BackstageItem : Item
    {
        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality++;
                if (SellIn < 6)
                    Quality +=2;
                else if (SellIn < 11)
                    Quality++;
            }

            SellIn--;

            if (SellIn < 0)
                Quality = 0;
        }
    }
}
