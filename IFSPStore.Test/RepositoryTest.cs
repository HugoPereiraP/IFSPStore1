using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;

namespace IFSPStore.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestCategory()
        {
            using (var context = new IFSPStoreDbContext())
            {
                Assert.IsNotNull(context.Categories);
                Assert.IsNotNull(context.Cities);
                Assert.IsNotNull(context.Customers);
                Assert.IsNotNull(context.Products);
                Assert.IsNotNull(context.Sales);
                Assert.IsNotNull(context.SaleItems);
                Assert.IsNotNull(context.Users);

                Console.WriteLine("Banco conectado!");

                var category1 = new Category(1, "Carnes");
                var category2 = new Category(2, "Bebidas");
                var category3 = new Category(3, "Eletronicos");

                context.Categories.AddRange(category1, category2, category3);
                context.SaveChanges();
            }

            using (var context = new IFSPStoreDbContext())
            {
                var categories = context.Categories.ToList();
                Assert.IsTrue(categories.Count > 0);
                foreach (var category in categories)
                {
                    Console.WriteLine($"Id: {category.Id}, Nome: {category.Name}");
                }
            }
        }
    }
}
