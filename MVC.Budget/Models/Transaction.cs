namespace MVC.Budget.Models
{
    public class Transaction
    {
        public int Id { get; init; }
        public string? Name { get; set; }
        public Category? Category { get; set; }
        public double Amount { get; set; }
        public DateTime Date {  get; set; }
    }
}
