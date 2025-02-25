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

            #region q4 : 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result =Arr.Count(x=>x%2!=0);
            //Console.WriteLine(result);


            #endregion



        }
    }
}
