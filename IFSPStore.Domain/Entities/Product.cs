

namespace IFSPStore.Domain.Entities
{
    public class Product

    {
       public Product(int id, string name, int quantity, decimal price, DateTime purchasedate, Category category)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Purchasedate = purchasedate;
            Category = category;


        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Purchasedate { get; set; }
        public Category Category { get; set; }
        }
}
