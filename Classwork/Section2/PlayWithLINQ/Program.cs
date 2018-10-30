//
//   Using LINQ
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithLINQ
{
    class Program
    {
        static void Main( string[] args )
        {
            var products = GetProducts();

            //Get discounted products
            //var discounted = products.Where(IsDiscounted);
            var discounted = products.Where( p => p.IsDiscounted);   // Lamdas syntax for expression

            var expensive = products.FirstOrDefault(p => p.Price > 100);        // expression

            // Demoing statment lambda rather than expression lambda
            var discountedExpensive = products.Where(p => {         
                return p.IsDiscounted && p.Price > 100;
            });

            // you cannot return a aynomous or have as parameters (only can be used in current method)
            var subsetProducts = products.Select(p => new { Name = p.Name, Price = p.Price});        // new aynomous type get data to point a to point b
                                                                                                     // useful for temp value
            var expensiveSubset = subsetProducts.Where(p => p.Price > 100);
        }

        //static bool IsDiscounted( Product product )
        //{
        //    return product.IsDiscounted;
        //}

        static IEnumerable<Product> GetProducts()
        {
            return new[] {
                new Product() { Name = "Product A", Price = 50, IsDiscounted = false },
                new Product() { Name = "Product B", Price = 150, IsDiscounted = true },
                new Product() { Name = "Product C", Price = 200, IsDiscounted = false },
                new Product() { Name = "Product D", Price = 75, IsDiscounted = true },
                new Product() { Name = "Product E", Price = 25, IsDiscounted = false },
                new Product() { Name = "Product F", Price = 150, IsDiscounted = true },
                new Product() { Name = "Product G", Price = 175, IsDiscounted = false },
                new Product() { Name = "Product H", Price = 125, IsDiscounted = true },
            };
        }
    }

    class Product
    {
        public string Name { get; set; }
        public bool IsDiscounted { get; set; }
        public decimal Price { get; set; }
    }
}
