using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities;

public class Customer : BaseEntity<int>
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Document { get; set; }
    public string Neighborhood { get; set; }
    public City City { get; set; }
    public List<Sale> Purchases { get; set; }

    public Customer()
    {
    }

    public Customer(int id, string name, string address, string document, string neighborhood, List<Sale> purchases, City city)
        : base(id)
    {
        Name = name;
        Address = address;
        Document = document;
        Neighborhood = neighborhood;
        Purchases = purchases;
        City = city;
    }
}
