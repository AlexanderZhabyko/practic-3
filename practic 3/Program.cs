namespace practic_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("----Пианино----");
            Console.WriteLine("F3 - третья \nF4 - четвертая \nВыберете начальную октаву \n Для выхода из прогрммы нажмите 0");
            
            Octavi();
        }
        static void Octavi()
        {
            int[] three = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            int[] four = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            ConsoleKeyInfo octava = Console.ReadKey();

            if (octava.Key == ConsoleKey.F3)
            {
                Console.WriteLine("октава 3");
                Vivod3(three);
            }
            if (octava.Key == ConsoleKey.F4)
            {
                Console.WriteLine("октава 4");
                Vivod4(four);
            }
        }
        static void Vivod3(int[] korobka1)
        {
            ConsoleKeyInfo notaa = Console.ReadKey();
            while (notaa.Key != 0)
            {
                
                if (notaa.Key == ConsoleKey.A)
                {
                    Console.Beep(korobka1[0], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.Q)
                {
                    Console.Beep(korobka1[1], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.S)
                {
                    Console.Beep(korobka1[2], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.W)
                {
                    Console.Beep(korobka1[3], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.D)
                {
                    Console.Beep(korobka1[4], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.E)
                {
                    Console.Beep(korobka1[5], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.F)
                {
                    Console.Beep(korobka1[6], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.R)
                {
                    Console.Beep(korobka1[7], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.G)
                {
                    Console.Beep(korobka1[8], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.T)
                {
                    Console.Beep(korobka1[9], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.H)
                {
                    Console.Beep(korobka1[10], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.Y)
                {
                    Console.Beep(korobka1[11], 200);
                    notaa = Console.ReadKey();
                }
                else if (notaa.Key == ConsoleKey.D0);
                {
                    Console.WriteLine(" вы вышли из программы");
                    return;
                }
            }

        }
        static void Vivod4(int[] korobka2)
        {
            ConsoleKeyInfo nota = Console.ReadKey();
            while (nota.Key != 0)
            {  
                if (nota.Key == ConsoleKey.A)
                {
                    Console.Beep(korobka2[0], 200);
                    nota = Console.ReadKey();
                }
                
                else if (nota.Key == ConsoleKey.Q)
                {
                    Console.Beep(korobka2[1], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.S)
                {
                    Console.Beep(korobka2[2], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.W)
                {
                    Console.Beep(korobka2[3], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.D)
                {
                    Console.Beep(korobka2[4], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.E)
                {
                    Console.Beep(korobka2[5], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.F)
                {
                    Console.Beep(korobka2[6], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.R)
                {
                    Console.Beep(korobka2[7], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.G)
                {
                    Console.Beep(korobka2[8], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.T)
                {
                    Console.Beep(korobka2[9], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.H)
                {
                    Console.Beep(korobka2[10], 200);
                    nota = Console.ReadKey();
                }
                else if (nota.Key == ConsoleKey.Y)
                {
                    Console.Beep(korobka2[11], 200);
                    nota = Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n вы вышли из программы");
                    return;
                }
            }
            
        }

    }
}