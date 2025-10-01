
using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Customer  : BaseEntity<int>
    {
        public Customer(int id,string name,  string adress, string document ,string state, string district, City city) : base(id)
        {
            Name = name;
          Id = id;
            Adress = adress;
            Document = document;
            District = district;
          City = city;
         
        }

        public int Id { get; set; }
        public string Name { get; set; }   
        public string Adress { get; set; }
        public string Document { get; set; }
        public string District { get; set; }
        public City City { get; set; }
        


    }
}
