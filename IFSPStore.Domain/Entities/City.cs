

using IFSPStore.Domain.Base;
using System.Security.Cryptography.X509Certificates;

namespace IFSPStore.Domain.Entities
{
    public class City : BaseEntity<int>
    {
            public City(int id, string name, string estate) : base(id)
            {
                Name = name;
                Estate = estate;
            }
            public string Name { get; set; }    
            public string Estate { get; set; }
    }
    
}
