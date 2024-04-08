namespace DateTimeTimeSpanSvar
{
    internal class Program
    {
        
            public static void Main()
            {
                Console.WriteLine("DateTime & TimeSpan: Svar till uppgifter:");
                Console.WriteLine("Uppgift 1: " + Uppgift1());
                Console.WriteLine("Uppgift 2: " + Uppgift2());
                Console.WriteLine("Uppgift 3: " + Uppgift3());
                Console.WriteLine("Uppgift 4: " + Uppgift4());
                Console.WriteLine("Uppgift 5: " + Uppgift5());
                Console.WriteLine("Uppgift 6: " + Uppgift6());
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
            DateTime dt1 = new DateTime(2006, 05, 06);
            DateTime dt2 = DateTime.Now;
            TimeSpan ts = dt2 - dt1;
            return ts.ToString();
            }
            public static string Uppgift3()
            {
            DateTime dt1 = new DateTime(2006, 05, 06);
            DateTime dt2 = DateTime.Now;
            TimeSpan ts = (dt2 - dt1) * 2;
            return ts.ToString();
            }
            public static string Uppgift4()
            {
            DateTime dt1 = new DateTime(2022, 03, 26, 12, 00, 00);
            DateTime dt2 = new DateTime(2022, 03, 27, 12, 00, 00);
            TimeSpan ts = (dt2 - dt1);
            return ts.TotalHours.ToString();
            }
            public static string Uppgift5()
            {
            DateTime dt1 = new DateTime(2023, 01, 01);
            DateTime dt2 = new DateTime(2024, 01, 01);
            TimeSpan ts = (dt2 - dt1);

            DateTime dt3 = new DateTime(2024, 01, 01);
            DateTime dt4 = new DateTime(2025, 01, 01);
            TimeSpan ts2 = (dt4 - dt3);
            return ts.ToString() + " " + ts2.ToString();
            }
            public static string Uppgift6()
            {
            DateTime dt1 = new DateTime(2015, 07, 01, 01, 59, 30);
            DateTime dt2 = new DateTime(2015, 07, 01, 02, 00, 30);
            TimeSpan ts = (dt2 - dt1);
            return ts.TotalSeconds.ToString();
            }
    }
}