namespace Strategy.Strategies
{
    public class DefaultStrategy : IProductTypeStrategy
    {
        public string ExecuteStrategy()
        {
            return "Executing Default Strategy";
        }
     }
}
