using GildedRose.Console.Items;
using System.Collections.Generic;

namespace GildedRose.Console
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedItem {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new SulfurusItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new BackstageItem{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 15,Quality = 20},
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            foreach (var obj in Items)
                obj.UpdateQuality();

            ShowInfo(Items);
            System.Console.ReadKey();

        }
       public static void ShowInfo(List<Item> list)
        {
            foreach (var obj in list)
            {
                System.Console.WriteLine("Name : " + obj.Name + " Quality : " + obj.Quality + " SellIn : " + obj.SellIn);
            }
        }
    }
}
