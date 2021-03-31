using Strategy.Strategies;
using System.Collections.Generic;

namespace Strategy
{
    public static class ProductTypeStrategiesFactory
    {
        public static Dictionary<ProductType, IProductTypeStrategy> CreateStrategies()
        {
            return new Dictionary<ProductType, IProductTypeStrategy>
            {
                [ProductType.NotSet] = new DefaultStrategy(),
                [ProductType.Computer] = new ComputersStragety(),
                [ProductType.Phone] = new PhonesStragety(),
                [ProductType.Tablet] = new TabletsStrategy()
            };
        }
    }
}
