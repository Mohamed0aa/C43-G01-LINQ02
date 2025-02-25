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
        }
    }
}
