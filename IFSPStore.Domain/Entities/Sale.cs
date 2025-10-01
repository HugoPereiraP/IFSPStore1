

using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    internal class Sale : BaseEntity<int>
    {
        public Sale(int id, DateTime saleDate, decimal totalValue, Customer customer, User user) : base(id)
        {
            SaleDate = saleDate;
            TotalValue = totalValue;
            Customer = customer;
            User = user;
        }

        public DateTime SaleDate { get; set; }
        public decimal TotalValue { get; set; }
        public Customer Customer { get; set; }
        public User User { get; set; }

        public int UserId => User?.Id ?? 0;
    }
    }



