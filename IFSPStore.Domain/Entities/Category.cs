
namespace IFSPStore.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
    }
}
