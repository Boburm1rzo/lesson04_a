using System.Threading.Channels;

namespace lesson04
{
    
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Task 1
            Console.Write("1 dan 1 mln gacha son kiriting:");
            int number = int.Parse(Console.ReadLine());
            int r1, r2, r3, r4, r5, r6;
            r1 = number % 10;
            r2 = number / 10 % 10;
            r3 = number / 100 % 10;
            r4 = number / 1000 % 10;
            r5 = number / 10000 % 10;
            r6 = number / 100000 % 10;
            switch (r6)
            {
                case 1:
                    Console.Write("bir yuz ");
                    if (r4 == 0 && r5 == 0) Console.Write("ming ");
                    break;
                case 2:
                    Console.Write("ikki yuz ");
                    if (r4 == 0 && r5 == 0) Console.Write("ming ");
                    break;
                case 3:
                    Console.Write("uch yuz ");
                    if (r4 == 0 && r5 == 0) Console.Write("ming ");
                    break;
                case 4:
                    Console.Write("to`rt yuz ");
                    if (r4 == 0 && r5 == 0) Console.Write("ming ");
                    break;
                case 5:
                    Console.Write("besh yuz ");
                    if (r4 == 0 && r5 == 0) Console.Write("ming ");
                    break;
                case 6:
                    Console.Write("olti yuz ");
                    if (r4 == 0 && r5 == 0) Console.Write("ming ");
                    break;
                case 7:
                    Console.Write("yetti yuz ");
                    if (r4 == 0 && r5 == 0) Console.Write("ming ");
                    break;
                case 8:
                    Console.Write("sakkiz yuz ");
                    if (r4 == 0 && r5 == 0) Console.Write("ming ");
                    break;
                case 9:
                    Console.Write("to`qqiz yuz ");
                    if (r4 == 0 && r5 == 0) Console.Write("ming ");
                    break;
            }
            switch (r5)
            {
                case 1:
                    Console.Write("o`n ");
                    if (r4 == 0) Console.Write("ming ");
                    break;
                case 2:
                    Console.Write("yigirma ");
                    if (r4 == 0) Console.Write("ming ");
                    break;
                case 3:
                    Console.Write("o`ttiz ");
                    if (r4 == 0) Console.Write("ming ");
                    break;
                case 4:
                    Console.Write("qirq ");
                    if (r4 == 0) Console.Write("ming ");
                    break;
                case 5:
                    Console.Write("ellik ");
                    if (r4 == 0) Console.Write("ming ");
                    break;
                case 6:
                    Console.Write("oltmish ");
                    if (r4 == 0) Console.Write("ming ");
                    break;
                case 7:
                    Console.Write("yetmish ");
                    if (r4 == 0) Console.Write("ming ");
                    break;
                case 8:
                    Console.Write("sakson ");
                    if (r4 == 0) Console.Write("ming ");
                    break;
                case 9:
                    Console.Write("to`qson ");
                    if (r4 == 0) Console.Write("ming ");
                    break;
            }
            switch (r4)
            {
                case 0:
                    Console.Write(" ");
                    break;
                case 1:
                    Console.Write("bir ming ");
                    break;
                case 2:
                    Console.Write("ikki ming ");
                    break;
                case 3:
                    Console.Write("uch ming ");
                    break;
                case 4:
                    Console.Write("to`rt ming ");
                    break;
                case 5:
                    Console.Write("besh ming ");
                    break;
                case 6:
                    Console.Write("olti ming ");
                    break;
                case 7:
                    Console.Write("yetti ming ");
                    break;
                case 8:
                    Console.Write("sakkiz ming ");
                    break;
                case 9:
                    Console.Write("to`qqiz ming ");
                    break;
            }
            switch (r3)
            {
                case 1:
                    Console.Write("bir yuz ");
                    break;
                case 2:
                    Console.Write("ikki yuz ");
                    break;
                case 3:
                    Console.Write("uch yuz ");
                    break;
                case 4:
                    Console.Write("to`rt yuz ");
                    break;
                case 5:
                    Console.Write("besh yuz ");
                    break;
                case 6:
                    Console.Write("olti yuz ");
                    break;
                case 7:
                    Console.Write("yetti yuz ");
                    break;
                case 8:
                    Console.Write("sakkiz yuz ");
                    break;
                case 9:
                    Console.Write("to`qqiz yuz ");
                    break;
            }
            switch (r2)
            {
                case 1:
                    Console.Write("o`n ");
                    break;
                case 2:
                    Console.Write("yigirma ");
                    break;
                case 3:
                    Console.Write("o`ttiz ");
                    break;
                case 4:
                    Console.Write("qirq ");
                    break;
                case 5:
                    Console.Write("ellik ");
                    break;
                case 6:
                    Console.Write("oltmish ");
                    break;
                case 7:
                    Console.Write("yetmish ");
                    break;
                case 8:
                    Console.Write("sakson ");
                    break;
                case 9:
                    Console.Write("to`qson ");
                    break;
            }
            switch (r1)
            {
                case 1:
                    Console.Write("bir ");
                    break;
                case 2:
                    Console.Write("ikki ");
                    break;
                case 3:
                    Console.Write("uch ");
                    break;
                case 4:
                    Console.Write("to`rt ");
                    break;
                case 5:
                    Console.Write("besh ");
                    break;
                case 6:
                    Console.Write("olti ");
                    break;
                case 7:
                    Console.Write("yetti ");
                    break;
                case 8:
                    Console.Write("sakkiz ");
                    break;
                case 9:
                    Console.Write("to`qqiz ");
                    break;
            }
            Console.WriteLine();
            //Main(args);
            #endregion
           
        }
    }
}