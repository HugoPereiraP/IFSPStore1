using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities;

public class Sale : BaseEntity<int>
{
    public DateTime SaleDate { get; set; }
    public decimal totalPrice { get; set; }
    public User Salesman { get; set; }
    public Customer Customer { get; set; }
    public List<SaleItem> SaleItems { get; set; }

   public Sale()
    {
    }
    public Sale(int id, DateTime saledate, decimal Totalprice, List<SaleItem> items, User user, Customer customer)
        : base(id)
    {
        SaleDate = saledate;
        Totalprice = totalPrice;
        Salesman = user;
        Customer = customer;
    }
}