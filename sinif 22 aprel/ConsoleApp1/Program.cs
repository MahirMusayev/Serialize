using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Category category = new Category { Name = "Mahir" };
            //Product product = new Product { Id = 1, Name = "IPhone", Price = 2000, Category = category };
            //Product product1 = new Product { Id = 2, Name = "Samsung", Price = 1000, Category = category };
            //Product product2 = new Product { Id = 3, Name = "Xiami 15", Price = 200, Category = category };

            //List<Product> products = new List<Product> { product, product1, product2 };
            //string json = JsonConvert.SerializeObject(products);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\Heydar\Desktop\ConsoleApp1\ConsoleApp1\Products.json"))
            //{
            //    sw.Write(json);
            //}


            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\Heydar\Desktop\ConsoleApp1\ConsoleApp1\Products.json"))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine(result);




        }
    }
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
    internal class Category
    {
        public string Name { get; set; }
    }
}
