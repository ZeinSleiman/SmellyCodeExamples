using System;

namespace Yakky.ReferenceSnippet
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public bool Active { get; set; }
    }

    public class Process
    {
        public bool ValidateProduct(Product product)
        {
            product.Sku = "test";
            return true;
        }

        public void Main()
        {
            var product = new Product
            {
                ProductId = 1,
                Sku = "Blah",
                Active = true
            };

            Console.Write(product.Sku);
            Console.Write(ValidateProduct(product));
            Console.Write(product.Sku);
        }
    }
}