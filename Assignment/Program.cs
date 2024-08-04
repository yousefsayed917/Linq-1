using System.ComponentModel;
using System.Threading;
using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            //Q1 Find all products that are out of stock.
            //var result = ProductsList.Where(p => p.UnitsInStock == 0);

            //Q2 Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #region Q3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Select((p, i) => new { Name = p, Value = i })
            //.Where(p => p.Name.Length < p.Value);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ - Element Operators
            #region Q1
            //Get first Product out of Stock 
            //var result = ProductsList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);
            #endregion
            #region Q2
            //Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductsList.FirstOrDefault(p => p.UnitPrice >1000.00m);
            //Console.WriteLine(result?.ProductName??"Not Found");
            #endregion=
            #region Q3
            //Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(p => p > 5).Order().ElementAtOrDefault(1) ;
            //Console.WriteLine(result);
            #endregion
            #endregion
            #region LINQ - Ordering Operators
            #region Q1
            //Sort a list of products by name
            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(p => p, StringComparer.Ordinal);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //Sort a list of products by units in stock from highest to lowest.
            //var result = ProductsList.OrderByDescending(p=>p.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(p => p.Length).ThenBy(p => p);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q5
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.Select(p => new { Name = p }).OrderBy(p => p.Name.Length).ThenBy(p => StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q6
            //var result = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.Select(p => new { Name = p }).OrderBy(p => p.Name.Length).ThenByDescending(p =>StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(p => p[1] == 'i').Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ – Transformation Operators
            #region Q1
            //var result = ProductsList.Select(p => new { ProductName = p.ProductName });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(p => new { Uppercase = p.ToUpper(), Lowercase = p.ToLower()}).SelectMany(p => new []{ p.Uppercase, p.Lowercase });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //var result = ProductsList.Select(p => new { p.ProductID, p.ProductName, Price = p.UnitPrice });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((value,index) =>new { Value = value, Index = index});
            //foreach (var item in result)
            //{
            //    if (item.Value == item.Index)
            //        Console.WriteLine($"{item.Value}  true");

            //    else
            //        Console.WriteLine($"{item.Value}  false");
            //}
            #endregion
            #region Q5
            //int[] Arr1 = { 0,2,4,5,6,8,9 };
            //int[] Arr2 = { 1,3,5,7,8 };
            //var result1 = Arr1.Select(p=>p);
            //var result2 = Arr2.Select(p=>p);
            //foreach (var i in result2)
            //{
            //    foreach (var j in result2)
            //    {
            //        if (i < j)
            //            Console.WriteLine($"{i} is less than {j}");
            //    }
            //}
            #endregion
            #region Q6
            //var result = CustomersList.SelectMany(p => p.Orders).Where(p => p.Total < 500.0m);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q7
            //var result = CustomersList.SelectMany(p => p.Orders).Where(p => p.OrderDate <=new DateTime(1998,1,1));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

        }
    }
}
