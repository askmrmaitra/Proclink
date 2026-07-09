namespace EF_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (var dbContext = new AppDbContext())
            {
                var newProduct = new Product { Name = "Samsung", Price = 1000 };
                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();
            }

        }
    }
}
