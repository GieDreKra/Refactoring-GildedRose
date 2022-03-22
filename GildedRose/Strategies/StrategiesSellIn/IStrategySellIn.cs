using GildedRoseKata;

namespace GildedRose.Strategies.StrategiesSellIn
{
    public interface IStrategySellIn
    {
        bool Applies(string name);
        int GetSellIn(Item item);
    }
}
