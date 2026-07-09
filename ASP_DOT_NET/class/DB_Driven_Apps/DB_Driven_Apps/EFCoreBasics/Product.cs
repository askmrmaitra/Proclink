using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBasics
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class ProductRepository
    {
        private readonly AppDbContext context = new AppDbContext();

        public void AddProduct()
        {
            Product product = new Product()
            {
                Name = "Samsung Monitor",
                Price = 250
            };

            context.Products.Add(product);
            
            context.SaveChanges();

            Console.WriteLine("Product Added Successfully.");
        }
        public void GetProducts()
        {
            var products = context.Products.ToList();

            Console.WriteLine("\nProduct List");
            Console.WriteLine("-------------------------");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductId}\t{product.Name}\t{product.Price}");
            }
        }
        public void FilterProducts()
        {
            var products = context.Products
                                  .Where(p => p.Price > 120)
                                  .ToList();

            Console.WriteLine("\nFiltered Products");
            Console.WriteLine("-------------------------");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductId}\t{product.Name}\t{product.Price}");
            }
        }
        public void SortProducts()
        {
            var products = context.Products
                                  .OrderByDescending(p => p.Price)
                                  .ToList();

            Console.WriteLine("\nSorted Products");
            Console.WriteLine("-------------------------");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductId}\t{product.Name}\t{product.Price}");
            }
        }
           
        public void Projection()
        {
            var products = context.Products
                                  .Select(p => new
                                  {
                                      p.Name,
                                      p.Price
                                  })
                                  .ToList();

            Console.WriteLine("\nProjection");
            Console.WriteLine("-------------------------");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}\t{product.Price}");
            }
        }
             
        public void AggregateFunctions()
        {
            Console.WriteLine("\nAggregate Functions");
            Console.WriteLine("-------------------------");

            Console.WriteLine($"Total Products : {context.Products.Count()}");
            Console.WriteLine($"Maximum Price  : {context.Products.Max(p => p.Price)}");
            Console.WriteLine($"Minimum Price  : {context.Products.Min(p => p.Price)}");
            Console.WriteLine($"Average Price  : {context.Products.Average(p => p.Price)}");
            Console.WriteLine($"Total Price    : {context.Products.Sum(p => p.Price)}");
        }
              
        public void UpdateProduct()
        {
            Product product = context.Products.Find(2);

            if (product != null)
            {
                product.Price = 950;

                context.SaveChanges();

                Console.WriteLine("\nProduct Updated Successfully.");
            }
        }
               
        public void DeleteProduct()
        {
            Product product = context.Products.Find(3);

            if (product != null)
            {
                context.Products.Remove(product);

                context.SaveChanges();

                Console.WriteLine("\nProduct Deleted Successfully.");
            }
        }
    }

}
