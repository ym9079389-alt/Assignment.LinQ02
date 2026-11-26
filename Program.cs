
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
        }
    }
}
