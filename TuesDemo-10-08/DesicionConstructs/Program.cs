using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesicionConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if/else examples

            
            if (true)
            {
                Console.WriteLine(true);
            }
            if (!false)
            {
                Console.WriteLine(false);
            }

            if (false)
            {
                Console.WriteLine(false);
            }  else
            {
                Console.WriteLine("if/else {0}", false);
            }
            #endregion


            #region switch statement example
            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine(i);
                        break;
                    case 1:
                        Console.WriteLine(i);
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("2 or 3: {0}",i);
                        break;

                    default:
                        Console.WriteLine("default: {0}", i);
                        break;
                }
            }
            #endregion

        }
    }
}
