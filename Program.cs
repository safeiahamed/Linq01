using LINQ.DataSources;
using System.Linq;
namespace LINQ_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //var result = Source.ProductList.Where(p => p.Category == "Seafood")
            //             .Select(p => new {p.ProductName,p.UnitPrice});

            #endregion

            #region Q2

            //var result = Source.ProductList.Select(p => p.ProductName);

            #endregion

            #region Q3

            //var result = Source.ProductList.OrderBy(p=>p.UnitPrice)
            //     .Select(p => new { p.ProductName , p.UnitPrice});

            #endregion

            #region Q4

            //var result = Source.ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);

            #endregion

            #region Q5

            //var result = Source.ProductList.Where(p => p.UnitsInStock>0&& p.Category== "Spices & Condiments");
            #endregion

            #region Q6

            //var result = Source.ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            #endregion

            #region Q7

            //var result = Source.ProductList.Select((p, I) => $"{I + 1}. {p.ProductName}");

            #endregion

            #region Q8

            //var result = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            #endregion

            #region Q9

            //var result = Source.ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock)
            //    .Select(p => new { p.ProductName, p.UnitsInStock });

            #endregion

            #region Q10

            //var result = from c in Source.CustomerList
            //             from o in c.Orders
            //             where o.OrderDate >= new DateTime(1997,1,1)
            //             select new
            //             {
            //                 c.CustomerID,
            //                 o.OrderDate
            //             };

            #endregion

            #region Q11

            //var result = Source.ProductList.Select((p, I) => new { position = I + 1, p.ProductName });

            #endregion

            #region Q12

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(word => word.Length).ThenBy(word => word.ToLower());

            #endregion

            #region Q13

            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var result = Arr.Where(word => word.Length > 1 && char.ToLower(word[1]) == 'i').Reverse();

            #endregion

            #region Session search
            //var result = Source.ProductList.Select((p, I) => $"{I + 1}. {p.ProductName}");
            #endregion

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
