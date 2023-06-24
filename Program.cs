using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.
                • Exemplu: citim 3,9,0 Afisam : 9 3 0
            */

            Console.WriteLine("introduceti primul numar");
            int numar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti al doilea numar");
            int numar2 = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti al treilea numar");
            int numar3 = int.Parse(Console.ReadLine());

            if (numar1 >= numar2 && numar2 >= numar3)
                Console.WriteLine(numar1 + " " + numar2 + " " + numar3);
            else if
                (numar1 >= numar2 && numar2 < numar3 && numar1>=numar3)
                Console.WriteLine(numar1 + " " + numar3 + " " + numar2);
            else if (numar1 >= numar2 && numar2 < numar3 && numar1 < numar3)
                Console.WriteLine(numar3 + " " + numar1 + " " + numar2);
            else if
                (numar1 < numar2 && numar2 < numar3)
                Console.WriteLine(numar3 + " " + numar2 + " " + numar1);
            else if
                (numar1 < numar2 && numar2 >= numar3 && numar1 >= numar3)
                Console.WriteLine(numar2 + " " + numar1 + " " + numar3);
            else if ( numar1 < numar3)
                Console.WriteLine(numar2 + " " + numar3 + " " + numar1);
        }
    }
}
