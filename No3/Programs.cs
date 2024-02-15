internal class Program
{
  record RecCust(int ID, string Customer_ID, DateTime Transaction_Date);

  static void Main()
  {
    Console.WriteLine("Soal no. 3:");
    Console.WriteLine();

    List<RecCust> Tbl_Cust = [
      new (1, "21", new DateTime(2019, 7, 30)),
      new (2, "15", new DateTime(2019, 7, 21)),
      new (3, "16", new DateTime(2019, 7, 18)),
      new (4, "20", new DateTime(2019, 7, 22)),
      new (5, "15", new DateTime(2019, 7, 15)),
      new (6, "20", new DateTime(2019, 7, 12)),
      new (7, "15", new DateTime(2019, 7, 21)),
      new (8, "20", new DateTime(2019, 7, 12))
    ];

    var r = (from a in Tbl_Cust
             group (a.Customer_ID) by (a.Customer_ID) into g
             select new { CustID = g.Key, Total = g.Count() }
            ).OrderBy(y => y.CustID).OrderByDescending(x => x.Total);

    foreach (var result in r)
    {
      Console.WriteLine($"Customer_ID: {result.CustID}, Total Penjualan: {result.Total}");
    }
  }
}