using GildedRoseKata;

namespace GildedRose.Strategies
{
    public class Default : IStrategy
    {
        public int GetQuality(Item item)
        {
            item.Quality = (item.SellIn < 0) ? item.Quality - 2 : item.Quality - 1;
            return item.Quality > 0 ? item.Quality : 0;
        }
        public bool Applies(string name)
        {
            return true;
        }
    }
}
