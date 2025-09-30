using IFSPStore.Domain.Base;
using System.Text.RegularExpressions;

namespace IFSPStore.Domain.Entities;

public class Product : BaseEntity<int>
{
    public string Name { get; set; }
    public decimal Value { get; set; }
    public int Quantity { get; set; }
    public DateTime PurchaseDate { get; set; }
    public string SaleUnity { get; set; }
    public Group Group { get; set; }


    public Product()
    {
    }

    public Product(int id, string name, decimal value, int quantity, DateTime purchaseDate, string saleUnity, Group group)
        : base(id)
    {
        Name = name;
        Value = value;
        Quantity = quantity;
        PurchaseDate = purchaseDate;
        SaleUnity = saleUnity;
        Group = group;
    }
}
