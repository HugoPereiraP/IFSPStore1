using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities;

public class SaleItem : BaseEntity<int>
{
    public Sale Sale { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal UnitaryValue { get; set; }
    public decimal TotalValue { get; set; }


    public SaleItem()
    {
    }

    public SaleItem(int id, int quantity, decimal unitaryValue, decimal totalValue, Product product, Sale sale)
        : base(id)
    {
        Quantity = quantity;
        UnitaryValue = unitaryValue;
        TotalValue = totalValue;
        Product = product;
        Sale = sale;
    }
}
