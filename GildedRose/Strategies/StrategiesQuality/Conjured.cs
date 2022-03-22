using GildedRoseKata;

namespace GildedRose.Strategies
{
    public class Conjured : IStrategy
    {
        public const string conjured = "Conjured Mana Cake";
        public int GetQuality(Item item)
        {
            item.Quality = (item.SellIn < 0) ? item.Quality - 4 : item.Quality - 2;
            return item.Quality > 0 ? item.Quality : 0;
        }
        public bool Applies(string name)
        {
            return name == conjured;
        }
    }
}
