using GildedRose.Strategies;
using GildedRose.Strategies.StrategiesSellIn;
using GildedRoseKata;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose
{
    public class CalculationService
    {
        public int UpdateItemQuality(Item item)
        {
            List<IStrategy> strategies = new List<IStrategy>
            {
                new Sulfuras(),
                new BackstagePasses(),
                new AgedBrie(),
                new Default()
            };

            var selectedStrategy = strategies.FirstOrDefault(s => s.Applies(item.Name));

            return selectedStrategy.GetQuality(item);
        }

        public int UpdateItemSellIn(Item item)
        {
            List<IStrategySellIn> strategies = new List<IStrategySellIn>
            {
                new SulfurasSellIn(),
                new DefaultSellIn()
            };

            var selectedStrategy = strategies.FirstOrDefault(s => s.Applies(item.Name));

            return selectedStrategy.GetSellIn(item);
        }
    }
}
