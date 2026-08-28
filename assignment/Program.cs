using System.Text;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // question01

            // double[] prices = { 25.5, 40.0, 33.75 };
            // Console.WriteLine(prices[1]);
            //==============================================================//

            //question02
            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);
            //======================================================================//
            //question03
            //static void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");
            //}

            //{
            //    PrintWelcomeMessage();
            //}
            //==========================================================================//
            //question04
            //static void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("Book title: " + title);
            //}
            //PrintBookTitle("Clean Code");
            //=====================================================================//
            //question05
            //static void AddBonusPages(int pages)
            //{
            //    pages = pages + 50;
            //}
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages); 
            //=======================================================================//
            //question06
            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] = prices[0] - 5;
            //}

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            //============================================================================//
            //question07
            //static void AddBonusPagesByRef(ref int pages)
            //{
            //    pages = pages + 50;
            //}
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            //==============================================================================//
            //question08
            //static void ReplaceArray(ref double[] prices)
            //{
            //    prices = new double[] { 10.0, 12.5, 15.0 };
            //}

            //double[] prices = { 25.5, 40.0, 33.75 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            //=======================================================================//
            //question09
            //static bool TryGetPrice(string title, out double price)
            //{
            //    if (title == "Clean Code")
            //    {
            //        price = 25.5;
            //        return true;
            //    }
            //    else
            //    {
            //        price = 0;
            //        return false;
            //    }
            //}

            //if (TryGetPrice("Clean Code", out double price))
            //{
            //    Console.WriteLine(price);
            //}
            //==========================================================================//
            //question10
            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine("Title: " + title + ", Pages: " + pages);
            //}

            //PrintBookInfo("The Hobbit");        
            //PrintBookInfo("The Hobbit", 350); 
            //=========================================================================//
            //question11
            //PrintBookInfo(pages: 250, title: "1984");
            //===================================================================//
            //question12
            //static void PrintAllTitles(params string[] titles)
            //{
            //    foreach (string title in titles)
            //    {
            //        Console.WriteLine(title);
            //    }
            //}

            //PrintAllTitles("Clean Code", "1984", "The Hobbit");
        }
    }
}
