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
    public class DecoratorCalculationStrategy : IPriceCalculationStrategy
    {
        private List<IPriceCalculationStrategy> _strategyList;
        
        public DecoratorCalculationStrategy(List<IPriceCalculationStrategy> strategyList)
        {
            _strategyList = strategyList;
        }
        
        public List<PriceComponent> CalculatePrice(PlaceInRun placeInRun)
        {
            var components = new List<PriceComponent>();
            foreach (var strategy in _strategyList)
            {
                components.AddRange(strategy.CalculatePrice(placeInRun));
            }

            return components;
        }
    }
}