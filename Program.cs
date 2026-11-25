using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics_session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).
            double[] array = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"The Second Price: {array[1]}");

            #endregion
        }
    }
}
