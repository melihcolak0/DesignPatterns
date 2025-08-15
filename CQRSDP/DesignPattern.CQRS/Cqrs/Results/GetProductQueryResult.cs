namespace DesignPattern.CQRS.Cqrs.Results
{
    public class GetProductQueryResult
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }       
    }
}
