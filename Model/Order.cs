public class Order
{
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public int ProductID { get; set; }
    public DateTime DateOfSale { get; set; }
    public int QuantitySold { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public decimal ShippingCost { get; set; }
    public string PaymentMethod { get; set; }
    public decimal TotalPrice { get; set; }

    public Customer Customer { get; set; }
    public Product Product { get; set; }
}
