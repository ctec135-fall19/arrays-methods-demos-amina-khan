using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itterations
{
    class Program
    {
        static void Main(string[] args)
        {
            #region siple for loop

            Console.WriteLine("Simple for loop example");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();

            #endregion

            #region nested for loops

            Console.WriteLine("Nested for loop example");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("i= {0}, j= {1}", i, j);
                }

            }
            #endregion

            #region foreach loop
            Console.WriteLine("foreach element in array example");
            int[] myInts = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < myInts.Length; i++)
            {
                myInts[i] = i + 10;
            }

            foreach (int element in myInts)
            {
                Console.WriteLine(element);
            }

            #endregion

            #region while loop

            int count = 0;
            while (count < myInts.Length)
            {
                Console.WriteLine("{0}", myInts[count]);
                count++;
            }

            #endregion

            #region do/while loop

            Console.WriteLine();
            do
            {
                Console.WriteLine("{0}", myInts[0]);
                count++;
            }
            while (count < myInts.Length)

            #endregion
        }
    }
}
