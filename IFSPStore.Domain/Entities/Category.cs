using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities;

public class Category : BaseEntity<int>
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }

    public Category()
    {
    }

    public Category(int id, string name, List<Product> products)
        : base(id)
    {
        Name = name;
        Products = products;
    }
}
