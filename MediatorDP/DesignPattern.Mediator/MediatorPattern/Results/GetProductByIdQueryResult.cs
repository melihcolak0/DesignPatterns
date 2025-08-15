namespace DesignPattern.Mediator.MediatorPattern.Results
{
    public class GetProductByIdQueryResult
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public string ProductStockType { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCategory { get; set; }
    }
}
