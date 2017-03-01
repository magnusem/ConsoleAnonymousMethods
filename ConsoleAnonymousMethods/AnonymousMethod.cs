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
        delegate bool delbool(int x);
        delegate int delgange(int x, int y);
        static void Main(string[] args)
        {

            //kalder metoden kvadrat med værdien 2 (OBS: se metoden kvadrat længere nede i koden)
            Console.WriteLine($"Kvadrat : {kvadrat(2)}");

            //delegaten delKvadrat peger på metoden kvadrat 
            delInt1par delKvadrat = kvadrat;

            //kalder metoden kvadrat gennem delegaten delKvadrat
            Console.WriteLine($"delKvadrat : {delKvadrat(2)}"); 

            //anonym metode som gør det samme som kvadrat metoden 
            //og som tildeles delegaten delKvadratAnonym
            delInt1par delKvadratAnonym = delegate(int x)
            {
                return x*x;
            };
            Console.WriteLine("delkvadrat : " + delKvadratAnonym (2));

            //anonym metode skrevet via Lamda syntax og som tildeles delegaten
            //delKvadratLamda
            delInt1par delKvadratLamda = x => x*x;
            Console.WriteLine($"delKvadrat lamda : {delKvadratLamda(2)}" );

            //Istedet for at bruge min egen delegate delInt1par kan jeg bruge
            //en forud defineret delegate Func, så derfor skal jeg bruge den.
            Func<int, int> funcDelegate = x => x * x;
            Console.WriteLine($"funcDelegate: {funcDelegate(2)}");


            //Her skal du selv arbejde med delegates, anonyme metoder og Lamda udtryk

            //Opgave 1: 
            // Test dine kald til metoder og delegates vha. Console.Writeline
            //-kod en delegate som kan pege på metoden "gtrThan100" :   private static bool gtrThan100(int x) 
            //-brug denne delegate og få den til at pege på metoden gtrThan100
            //-brug delegaten til at kode en anonym metode som gør det samme som metoden gtrThan100
            //-brug delegaten til at kode et lambda expression som gør det samme som  gtrThan100
            //-hvilken predefineret delagate kan du bruge istedet for din egen delegate -prøv at bruge den med et Lamda expression

            delbool delGtrTHan100 = gtrThan100;
            Console.WriteLine($"delbool: {delGtrTHan100(101)}");







            delbool delBoolAnonym = delegate (int x)
            {
                return x > 100;
            };
            Console.WriteLine("DelBoolAnonym: " + delBoolAnonym(99));






            delbool delBoolLambda = x => x > 100;
            Console.WriteLine($"delBool Lambda : {delBoolLambda(101)}");







            Func<int, bool> funcDelegateBool = x => x > 100;
            Console.WriteLine($"FuncDelegateBool : {funcDelegateBool(101)}");






            //Opgave2:
            //gør det samme som ovenstående opgave , nu bare med metoden "gange":  private static int gange(int x, int y)






            delgange delGange = gange;
            Console.WriteLine($"delgange: {gange(11, 11)}");






            delgange delgangeAnonym = delegate (int x, int y)
            {
                return x * y;
            };
            Console.WriteLine($"delgangeanonym: " + delgangeAnonym(11, 11));






            delgange delGangeLambda = (x, y) => x + y;
            Console.WriteLine($"Delgange lambda: {delGangeLambda(11, 11)})");




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
