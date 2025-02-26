using System.Text.RegularExpressions;
using static Assignment.ListGenerators;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 : Get first Product out of Stock 

            //var result=ProductList.First(x=>x.UnitsInStock==0);
            //Console.WriteLine(result);

            #endregion

            #region q2 : 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductList.FirstOrDefault(x => x.UnitsInStock > 1000, new Product {ProductName= "there is no match" });
            //Console.WriteLine(result.ProductName);

            //var result = ProductList.FirstOrDefault(x => x.UnitsInStock > 1000);
            //Console.WriteLine(result?.ProductName ?? "there is no match");
            #endregion

            #region q3 : 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(x =>x>5).ElementAt(1);
            //Console.WriteLine(result);

            #endregion

            #region q4 : 4. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result =Arr.Count(x=>x%2!=0);
            //Console.WriteLine(result);




            #endregion

            #region q5 : 5. Return a list of customers and how many orders each has
            ////fluent

            //var result = CustomerList.Select(x => new { x.CustomerName, Orders_Nums = x.Orders.Length });


            ////Query_Sentax

            //var result = from x in CustomerList
            //             select new { x.CustomerName, Orders_Nums = x.Orders.Length };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region q6 :  Return a list of categories and how many products each has

            //fluent 
            //var result = ProductList.GroupBy(x => x.Category).Select(y => new { cat_name = y.Key, product_num = y.Count() });

                        ////query Syntacx
                        //var result = from p in ProductList
                        //             group p by p.Category
                        //            into cat
                        //            select  $"{cat.Key} => {cat.Count()}" ;


                        ;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion

            #region q7 : Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            ////fluent 
            //var sum = Arr.Sum();


            //Console.WriteLine(sum);
            #endregion


            #region q8 : Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] names = File.ReadAllLines("dictionary_english.txt");


            //var result = names.Sum(n =>n.Count());

            //Console.WriteLine(result);

            #endregion


            #region q9 : Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] names = File.ReadAllLines("dictionary_english.txt");

            //var result = names.Min(n => n.Length);

            //Console.WriteLine(result);
            #endregion

            #region q10 : . Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] names = File.ReadAllLines("dictionary_english.txt");

            //var result = names.Max(n => n.Length);

            //Console.WriteLine(result);
            #endregion

            #region  q11 : Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] names = File.ReadAllLines("dictionary_english.txt");

            //var result = names.Average(n => n.Length);

            //Console.WriteLine(result);
            #endregion

            #region q12 : . Get the total units in stock for each product category.

            ////fluent
            //var result = ProductList.GroupBy(x => x.Category)
            //                .Select(y => new { Cat = y.Key, Total = y.Sum(cc => cc.UnitsInStock) });


            ////query_syntax
            //result = from p in ProductList
            //         group p by p.Category
            //        into y
            //         select new { Cat = y.Key, Total = y.Sum(cc => cc.UnitsInStock) };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region q13 : Get the cheapest price among each category's products

            //var result = ProductList.Min(x => x.UnitPrice);
            //Console.WriteLine(result);
            #endregion


            #region q14 : Get the products with the cheapest price in each category (Use Let)
            //var result = ProductList.GroupBy(p => p.Category)
            //                    .Select(p => new { Cat = p.Key, cheapest_product = p.Min(x => x.UnitPrice) });


            //result = from p in ProductList
            //         group p by p.Category into cc
            //         let c=cc
            //         select  new { Cat = c.Key, cheapest_product = c.Min(x => x.UnitPrice) };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion


            #region q15 : Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(p => p.Category)
            //                    .Select(p => new { Cat = p.Key, expensive_product = p.Max(x => x.UnitPrice) });


            //result = from p in ProductList
            //         group p by p.Category into cc
            //         let c=cc
            //         select  new { Cat = c.Key, expensive_product = c.Max(x => x.UnitPrice) };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion


            #region q16 : Get the products with the most expensive price in each category
            //var result = ProductList.GroupBy(p => p.Category)
            //                    .Select(p => new { Cat = p.Key, expensive_product = p.MaxBy(x => x.UnitPrice) });


            //result = from p in ProductList
            //         group p by p.Category into cc
            //         let c=cc
            //         select  new { Cat = c.Key, expensive_product = c.MaxBy(x => x.UnitPrice) };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion


            










        }
    }
}
