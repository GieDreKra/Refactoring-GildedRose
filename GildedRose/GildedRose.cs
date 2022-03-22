using GildedRose;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public CalculationService _calculationService;

        IList<Item> Items;
        public GildedRose(IList<Item> Items,CalculationService calculationService)
        {
            this.Items = Items.ToList();
            _calculationService = calculationService;
        }

        public void Update()
        {
            foreach (var item in Items)
            {
                item.SellIn = _calculationService.UpdateItemSellIn(item);
                item.Quality = _calculationService.UpdateItemQuality(item);
            }
        }
    }
}
