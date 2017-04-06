using System;

namespace Yakky.ReferenceSnippet.Better
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public bool Active { get; set; }
    }

    public class Process
    {
        /* This function takes an object of type Product and 
        try to validate it. 
         */
        public bool ValidateProduct(Product product)
        {
            /*Before It validates the product, it changed 
            the value of the SKU. What is the problem with this?
             */
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

            /* The problem is here. You initialized Sku as Blah
            You print Sku and it is test. Unexpected result which means
            unexpected behaviour. The function is not pure. 
            All your function has to do what they are supposed to do
            without any side effects. 
            It is easier to test. It is easier to discover bugs and maintain.
             */
            Console.Write(product.Sku);
        }
    }
}