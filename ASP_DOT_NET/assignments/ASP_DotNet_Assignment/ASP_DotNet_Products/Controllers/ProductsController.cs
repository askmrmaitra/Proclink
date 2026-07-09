using ASP_DotNet_Products.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_DotNet_Products.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<ProductList> products = new List<ProductList>();
            
            ProductList product1 = new ProductList();
            product1.Product_Id = 1;
            product1.Product_name = "Apple";
            product1.Category = "Fruits";
            product1.Price = 100;
            product1.Stock_Quantity = 50;
            products.Add(product1);

            ProductList product2 = new ProductList();
            product2.Product_Id = 2;
            product2.Product_name = "Mango";
            product2.Category = "Fruits";
            product2.Price = 150;
            product2.Stock_Quantity = 1000;
            products.Add(product2);

            ProductList product3 = new ProductList();
            product3.Product_Id = 3;
            product3.Product_name = "Car";
            product3.Category = "Toys";
            product3.Price = 10000;
            product3.Stock_Quantity = 10;
            products.Add(product3);

            ProductList product4 = new ProductList();
            product4.Product_Id = 4;
            product4.Product_name = "Pipes";
            product4.Category = "Construction";
            product4.Price = 1000;
            product4.Stock_Quantity = 1050;
            products.Add(product4);

            ProductList product5 = new ProductList();
            product5.Product_Id = 5;
            product5.Product_name = "Switch";
            product5.Category = "Electricity";
            product5.Price = 90;
            product5.Stock_Quantity = 200;
            products.Add(product5);

            ProductList product6 = new ProductList();
            product6.Product_Id = 6;
            product6.Product_name = "AC";
            product6.Category = "HouseHolds";
            product6.Price = 35000;
            product6.Stock_Quantity = 70;
            products.Add(product6);

            return View(products);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
