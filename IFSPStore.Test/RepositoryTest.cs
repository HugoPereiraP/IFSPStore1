using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;

namespace IFSPStore.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestCategory()
        {
            //    using (var context = new IFSPStoreDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<IFSPStoreDbContext>(

            //        ))
            //    {
            //        Assert.IsNotNull(context.Categories);
            //        Assert.IsNotNull(context.Cities);
            //        Assert.IsNotNull(context.Customers);
            //        Assert.IsNotNull(context.Products);
            //        Assert.IsNotNull(context.Sales);
            //        Assert.IsNotNull(context.SaleItems);
            //        Assert.IsNotNull(context.Users);

            //        Console.WriteLine("Banco conectado!");

            //        if(!context.Categories.Any())
            //        {
            //            var category1 = new Category(1, "Carnes", "Carnes legais");
            //            var category2 = new Category(2, "Bebidas", "Bebidas legais");
            //            var category3 = new Category(3, "Eletronicos", "Eletronicos legais");

            //            context.Categories.AddRange(category1, category2, category3);
            //            context.SaveChanges();
            //        }
            //    }

            //    using (var context = new IFSPStoreDbContext())
            //    {
            //        var categories = context.Categories.ToList();
            //        Assert.IsTrue(categories.Count > 0);
            //        foreach (var category in categories)
            //        {
            //            Console.WriteLine($"Id: {category.Id}, Nome: {category.Name}");
            //        }
            //    }
            //}

            //[TestMethod]
            //public void TesteProduct()
            //{
            //    var context = new IFSPStoreDbContext();
            //    var _categoryRepository = new BaseRepository<Category>(context);
            //    var _productRepository = new BaseRepository<Product>(context);

            //    var category1 = new Category();
            //    category1.Name = "Enlatados";
            //    category1.Description = "Produtos enlatados diversos";
            //    _categoryRepository.Insert(category1);

            //    var category2 = new Category();
            //    category2.Name = "Laticinios";
            //    category2.Description = "Produtos laticineos diversos";
            //    _categoryRepository.Insert(category2);

            //    var prod1 = new Product();
            //    prod1.Name = "Feijão";
            //    prod1.Value = 7.50m;
            //    prod1.PurchaseDate = DateTime.UtcNow.AddDays(-18);
            //    prod1.Quantity = 25;
            //    prod1.SaleUnity = "un";
            //    prod1.Group = category1;
            //    _productRepository.Insert(prod1);

            //    var prod2 = new Product();
            //    prod2.Name = "Leite UHT Integral";
            //    prod2.Value = 5.40m;
            //    prod2.PurchaseDate = DateTime.UtcNow.AddDays(-2);
            //    prod2.Quantity = 25;
            //    prod2.SaleUnity = "un";
            //    prod2.Group = category2;
            //    _productRepository.Insert(prod2);
            //}
        }
    }
}
