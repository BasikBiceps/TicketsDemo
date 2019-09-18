using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsDemo.Data.Entities;
using TicketsDemo.Data.Repositories;
using TicketsDemo.Domain.Interfaces;

namespace TicketsDemo.Domain.DefaultImplementations.PriceCalculationStrategy
{
    public class TeaPriceCalculationStrategy : IPriceCalculationStrategy
    {
        private IPriceCalculationStrategy _defaultPriceCalculationStrategy;

        public TeaPriceCalculationStrategy(IPriceCalculationStrategy defaultPriceCalculationStrategy)
        {
            _defaultPriceCalculationStrategy = defaultPriceCalculationStrategy;
        }

        public List<PriceComponent> CalculatePrice(PlaceInRun placeInRun)
        {
            var priceComponents = _defaultPriceCalculationStrategy.CalculatePrice(placeInRun);

            var teaComponent = new PriceComponent()
            {
                Name = "Price for tea",
                Value = 50
            };
            priceComponents.Add(teaComponent);

            return priceComponents;
        }
    
    }
}
