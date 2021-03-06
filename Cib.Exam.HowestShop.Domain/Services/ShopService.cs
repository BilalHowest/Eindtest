﻿
using System.Collections.Generic;
using Cib.Exam.HowestShop.Domain.Entities;

namespace Cib.Exam.HowestShop.Domain.Services
{
    public class ShopService
    {
        public static decimal MaximumPriceOfProduct = 5000M;
        public static string AllFieldsAreRequiredMessage = "All fields are required!";
        public static string NoProductSelectedToDeleteMessage = "No product is selected!";
        public static string NewProductPriceIsWrongMessage = $"Price is zero, less than zero, more than {MaximumPriceOfProduct} or not a number!";

        public List<Product> ProductsInShop { get; private set; }
        public List<Category> CategoriesInShop { get; private set; }

        public ShopService()
        {
            CreateCategoriesOnStartUp();
            CreateProductsOnStartUp();
        }

        public void AddNewProduct(string name, Category category, string price)
        { // ENKEL BINNEN DE ACCOLADES VAN DEZE METHODE MOGEN AANPASSINGEN GEBEUREN

            decimal.TryParse(price, out decimal convertedPrice);

            Product newProduct = new Product(name, category, convertedPrice);
            ProductsInShop.Add(newProduct);
        }

        public void DeleteProduct(Product productToDelete)
        {// ENKEL BINNEN DE ACCOLADES VAN DEZE METHODE MOGEN AANPASSINGEN GEBEUREN
            ProductsInShop.Remove(productToDelete);
        }

        // NIKS WIJZIGEN AAN OF IN DEZE METHODE
        private void CreateProductsOnStartUp()
        {
            ProductsInShop = new List<Product>();

            // Category desktops
            ProductsInShop.Add(new Product("Dell OptiPlex", CategoriesInShop[0], 799.99M));
            ProductsInShop.Add(new Product("Lenovo ThinkCentre", CategoriesInShop[0], 599.99M));

            // Category schermen
            ProductsInShop.Add(new Product("Dell Ultrasharp", CategoriesInShop[1], 238.95M));
            ProductsInShop.Add(new Product("AOC 24B1H", CategoriesInShop[1], 99.99M));

            // Category toetsenborden
            ProductsInShop.Add(new Product("Logitech MK540", CategoriesInShop[2], 59.00M));
            ProductsInShop.Add(new Product("Apple Keyboard", CategoriesInShop[2], 119.00M));

            // Category laptops
            ProductsInShop.Add(new Product("Surface Book 2", CategoriesInShop[3], 3299.00M));
            ProductsInShop.Add(new Product("Lenovo Ideapad", CategoriesInShop[3], 699.00M));
        }


        // NIKS WIJZIGEN AAN OF IN DEZE METHODE
        private void CreateCategoriesOnStartUp()
        {
            CategoriesInShop = new List<Category>();
            CategoriesInShop.Add(new Category("Desktops"));
            CategoriesInShop.Add(new Category("Schermen"));
            CategoriesInShop.Add(new Category("Toetsenbord"));
            CategoriesInShop.Add(new Category("Laptops 15\""));
        }
    }
}
