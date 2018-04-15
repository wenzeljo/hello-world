using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstVS2015
{
    public static class FibonocciNumbers
    {
        public static void DoFibonocci(int interations)
        {
            ulong f1 = 0, f2 = 1, f3 = 0;
            useFor(interations, ref f1, ref f2, ref f3);
            var list = new[] { 0, 1, 2, 3, 4, 5 };
            testForOddEven(list);

        }

        private static void testForOddEven(int[] list)
        {
            foreach (var itm in list)
            {
                if (itm % 2 == 0)
                    continue;
                else
                    Console.WriteLine("odd");
            }
        }

        private static void useFor(int interations, ref ulong f1, ref ulong f2, ref ulong f3)
        {
            Show(0, f1);
            Show(1, f2);
            for (int i = 0; i < interations; i++)
            {
                try
                {
                    f3 = f1 + f2;
                    Show(i, f3);
                    f1 = f2;
                    f2 = f3;
                }
                catch (Exception)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey(true);
        }

        private static void Show(int i, decimal f3)
        {
            Console.WriteLine("{0} {1,40}", i, f3.ToString("n0"));
            //Console.WriteLine(i == 0 ? "zero" : "one");
        }
    }
}
