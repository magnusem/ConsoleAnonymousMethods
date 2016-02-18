using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnonymousMethods
{
    //delegaten kan pege på en metode som returnerer en int og som har en int parameter
    delegate int delInt1par(int x);

    class AnonymousMethod
    {
        static void Main(string[] args)
        {

            //kalder metoden kvadrat med 2 
            Console.WriteLine("Kvadrat : " + kvadrat(2) );

            //delegaten delKvadrat peger på metoden kvadrat 
            delInt1par delKvadrat = kvadrat;

            //anonym metode som gør det samme som kvadrat metoden 
            delInt1par delKvadratAnonym = delegate(int x)
            {
                return x*x;
            };

            Console.WriteLine("delkvadrat : " + delKvadratAnonym (2));

            delInt1par delKvadratLamda = x => x*x;

            Console.WriteLine("delKvadrat lamda : " + delKvadratLamda(12) );

            //Her skal du selv kode dine egne anonyme metoder




        }


        /// <summary>
        /// Giver kvadratet på et tal
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static int kvadrat(int x)
        {
            return x * x;
        }

        /// <summary>
        /// tester for om x er større end 100
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static bool gtrThan100(int x)
        {
            return x > 100;
        }

        /// <summary>
        /// ganger x og y sammen
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int gange(int x, int y)
        {
            return x*y;

        }


    }
}
