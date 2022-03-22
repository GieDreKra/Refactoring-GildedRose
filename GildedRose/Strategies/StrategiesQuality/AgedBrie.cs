using GildedRoseKata;

namespace GildedRose.Strategies
{
    public class AgedBrie:IStrategy
    {
        public const string aged_bried = "Aged Brie";
        public int GetQuality(Item item)
        {
            item.Quality= (item.SellIn < 0)?item.Quality+2:item.Quality+1;
            return item.Quality < 50 ? item.Quality : 50;
        }
        public bool Applies(string name)
        {
            return name == aged_bried;
        }
    }
}
