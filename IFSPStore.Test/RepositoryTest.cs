﻿using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using System.Security.Cryptography.X509Certificates;
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

            var category1 = new Category(1, "Carnes", "Comida");
            var category2 = new Category(2, "Bebidas", "Bebida");
            var category3 = new Category(3, "Doces", "Comida");

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

   
    [TestMethod]
    public void TestProduct()
    {
        var context = new IFSPStoreContext();   
        var _categoryRepository = new BaseRepository<Category>(context);
        var _productRepository = new BaseRepository<Product>(context);

        var category1 = new Category();
        category1.Name = "Enlatados";
        _categoryRepository.Insert(category1);
        var category2 = new Category();
        category2.Name = "saudáveis";
        _categoryRepository.Insert(category2);

        var prod1 = new Product();
        prod1.Name = "Sardinha";
        prod1.Price = 10.55M;
        prod1.Quantity = 55;
        prod1.PurchaseDate = DateTime.Now;
        prod1.Category = category1;
        _productRepository.Insert(prod1);
        var prod2 = new Product();
        prod2.Name = "whey protein";
        prod2.Price = 155.55M;
        prod2.Quantity = 61;
        prod2.PurchaseDate = DateTime.Now;
        prod2.Category = category2;
        _productRepository.Insert(prod2);
        




    }
}