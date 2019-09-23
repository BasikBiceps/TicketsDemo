using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsDemo.Data.Entities;
using TicketsDemo.Data.Repositories;
using TicketsDemo.Domain.Interfaces;

namespace TicketsDemo.Domain.DefaultImplementations
{
    public class StrategyFactory : IStrategyFactory
    {
        private IRunRepository _runRepository;
        private ITrainRepository _trainRepository;

        public StrategyFactory(IRunRepository runRepository, ITrainRepository trainRepository)
        {
            _runRepository = runRepository;
            _trainRepository = trainRepository;
        }

        public IPriceCalculationStrategy createCalculationStrategy(DTO.StrategyDTO strategyDTO)
        {
            List<IPriceCalculationStrategy> strategyList = new List<IPriceCalculationStrategy>();
            
            strategyList.Add(new PriceCalculationStrategy.DefaultPriceCalculationStrategy(_runRepository, _trainRepository));

            if (strategyDTO.IncludeTea)
            {
                strategyList.Add(new PriceCalculationStrategy.BeveragesPriceCalculationStrategy("Tea", Prices.Tea));
            }

            if (strategyDTO.IncludeCoffee)
            {
                strategyList.Add(new PriceCalculationStrategy.BeveragesPriceCalculationStrategy("Coffee", Prices.Coffee));
            }
            
            return new PriceCalculationStrategy.DecoratorCalculationStrategy(strategyList);
        }
    }
}
