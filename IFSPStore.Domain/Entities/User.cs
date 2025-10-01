

using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User(int id, string name, string email, string password, string login, DateTime registerDate, DateTime loginDate, int ativobinary) : base(id)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Login = login;
            RegisterDate = registerDate;
            LoginDate = loginDate;
            Ativobinary = ativobinary;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LoginDate { get; set; }
        public int Ativobinary { get; set; }

        
    }
}
