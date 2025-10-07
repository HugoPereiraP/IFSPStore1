using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities;

public class Sale : BaseEntity<int>
{
    public DateTime Date { get; set; }
    public decimal totalPrice { get; set; }
    public User Salesman { get; set; }
    public Customer Customer { get; set; }
    public List<SaleItem> SaleItems { get; set; }

   public Sale()
    {
    }
    public Sale(int id, DateTime date, decimal Totalprice, List<SaleItem> items, User user, Customer customer)
        : base(id)
    {
        Date = date;
        Totalprice = totalPrice;
        Salesman = user;
        Customer = customer;
    }
}