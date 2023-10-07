using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4TEP_Programowanie_aplikacji_C_Sharp
{
    public class Program
    {
        // rekurencja
        public double silnia(double n)
        {
            if(n == 0)
            {
                return 1;
            }else
            {
                return n * silnia(n - 1);
            }
        }
        static void Main(string[] args)
        {
            // sprawdź objaśnieine do pkt w klasie Structur

            //1.

            Console.WriteLine("Twoj pierwszy program");

            //2.
            int first = Convert.ToInt32(Console.ReadLine());

            //3. 
            if(first > 0 && first <=100)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine("niewlasciwe dane");
            }

            //4. i 5.

            int suma = 0;

            Console.WriteLine("podaj poczatek: ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj koniec: ");
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = p; i <= k; i++)
            {
                if(i % 50 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("podana suma z zakresu wnosi: " + suma);

            //6.

            for (int i = 1; i < 71; i*=2)
            {
                Console.WriteLine("podano potęgi mniejsze niż 71");
            }

            Program program = new Program();
            

            Console.WriteLine("silnia wynosi: " + program.silnia(5));

            //7. 
            int j = 1;
            while (j<=19)
            {
                j++;
                Console.WriteLine("liczba to: " + j);
            }

            //8. 



            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            Console.ReadKey();

        }
    }
}
