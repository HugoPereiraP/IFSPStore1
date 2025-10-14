using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using System.Text.Json;
namespace IFSPStore.Test;

    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestCategory()
        {
            using (var context = new IFSPStoreContext())
            {
                Console.WriteLine("");

            var category1 = new Category(1, "Carnes","Comida");
            var category2 = new Category(2, "Bebidas","Bebida");
            var category3 = new Category(3, "Doces","Comida");
            
            context.Categories.Add(category1);
            context.Categories.Add(category2);
            context.Categories.Add(category3);

            context.SaveChanges();
        }

        using (var context = new IFSPStoreContext())
        {
            foreach (var cat in context.Categories)
            {
                Console.WriteLine(JsonSerializer.Serialize(cat));
            }

   
        }
        Console.WriteLine("List done!");
        }
    }

