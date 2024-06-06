public class Product
{
    public int ProductID { get; set; }
    public int CategoryID { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }

    public Category Category { get; set; }
    public ICollection<Order> Orders { get; set; }
}
