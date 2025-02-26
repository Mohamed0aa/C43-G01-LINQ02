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


            



        }
    }
}
