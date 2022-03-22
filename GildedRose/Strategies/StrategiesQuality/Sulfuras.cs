using GildedRoseKata;

namespace GildedRose.Strategies
{
    public class Sulfuras : IStrategy
    {
        public const string sulfuras = "Sulfuras, Hand of Ragnaros";
        public int GetQuality(Item item)
        {
            return item.Quality;
        }
        public bool Applies(string name)
        {
            return name == sulfuras;
        }
    }

}
