

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Lessons6_magazine
{
    internal class Inventorycs
    {
        internal List<Product> products;

        public void AddProduct(Product product)
        {
            products.Add(product);

        }
        public void PrintAllProduct()
        {

            foreach (Product product in products)
            {
                Food? food = product as Food;
                Chemical? chemical = product as Chemical;
                Machinery? machinery = product as Machinery;
                Console.WriteLine("______________");
                Console.WriteLine(product._name);
                Console.WriteLine(product._price);
                Console.WriteLine(product._quantity);
                if (food == product)
                {
                    Console.WriteLine(food._bestBeforeDate);
                }
                else if (chemical == product)
                {
                    Console.WriteLine(chemical._Harmfulincontactwithskin);
                }
                else if (machinery == product)
                {
                    Console.WriteLine(machinery._forHome);
                }
            }

        }

        public List<T> SortByType<T>() where T : Product
        {
            var resultSortedList = new List<T>();
            string? productType = "";

            foreach (var product in products)
            {
                var castedProduct = product as T;
                if (castedProduct != null)
                    resultSortedList.Add(castedProduct);


            }

            foreach (var product in resultSortedList) 
            {

                Food? food = product as Food;
                Chemical? chemical = product as Chemical;
                Machinery? machinery = product as Machinery;
                if (food == product)
                {
                    productType = "Sort By Food:";
                }
                else if (chemical == product)
                {
                    productType = "Sort By Chemical:";
                }
                else if (machinery == product)
                {
                    productType = "Sort By Machinery:";
                }
            }
            Console.WriteLine("_______________________________");
            Console.WriteLine(productType); 
            foreach (var product in resultSortedList)
            {
                Food? food = product as Food;
                Chemical? chemical = product as Chemical;
                Machinery? machinery = product as Machinery;
                Console.WriteLine("______________");

                Console.WriteLine(product._name);
                Console.WriteLine(product._price);
                Console.WriteLine(product._quantity);
                if (food == product)
                {
                    Console.WriteLine(food._bestBeforeDate);
                }
                else if (chemical == product)
                {
                    Console.WriteLine(chemical._Harmfulincontactwithskin);
                }
                else if (machinery == product)
                {
                    Console.WriteLine(machinery._forHome);
                }
            }
            return resultSortedList;
        }
        public void SumInventorycsAll()
        {
            decimal? sum = 0;
            foreach (var product in products)
            {

                sum += product._price;
            }
            Console.WriteLine("_______________________________");
            Console.WriteLine($"Sum All Inventorycs: {sum}");
        }
        public List<T> SumByType<T>() where T : Product
        {
            var resultSortedList = new List<T>();
            decimal sum = 0;
            string? productType = "";
            foreach (var product in products)
            {
                var castedProduct = product as T;
                if (castedProduct != null)
                    resultSortedList.Add(castedProduct);

            }
            foreach (var product in resultSortedList) 
            {
                Food? food = product as Food;
                Chemical? chemical = product as Chemical;
                Machinery? machinery = product as Machinery;
                if (food == product)
                {
                    productType = "SUM By Food: ";
                }
                else if (chemical == product)
                {
                    productType = "SUM By Chemical: ";
                }
                else if (machinery == product)
                {
                    productType = "SUM By Machinery: ";
                }
            }
            foreach (var product in resultSortedList)
            {
                sum += product._price;
            }
            Console.WriteLine("______________");
            Console.WriteLine(productType + sum); 
            return resultSortedList;
        }
    }


}

