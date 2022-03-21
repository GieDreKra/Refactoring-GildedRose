using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public const string sulfuras = "Sulfuras, Hand of Ragnaros";
        public const string backstage_passes = "Backstage passes to a TAFKAL80ETC concert";
        public const string aged_bried = "Aged Brie";
        public const string conjured = "Conjured";

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items.ToList();
        }

        public void UpdateQuality()
        {
            Items = Items.Where(i => i.Name != sulfuras).ToList();

            foreach (var item in Items)
            {
                switch (item.Name)
                {
                    case aged_bried:
                        item.Quality = item.Quality < 50 ? item.Quality + 1 : item.Quality;
                        break;
                    case backstage_passes:
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                            item.Quality = ((item.SellIn < 11) && (item.Quality < 50)) ? item.Quality + 1 : item.Quality;
                            item.Quality = ((item.SellIn < 6) && (item.Quality < 50)) ? item.Quality + 1 : item.Quality;
                        }
                        break;
                    case conjured:
                        item.Quality = (item.Quality > 0) ? item.Quality - 2 : item.Quality;
                        break;
                    default:
                        item.Quality = (item.Quality > 0) ? item.Quality - 1 : item.Quality;
                        break;
                }

                item.SellIn--;

                if (item.SellIn < 0)
                {
                    switch (item.Name)
                    {
                        case aged_bried:
                            item.Quality = (item.Quality < 50) ?
                                item.Quality + 1 : item.Quality;
                            break;
                        case backstage_passes:
                            item.Quality = 0;
                            break;
                        case conjured:
                            item.Quality = (item.Quality > 0) ? item.Quality - 2 : item.Quality;
                            break;
                        default:
                            item.Quality = (item.Quality > 0) ? item.Quality - 1 : item.Quality;
                            break;
                    }
                }
            }
        }
    }
}
