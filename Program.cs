using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double liczba, r, H, V, i, silnia = 1, cyfra, R, P;

            Console.WriteLine("Podaj liczbę od 0 do 3");
            Console.WriteLine("0 - kończy program");
            Console.WriteLine("1 - obliczanie objętości stożka");
            Console.WriteLine("2 - obliczanie silni");
            Console.WriteLine("3 - obliczanie pola kuli");

            liczba = Convert.ToDouble(Console.ReadLine());

            {
                switch (liczba)
                {
                    case 0: break;

                    case 1:

                        Console.WriteLine("Podaj r: ");
                        r = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Podaj H: ");
                        H = Convert.ToDouble(Console.ReadLine());

                        V = (1 / 3.0) * Math.PI * r * r * H;

                        Console.WriteLine("V = {0}", V);

                        break;


                    case 2:

                        Console.WriteLine("Podaj liczbę, której silnię chcesz wykonać: ");
                        cyfra = Convert.ToDouble(Console.ReadLine());

                        for (i = 1; i <= cyfra; i++)
                        {

                            silnia = i * silnia;

                        }

                        Console.WriteLine("Silnia wynosi = {0}", silnia);

                        break;

                    case 3:

                        Console.WriteLine("Podaj R");
                        R = Convert.ToDouble(Console.ReadLine());

                        P = 4 * Math.PI * R * R;

                        Console.WriteLine("P={0}", P);

                        break;

                    default:

                        Console.WriteLine("Wpisałeś liczbę spoza zakresu");

                        break;
                }

            }
        }
    }
}
