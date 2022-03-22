using GildedRoseKata;

namespace GildedRose.Strategies
{
    public interface IStrategy
    {
        bool Applies(string name);
        int GetQuality(Item item);

    }
}
