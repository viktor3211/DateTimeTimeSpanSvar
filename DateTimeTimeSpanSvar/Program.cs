namespace DateTimeTimeSpanSvar
{
    internal class Program
    {
        
            public static void Main()
            {
                Console.WriteLine("DateTime & TimeSpan: Svar till uppgifter:");
                Console.WriteLine("Uppgift 1: " + Uppgift1());
                Console.WriteLine("Uppgift 2: " + Uppgift2());
                // TODO uppg 3, 4 osv.
            }

            public static string Uppgift1()
            {
            DateTime dt1 = new DateTime(2009, 12, 18);
            DateTime dt2 = new DateTime(2022, 12, 14);
            TimeSpan ts = dt2 - dt1;
            return ts.ToString();
            }

            public static string Uppgift2()
            {
                return "123"; // TODO
            }


        
    }
}