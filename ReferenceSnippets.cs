using System;

namespace Yakky.AnotherSnippet.Better
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public bool Active { get; set; }
    }

    public class Process
    {
        public int DoSomething(Product product)
        {
            product.Sku = "test";
            return 0;
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
            Console.Write(DoSomething(product));
            Console.Write(product.Sku);
        }
    }
}