using System;

namespace Strategy
{
    class Program
    { 
        static void Main(string[] args)
        {
            var strategies = ProductTypeStrategiesFactory.CreateStrategies();

            ConsoleKeyInfo option;
            do
            {
                option = ReadOptionValue();

                var selectedProductType = DetermineProductTypeFromOption(option.KeyChar);

                Console.WriteLine();
                Console.WriteLine(strategies[selectedProductType].ExecuteStrategy());
                Console.WriteLine();
            }
            while (option.Key != ConsoleKey.Escape);
        }

        private static ConsoleKeyInfo ReadOptionValue()
        {
            Console.WriteLine("Strategies Menu");
            Console.WriteLine("Please type the strategy number to use:");
            Console.WriteLine("0 - Default Strategy");
            Console.WriteLine("1 - Computers Strategy");
            Console.WriteLine("2 - Phones Strategy");
            Console.WriteLine("3 - Tablets Strategy");
            Console.WriteLine("Press Esc to exit");

            return Console.ReadKey();
        }

        private static ProductType DetermineProductTypeFromOption(char consoleKeyChar)
        {
            object productType;
            if (Enum.TryParse(typeof(ProductType), consoleKeyChar.ToString(), out productType))
                return (ProductType)productType;

            return ProductType.NotSet;
        }
    }
}
