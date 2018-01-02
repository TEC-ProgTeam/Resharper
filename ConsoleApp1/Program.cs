using System;

namespace Resharper
{
    class Program
    {
        // ville skrive en kommentar
        /// <summary>
        /// Summary er på metodeniveau
        /// Main metoden starter mit program
        /// </summary>
        /// param er for den enkelte parameter i en metode
        /// det der står mellem de 2 tags i param er en forklaring til hver parameter i metoden, 
        /// når metoden anvendes - en form for udvidet intellisens
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {
            int valg;
            Console.WriteLine("Indtast et tal");
            valg = Convert.ToInt32(Console.ReadLine());

            if (valg == 1)
            {
                Console.WriteLine("1");
            }
            else if (valg == 2)
            {
                Console.WriteLine("2");
            }
            else if (valg == 3)
            {
                Console.WriteLine("3");
            }

            // b();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="test1">dette er det første tal i en lommeregner</param>
        /// <param name="test2">dette er det andet tal i en lommeregner</param>
        public static void a(int test1, int test2)
        {
            //personlig nøgle til github, så man ikke kan overskrive.
        }

        public static void b(int test1, int test2)
        {

        }

        public void a()
        {

        }
    }
}
