using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using System.Xml.Linq;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Linq
            //Linq=>language integrated query
            // SQl=>DQL , C#=>functions
            //LINQ Method +40 Method
            //Extension Method For All Collection That Implement Interface "IEnumerable"
            //Named As LINQ Operators Existed at Class enumerable
            //Categorized Into 13 Category
            //You Can Use "LINq Operators" Against The
            //Data[Stored In Sequence] Regardless Data Store[Sql Server, MySql, Oracle]
            //Sequence
            //The Object From Class That Implement Interface "IEnumerable"
            //1.Local { Static , XML Data } :  L to Object , L to XML
            //2.Remote : L to EF =>entity framwork
            #endregion
            #region Local Sequence
            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //List<int> OddNumbers = list.Where(x => x % 2 == 1).ToList();
            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Linq Syntax 
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            #region Fluent Syntax
            //Fluent Syntax
            //Call "Linq Operators"As static Method
            //var Result = Enumerable.Where(list, x => x % 2 == 1);//بتكلم الليست عن طريق Enumerable

            //Call "Linq Operators"As Extention  Method 
            // var Result = list.Where(x => x % 2 == 1);//بتكلم الليست علطول
            #endregion
            #region Query Syntax
            //var Result = from n in list where n % 2 == 1 select n;
            #endregion
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Linq Execution
            //Deferred Execution [Last Version of data]
            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //var result = list.Where(x => x % 2 == 1);
            //list.AddRange(new int[] { 11, 12, 13, 14, 15 });//last version of list
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);//1,3,5,7,9,11,13,15
            //}

            //Immediate Execution (Elements Operators, Casting Operators, Aggregate Operators)
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = list.Where(x => x % 2 == 1).ToList();
            //list.AddRange(new int[] { 11, 12, 13, 14, 15 });//last version of list
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);//1,3,5,7,9
            //}
            #endregion
            #region Data Setup
            //var result = ProductsList;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Linq Operators
            #region Filtration [Restrication] Operators - Where 
            #region Get Elements Out Of Stock
            //Fluent Syntax
            //var result = ProductsList.Where(p => p.UnitsInStock == 0);
            //Query Syntax
            //var result = from p in ProductsList where p.UnitsInStock == 0 select p;
            #endregion
            #region Get Elements In Stock And In Category Of Meat/Poultry
            //Fluent Syntax
            //var result = ProductsList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry");
            //Query Syntax
            //var result = from p in ProductsList
            //             where p.UnitsInStock > 0 & p.Category == "Meat/Poultry"
            //             select p;
            #endregion
            #region Get Elements   Out Of Stock But In 10 Elements
            //Fluent Syntax
            //var result = ProductsList.Where((p,i) => p.UnitsInStock ==0  && i<10);
            //Serach in first 10 Elements
            //Indexed where Valid Only With Fluent Syntax
            //Query Syntax
            //can not used Indexed where In Query Syntax
            //var result = from p in ProductsList
            //             where p.UnitsInStock == 0 &&p. invalid
            //             select p;
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Transformation [Projection] Operators [Select , Select Many]
            #region Select Product Name
            //Fluent Syntax
            //var result = ProductsList.Select(p => p.ProductName);

            //Query Syntax
            //var result =from p in ProductsList select p.ProductName;
            #endregion
            #region Select Customer Name
            //Fluent Syntax
            //var result = CustomersList.Select(p => p.CustomerName);

            //Query Syntax
            //var result =from p in CustomersList select p.CustomerName;
            #endregion
            #region Select Customer Orders
            //Fluent Syntax
            //var result = CustomersList.SelectMany(p => p.Orders);

            //Query Syntax
            //var result =from p in CustomersList from c in p.Orders select c;
            #endregion
            #region Select Product Id and Product Name
            //Fluent Syntax
            //var result = ProductsList.Select(p => new { ProductID = p.ProductID, ProductName = p.ProductName });
            //CLR will create the class in run time and override to string

            //Query Syntax
            //var result = from p in ProductsList select new { p.ProductID, p.ProductName };
            #endregion
            #region Select Product In Stock And Apply Discount 10 % On Its Price
            //Fluent Syntax
            //var result = ProductsList.Where(p=>p.UnitsInStock>0).Select(p => new {Id=p.ProductID,Name=p.ProductName ,OldPrice =p.UnitPrice , NewPrice=p.UnitPrice-(p.UnitPrice*0.1m) } );

            //Query Syntax
            //var result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             select new
            //             {
            //                 Id = p.ProductID,
            //                 Name = p.ProductName,
            //                 OldPrice = p.UnitPrice,
            //                 NewPrice = p.UnitPrice - (p.UnitPrice * 0.1m)
            //             };
            #endregion
            #region Indexed Select 
            //var result = ProductsList.Where(p => p.UnitsInStock > 0)
            //    .Select((p, i) => new { Index = i, name = p.ProductName });
            //valid only with fluent syntax
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]
            #region Get Products Ordered By Price Asc
            //Fluent Syntax
            //var result = ProductsList.OrderBy(p => p.UnitPrice);

            //Query Syntax
            //var result = from p in ProductsList orderby p.UnitPrice select p;
            #endregion
            #region Get Products Ordered By Price Desc
            //Fluent Syntax
            //var result = ProductsList.OrderByDescending(p => p.UnitPrice);

            //Query Syntax
            //var result = from p in ProductsList orderby p.UnitPrice descending select p;
            #endregion
            #region Get Products Ordered By Price Asc and Number Of Items In Stock
            //Fluent Syntax
            //var result = ProductsList.OrderBy(p => p.UnitPrice).ThenBy(p=>p.UnitsInStock>0);

            //Query Syntax
            //var result = from p in ProductsList orderby p.UnitPrice, p.UnitsInStock > 0 select p;
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Elements Operator - Immediate Execution [Valid Only With Fluent Syntax]
            //First , Last , LastOrDefault , FirstOrDefault , ElementAt , ElementAtOrDefault , Single , SingleOrDefault

            //var result =ProductsList.First();
            //Console.WriteLine(result);

            //var result = ProductsList.LastOrDefault();
            //Console.WriteLine(result?.ProductName??"Not Found");

            //var result = ProductsList.ElementAt(888); //Exeption
            //Console.WriteLine(result?.ProductName ?? "Not Found");

            //var result = ProductsList.ElementAtOrDefault(888);
            //Console.WriteLine(result?.ProductName ?? "Not Found");

            //var result = ProductsList.Single(p=>p.UnitsInStock==0);
            //if sequence contain only one element match the condition=> return it
            //else will throw exeption (sequence is empty or sequence contain more than one element match the condition)
            //Console.WriteLine(result);
            
            //var result = ProductsList.SingleOrDefault();
            //Console.WriteLine(result?.ProductName ?? "Not Found");
            #endregion
            #endregion
        }
    }
}
