using GildedRoseKata;

namespace GildedRose.Strategies
{
    public class BackstagePasses : IStrategy
    {
        public const string backstage_passes = "Backstage passes to a TAFKAL80ETC concert";
        public bool Applies(string name)
        {
            return name == backstage_passes;
        }

        public int GetQuality(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else
            {
                item.Quality++;
                item.Quality = (item.SellIn < 10) ? item.Quality + 1 : item.Quality;
                item.Quality = (item.SellIn < 5) ? item.Quality + 1 : item.Quality;
            }
            return item.Quality < 50 ? item.Quality : 50;
        }
    }
}
