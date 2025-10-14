using IFSPStore.Domain.Base;


namespace IFSPStore.Domain.Entities;

public class Product : BaseEntity<int>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public DateTime PurchaseDate { get; set; }
    public string SaleUnity { get; set; }
    public Category Category { get; set; }


  public Product()
    { 
    }

    public Product(int id, string name, decimal price, int quantity, DateTime purchaseDate, string saleUnity, Category category)
        : base(id)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        PurchaseDate = purchaseDate;
        SaleUnity = saleUnity;
        Category = category;
    }
}