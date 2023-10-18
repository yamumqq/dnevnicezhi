using System;

namespace естьжидневник
{
    internal class Program
    {
        static DateTime datOchka = DateTime.Now;
        static string[] prokurorskiedelidhki = new string[] { "математика решат", "Добрать норму белков", "пресс качат", "бегит", "Денчик схади в зал", "кинуть салам кентам" };
        static void Main(string[] args)
        {

            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("ТИ ВИБРАЛ ЭТА ДАТА: " + datOchka);
                Menushchechka();
                int pozicia = 1;
                Strelkaestzi(pozicia);
                apisanie(pozicia);
                key = Console.ReadKey();
            } while (key.Key == ConsoleKey.Escape);
        }

        static int Strelkaestzi(int pozicia)
        {

            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pozicia);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pozicia--;
                    if (pozicia == 0)
                    {
                        pozicia = 4;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pozicia++;
                    if (pozicia == 5)
                    {
                        pozicia = 1;
                    }
                }
                Console.SetCursorPosition(0, pozicia);
                Console.WriteLine("->");

                razndat(key);
            } while (key.Key != ConsoleKey.Enter);
            return pozicia;
        }
        static void razndat(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.SetCursorPosition(0, 0);
                datOchka = datOchka.AddDays(-1);
                Console.Clear();
                Console.Write("ТИ ВИБРАЛ ЭТА ДАТА: " + datOchka + "\n");
                Menushchechka();
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Console.SetCursorPosition(0, 0);
                datOchka = datOchka.AddDays(+1);
                Console.Clear();
                Console.Write("ТИ ВИБРАЛ ЭТА ДАТА: " + datOchka + "\n");
                Menushchechka();
            }


        }
        static void Menushchechka()
        {
            if (datOchka.Date == new DateTime(2023, 10, 19))
            {
                Console.WriteLine($"  1. {prokurorskiedelidhki[1]}");
                Console.WriteLine($"  2. {prokurorskiedelidhki[5]}");


            }
            else if (datOchka.Date == new DateTime(2023, 10, 24))
            {
                Console.WriteLine($"  1. {prokurorskiedelidhki[0]}");

            }
            else if (datOchka.Date == new DateTime(2023, 10, 18))
            {
                Console.WriteLine($"  1. {prokurorskiedelidhki[2]}");

            }
            else if (datOchka.Date == new DateTime(2023, 10, 22))
            {
                Console.WriteLine($"  1. {prokurorskiedelidhki[3]}");

            }
            else if (datOchka.Date == new DateTime(2023, 10, 21))
            {
                Console.WriteLine($"  1. {prokurorskiedelidhki[4]}");

            }
        }
        static void apisanie(int pozicia)
        {
            if (pozicia == 1 && datOchka.Date == new DateTime(2023, 10, 22))
            {
                Console.Clear();
                Console.WriteLine($"{prokurorskiedelidhki[3]}");
                Console.WriteLine("-----------------");
                Console.WriteLine("описание: иди кайфани и побегвй есть жи. Сделай это до завтра да жи");
                Console.WriteLine("твая дата: " + datOchka);

            }
            else if (pozicia == 1 && datOchka.Date == new DateTime(2023, 10, 19))
            {
                Console.Clear();
                Console.WriteLine($"{prokurorskiedelidhki[1]}");
                Console.WriteLine("-----------------");
                Console.WriteLine("описание: иди пожри курицу. Сделай это до 20.10 да жи");
                Console.WriteLine("твая дата: " + datOchka);
                pozicia++;
                if (pozicia == 2 && datOchka.Date == new DateTime(2023, 10, 19))
                {
                    Console.Clear();
                    Console.WriteLine($"{prokurorskiedelidhki[5]}");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("описание: Закинь салам тиме, кириллу, владосу и всем кого увидишь знакомого. Сделай это до завтра да жи");
                    Console.WriteLine("твая дата: " + datOchka);
                }
            }
            else if (pozicia == 1 && datOchka.Date == new DateTime(2023, 10, 18))
            {
                Console.Clear();
                Console.WriteLine($"{prokurorskiedelidhki[2]}");
                Console.WriteLine("-----------------");
                Console.WriteLine("описание: в зале убейся пресссом. Сделай это до завтра да жи");
                Console.WriteLine("твая дата: " + datOchka);

            }
            else if (pozicia == 1 && datOchka.Date == new DateTime(2023, 10, 21))
            {
                Console.Clear();
                Console.WriteLine($"{prokurorskiedelidhki[4]}");
                Console.WriteLine("-----------------");
                Console.WriteLine("описание: делай жим лежа . Сделай это сегодня да жи");
                Console.WriteLine("твая дата: " + datOchka);

            }
            else if (pozicia == 1 && datOchka.Date == new DateTime(2023, 10, 24))
            {
                Console.Clear();
                Console.WriteLine($"{prokurorskiedelidhki[0]}");
                Console.WriteLine("-----------------");
                Console.WriteLine("Сделай ради меня математику . Сделай это завтра или послезавтра да жи");
                Console.WriteLine("твая дата: " + datOchka);

            }
        }


    }
}