namespace Strategy.Strategies
{
    public class TabletsStrategy : IProductTypeStrategy
    {
        public string ExecuteStrategy()
        {
            return "Executing Tablets Strategy";
        }
    }
}
