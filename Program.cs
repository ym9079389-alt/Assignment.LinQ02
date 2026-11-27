
namespace Assignment.LinQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //var Result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q02
            //var Result = Source.ProductList.Skip(5).Take(5);

            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q03
            //var Result = Source.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(P => P.UnitPrice < 25);

            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q04
            //var Result = Source.ProductList.Where(P => P.Category == "Seafood").All(P => P.UnitsInStock > 0);

            //Console.WriteLine(Result);
            #endregion

            #region Q05
            //int[] ids = { 3, 9, 13, 18 };
            //var Result = ids.Contains(9);
            //Console.WriteLine(Result);
            #endregion

            #region Q06
            //var Result = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var r in Result)
            //    Console.WriteLine($"{r.Key}: {r.Count()}");
            #endregion

            #region Q07
            //var Result = Source.ProductList.GroupBy(p => p.Category)
            //                               .Select(g => new
            //                               {
            //                                   Category = g.Key,
            //                                   Names = g.Select(p => p.ProductName)
            //                               });
            //foreach (var r in Result)
            //    Console.WriteLine($"{r.Category} : {string.Join(", ", r.Names)}");
            #endregion

            #region Q08
            //var Result = Source.ProductList.GroupBy(p => p.Category).Where(s => s.Count() > 3).Select(g => new
            //{
            //    Category = g.Key,
            //    Count = g.Count()
            //});

            //foreach (var r in Result)
            //    Console.WriteLine($"{r.Category} : {r.Count}");
            #endregion

            #region Q09
            //var Result = from C in Source.CustomerList
            //             group C by C.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };

            //foreach (var r in Result)
            //    Console.WriteLine($"{r.Country} : {r.Count}");
            #endregion

            #region Q10
            //var Result = Source.ProductList.Sum(P => P.UnitsInStock);
            //Console.WriteLine(Result);
            #endregion

            #region Q11
            //var Min = Source.ProductList.OrderBy(P => P.UnitPrice).First();
            //var Max = Source.ProductList.OrderByDescending(P => P.UnitPrice).First();

            //var Min = Source.ProductList.Min(P => P.UnitPrice);
            //var Max = Source.ProductList.Max(P => P.UnitPrice);
            //Console.WriteLine(Min);
            //Console.WriteLine(Max);
            #endregion

            #region Q12
            //var Result = Source.ProductList.DistinctBy(P => P.Category);
            //foreach (var r in Result)
            //    Console.WriteLine(r);
            #endregion

            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var Result = setA.Except(setB);
            //foreach (var r in Result)
            //    Console.WriteLine(r);
            #endregion

            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var Result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var r in Result)
            //    Console.WriteLine(r);
            #endregion

            #region Q15
            //var dict = Source.ProductList.ToDictionary(p => p.ProductID);
            //Console.WriteLine(dict[18]);
            #endregion

            #region Q16
            //var Result = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 18);
            //Console.WriteLine(Result);
            #endregion

            #region Q17
            //var Result = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(Result == null ? "No product found" : Result.ToString());
            #endregion

            #region Q18
            //var row = Enumerable.Range(1, 12).Select(i => 7 * i);
            //foreach (var r in row)
            //    Console.WriteLine(r);
            #endregion
        }
    }
}
