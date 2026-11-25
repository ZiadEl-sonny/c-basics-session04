using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace c_basics_session04
{
    internal class Program
    {

        #region funcOfQuestion3
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion

        #region funcOfQuestion4

        //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
        //"Clean Code".
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine($"Book title: {title}");
        //}
        #endregion

        #region funcOfQuestion5
        //        Write a method AddBonusPages(int pages) that adds 50 to pages.Call it with a variable
        //int pages = 400; and print pages afterward.What do you expect to see, and why?
        //static int AddBonusPages(int pages)
        //{
        //   return pages += 50;
        //}


        #endregion

        #region funcOfQuestion6
        //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
        //            with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
        //see, and why?
        //static double ApplyDiscount(double[] prices)
        //{
        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        prices[i] -= 5;
        //    }
        //    return prices[0];
        //}



        #endregion

        #region funcOfQuestion7
        //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
        // Call it and print pages afterward.How is the result different from question 5?

        //static int AddBonusPages (ref int pages)
        //{
        //    return pages += 50;
        //}


        #endregion

        #region funcOfQuestion8
        /*Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
        new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
         afterward*/

        public static double[] ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
            return prices;

        }



        #endregion

        static void Main(string[] args)
        {
            #region question1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).
            //double[] array = { 25.5, 40.0, 33.75 };
            //Console.WriteLine($"The Second Price: {array[1]}");

            #endregion

            #region question2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0


            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine($"the number of copies on shelf 1, slot 0:  {shelfCopies[1,0]}");
            #endregion

            #region question3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main
            //PrintWelcomeMessage();



            #endregion

            #region question4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            //"Clean Code".
            //PrintBookTitle("Clean Code");






            #endregion

            #region question5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?

            //int pages = 400;
            //Console.WriteLine($" Pages:{AddBonusPages(pages)}");
            //Console.WriteLine("----------------Afterward---------------");
            //Console.WriteLine($" Pages: {pages}");


            // Expected function=> Pages:450 , variable Pages => 400
            // because the variable passed by "Value Type as a value" that does not change the original value.
            #endregion

            #region question6

            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //            with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?

            //  double[] prices = { 25.5, 40.0 };
            //Console.WriteLine( ApplyDiscount(prices));
            //Console.WriteLine("-------afterward-------");
            //  Console.WriteLine(prices[0]);

            //20.5 & 20.5
            //because the array passed by "value Type as a reference" that changes the original value.





            #endregion

            #region question7
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?

            //int pages = 400;
            //Console.WriteLine($" Pages:{AddBonusPages(ref pages)}");
            //Console.WriteLine("----------------Afterward---------------");
            //Console.WriteLine($" Pages: {pages}");

            //Pages:450,afterward,Pages:450
            //because the array passed by "value Type as a reference" that changes the original value.

            #endregion

            #region question8
            /*Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
             afterward*/

            double[] pricesArray = { 25.5, 40.0,11.2,18 };
            pricesArray = ReplaceArray(ref pricesArray);
            Console.WriteLine(pricesArray.Length);


            #endregion








        }
    }
}
