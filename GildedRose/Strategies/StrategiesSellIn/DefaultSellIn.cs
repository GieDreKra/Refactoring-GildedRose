using GildedRoseKata;

namespace GildedRose.Strategies.StrategiesSellIn
{
    public class DefaultSellIn : IStrategySellIn
    {
        public int GetSellIn(Item item)
        {
            return item.SellIn-1;
        }
        public bool Applies(string name)
        {
            return true;
        }
    }
}
