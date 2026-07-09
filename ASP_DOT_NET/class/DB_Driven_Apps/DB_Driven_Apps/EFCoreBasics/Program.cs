namespace EFCoreBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //SaveProduct();

            ProductRepository repository = new ProductRepository();

            repository.AddProduct();

            repository.GetProducts();

            repository.FilterProducts();

            repository.SortProducts();

            repository.Projection();

            repository.AggregateFunctions();

            //repository.UpdateProduct();

            repository.DeleteProduct();

            Console.Write("Data Saved...");
            Console.ReadKey();

        }
        public static void SaveProduct()
        {
            using (var dbContext = new AppDbContext())
            {
                var newProduct = new Product { Name = "iPhone 17", Price = 800 };
                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();
            }
        }
    }
}
