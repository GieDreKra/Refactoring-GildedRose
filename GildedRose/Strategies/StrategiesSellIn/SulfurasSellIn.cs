using GildedRoseKata;

namespace GildedRose.Strategies.StrategiesSellIn
{
    public class SulfurasSellIn : IStrategySellIn
    {
        public const string sulfuras = "Sulfuras, Hand of Ragnaros";
        public int GetSellIn(Item item)
        {
            return item.SellIn;
        }
        public bool Applies(string name)
        {
            return name == sulfuras;
        }
    }
}
