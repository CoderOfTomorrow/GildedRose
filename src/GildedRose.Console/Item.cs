using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Items
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public virtual void UpdateQuality()
        {
            if (Quality > 0)
                Quality--;

            SellIn--;

            if (SellIn < 0 && Quality > 0)
                Quality--;
        }
    }
}
