using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
namespace WebServer.Models
{
    public class Repository
    {
        private static int counter;
        public static IList<Product> Products { get; } = new List<Product>();


        public static Product GetProductByID(int id)
        {
            var target = Products.SingleOrDefault(p => p.ID == id);
            return target;
        }


        public static IList<Product> GetProductByPrice(int firstPrice, int secondPrice)
        {
            var filteredProducts = Products.Where(p => (p.Price >= firstPrice) && (p.Price <= secondPrice)).ToList();
            return filteredProducts;
        }

        public static void RemovePersonByID(int id)
        {
            var target = Products.SingleOrDefault(p => p.ID == id);
            if (target != null)
            {
                Products.Remove(target);
            }
        }

        public static void ReplaceProductById(int id, Product product)
        {
            var target = Products.SingleOrDefault(p => p.ID == id);
            if (target != null)
            {
                Products.Remove(target);
                Products.Add(product);
            }
        }

        public static void ReplaceProductsPrice(int replaceValue)
        {
            foreach (var product in Products)
            {
                product.Price = product.Price + replaceValue;
            }
        }

        public static void AddProduct(Product product)
        {
            {
                product.ID = counter++;
                Products.Add(product);
            }
        }
    }
}
