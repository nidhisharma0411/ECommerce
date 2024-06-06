public class OrderCsvRecord
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
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerAddress { get; set; }
    public string ProductName { get; set; }
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public decimal TotalPrice { get; set; }
}
