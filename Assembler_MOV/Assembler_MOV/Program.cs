using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text1, tAX, tBX;
            int Option = 0;
            int AX, BX, CX;   //16-bitowe rejestry

            do
            {
                Console.WriteLine("Assembler ver. 1.0");
                Console.WriteLine("Aby wykonać komendę MOV, po czym wykonać operację ADD MOV wpisz '1'");
                Console.WriteLine("Aby opuścić program wpisz '2'");
                Text1 = Console.ReadLine();
                Int32.TryParse(Text1, out Option);
                if (Option == 1)
                {
                    Console.WriteLine("Podaj liczbę, która ma być w rejestrze AX - /MOV AX");
                    tAX = Console.ReadLine();
                    Int32.TryParse(tAX, out AX);
                    Console.WriteLine("Podaj liczbę, która ma być w rejestrze BX - /MOV BX");
                    tBX = Console.ReadLine();
                    Int32.TryParse(tBX, out BX);
                    Console.WriteLine("Wykonywanie operacji - /ADD MOV AX BX");
                    Console.WriteLine("Proszę czekać. . .");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Proszę czekać. . .");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Proszę czekać. . .");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Operacja wykonana poprawnie.");
                    Console.WriteLine("");
                    Console.WriteLine(AX);
                    Console.WriteLine("Rejestr AX przed wykonaniem operacji.");
                    Console.WriteLine(BX);
                    Console.WriteLine("Rejestr AX przed wykonaniem operacji.");
                    AX = AX + BX;
                    Console.WriteLine(AX);
                    Console.WriteLine("Wynik końcowy zapisany w rejestrze AX.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

            } while (Option != 2);


            //Console.ReadKey();
        }
    }
}
