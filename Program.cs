using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace week15Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 6 
            string user;
            Console.WriteLine("Input a string to count amount of times each character appears");
            user = Console.ReadLine();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in user)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }

                else
                {
                    counts.Add(c, 1);
                }
            }

            foreach (var kvp in counts)
            {
                Console.WriteLine(kvp.Key + "--" + kvp.Value);
            }
            Console.WriteLine();

            //------------------------------------------------------------//



            //exercise 7
            string sentence;
            Console.WriteLine("Input a sentence");
            sentence = Console.ReadLine();

            var listWords = sentence.Split(new char[] { ' ', '.', ',', '!' });

            Dictionary<string, int> track = new Dictionary<string, int>();

            foreach (var word in listWords)
            {
                if (track.ContainsKey(word))
                {
                    track[word]++;
                }
                else if (word != string.Empty)
                {
                    track.Add(word, 1);
                }
                foreach (var kvp in counts)
                {
                    Console.WriteLine(kvp.Key + "==" + kvp.Value);
                }
                Console.WriteLine();

            }

            //------------------------------------------------------------//


            //exercise 8 

            var product = new Product(1, "product 1", 2.99, 10);
            products.Add(1, Product);

            var cart = new ShoppingCart();

            cart.AddProduct(1);
            cart.AddProuct(2);
            cart.DisplayCart();

            Console.WriteLine(cart.CalPrice());


            foreach (var item in product)
            {
                Console.WriteLine(item.Key + ":" +  item.Value.Stock);
            }

        }//static void main


        static Dictionary<int, Product> products = new Dictionary<int, Product>();
        static ShoppingCart cart = new ShoppingCart();

        class ShoppingCart
        {
            public List<int> productList { get; set; }

            public ShoppingCart()
            {
                productList = new List<int>();
            }

            void AddProduct(int anId)
            {
                productList.Add(anId);
            }

            public double CalPrice()
            {
                double sum = 0;

                foreach (var id in productList)
                {
                    sum += products[id].Price;
                }
                return sum;
            }
            public void DisplayCart()
            {
                foreach(var id in productList)
                {

                }

            }
            class Product
            {
                public int Id { get; set; }

                public string Name { get; set; }

                public double Price { get; set; }

                public int Stock { get; set; }

                public Product(int Id, string Name, double Price, int Stock)
                {
                    this.Id = Id;
                    this.Name = Name;
                    this.Price = Price;
                    this.Stock = Stock;
                }

                public void Display()
                {
                    Console.WriteLine($"{this.Id} -- {this.Name} -- {this.Price} -- {this.Stock}");
                }
            }
        }//shopping cart

        

    }//internal class

    

}//namespace
