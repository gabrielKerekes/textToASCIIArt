using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace TextToASCIIArt
{
    public class Program
    {
        public const int MarginSize = 2;

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your text:");
                var word = Console.ReadLine();
                //var word = "GABKO";
                word = word.ToUpper();

                var lines = new List<StringBuilder>();
                InitializeLines(lines);

                Console.WriteLine();

                foreach (var c in word)
                {
                    if (char.IsLetter(c))
                    {
                        var thisType = typeof(Program);
                        var methodName = "Print" + c;
                        var method = thisType.GetMethod(methodName);
                        method.Invoke(null, new[] {lines});
                    }
                    else if (c == ' ')
                    {
                        PrintSpace(lines);
                    }
                    else
                    {
                        Console.WriteLine("Unsupported char. Sorry, not finished yet!");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static void InitializeLines(List<StringBuilder> lines)
        {
            lines.Add(new StringBuilder());
            lines.Add(new StringBuilder());
            lines.Add(new StringBuilder());
            lines.Add(new StringBuilder());
            lines.Add(new StringBuilder());
            lines.Add(new StringBuilder());
        }

        public static void PrintMargin(List<StringBuilder> lines)
        {
            for (int i = 0; i < MarginSize; i++)
            {
                lines[0].Append(" ");
                lines[1].Append(" ");
                lines[2].Append(" ");
                lines[3].Append(" ");
                lines[4].Append(" ");
                lines[5].Append(" ");
            }
        }

        public static void PrintSpace(List<StringBuilder> lines)
        {
            PrintMargin(lines);
            PrintMargin(lines);
        }

        public static void PrintA(List<StringBuilder> lines)
        {
            lines[0].Append(" AA ");
            lines[1].Append("A  A");
            lines[2].Append("A  A");
            lines[3].Append("AAAA");
            lines[4].Append("A  A");
            lines[5].Append("A  A");

            PrintMargin(lines);
        }

        public static void PrintB(List<StringBuilder> lines)
        {
            lines[0].Append("BBB ");
            lines[1].Append("B  B");
            lines[2].Append("BBB ");
            lines[3].Append("B  B");
            lines[4].Append("B  B");
            lines[5].Append("BBB ");

            PrintMargin(lines);
        }

        public static void PrintC(List<StringBuilder> lines)
        {
            lines[0].Append(" CC ");
            lines[1].Append("C  C");
            lines[2].Append("C   ");
            lines[3].Append("C  C");
            lines[4].Append("C  C");
            lines[5].Append(" CC ");

            PrintMargin(lines);
        }

        public static void PrintD(List<StringBuilder> lines)
        {
            lines[0].Append("DDD ");
            lines[1].Append("D  D");
            lines[2].Append("D  D");
            lines[3].Append("D  D");
            lines[4].Append("D  D");
            lines[5].Append("DDD ");

            PrintMargin(lines);
        }

        public static void PrintE(List<StringBuilder> lines)
        {
            lines[0].Append("EEEE");
            lines[1].Append("E   ");
            lines[2].Append("EEE ");
            lines[3].Append("E   ");
            lines[4].Append("E   ");
            lines[5].Append("EEEE");

            PrintMargin(lines);
        }

        public static void PrintF(List<StringBuilder> lines)
        {
            lines[0].Append("FFFF");
            lines[1].Append("F   ");
            lines[2].Append("FFF ");
            lines[3].Append("F   ");
            lines[4].Append("F   ");
            lines[5].Append("F   ");

            PrintMargin(lines);
        }

        public static void PrintG(List<StringBuilder> lines)
        {
            lines[0].Append(" GG ");
            lines[1].Append("G  G");
            lines[2].Append("G   ");
            lines[3].Append("G GG");
            lines[4].Append("G  G");
            lines[5].Append(" GG ");

            PrintMargin(lines);
        }

        public static void PrintH(List<StringBuilder> lines)
        {
            lines[0].Append("H  H");
            lines[1].Append("H  H");
            lines[2].Append("HHHH");
            lines[3].Append("H  H");
            lines[4].Append("H  H");
            lines[5].Append("H  H");

            PrintMargin(lines);
        }

        public static void PrintI(List<StringBuilder> lines)
        {
            lines[0].Append("I");
            lines[1].Append("I");
            lines[2].Append("I");
            lines[3].Append("I");
            lines[4].Append("I");
            lines[5].Append("I");

            PrintMargin(lines);
        }

        public static void PrintJ(List<StringBuilder> lines)
        {
            lines[0].Append("JJJJ");
            lines[1].Append("J  J");
            lines[2].Append("   J");
            lines[3].Append("   J");
            lines[4].Append("J  J");
            lines[5].Append(" JJ ");

            PrintMargin(lines);
        }

        public static void PrintK(List<StringBuilder> lines)
        {
            lines[0].Append("K  K");
            lines[1].Append("K K ");
            lines[2].Append("KK  ");
            lines[3].Append("KK  ");
            lines[4].Append("K K ");
            lines[5].Append("K  K");

            PrintMargin(lines);
        }

        public static void PrintL(List<StringBuilder> lines)
        {
            lines[0].Append("L   ");
            lines[1].Append("L   ");
            lines[2].Append("L   ");
            lines[3].Append("L   ");
            lines[4].Append("L   ");
            lines[5].Append("LLLL");

            PrintMargin(lines);
        }

        public static void PrintM(List<StringBuilder> lines)
        {
            lines[0].Append("M  M");
            lines[1].Append("M\\/M");
            lines[2].Append("M  M");
            lines[3].Append("M  M");
            lines[4].Append("M  M");
            lines[5].Append("M  M");

            PrintMargin(lines);
        }

        public static void PrintN(List<StringBuilder> lines)
        {
            lines[0].Append("N  N");
            lines[1].Append("NN N");
            lines[2].Append("NN N");
            lines[3].Append("N NN");
            lines[4].Append("N NN");
            lines[5].Append("N  N");

            PrintMargin(lines);
        }

        public static void PrintO(List<StringBuilder> lines)
        {
            lines[0].Append(" OO ");
            lines[1].Append("O  O");
            lines[2].Append("O  O");
            lines[3].Append("O  O");
            lines[4].Append("O  O");
            lines[5].Append(" OO ");

            PrintMargin(lines);
        }

        public static void PrintP(List<StringBuilder> lines)
        {
            lines[0].Append("PPP");
            lines[1].Append("P  P");
            lines[2].Append("PPP ");
            lines[3].Append("P   ");
            lines[4].Append("P   ");
            lines[5].Append("P   ");

            PrintMargin(lines);
        }

        public static void PrintQ(List<StringBuilder> lines)
        {
            lines[0].Append(" QQ ");
            lines[1].Append("Q  Q");
            lines[2].Append("Q  Q");
            lines[3].Append("Q QQ");
            lines[4].Append("Q QQ");
            lines[5].Append(" QQ ");

            PrintMargin(lines);
        }

        public static void PrintR(List<StringBuilder> lines)
        {
            lines[0].Append("RRR ");
            lines[1].Append("R  R");
            lines[2].Append("RRR ");
            lines[3].Append("RR  ");
            lines[4].Append("R R ");
            lines[5].Append("R  R");

            PrintMargin(lines);
        }

        public static void PrintS(List<StringBuilder> lines)
        {
            lines[0].Append("SSSS");
            lines[1].Append("S   ");
            lines[2].Append("SS  ");
            lines[3].Append(" SS ");
            lines[4].Append("   S");
            lines[5].Append("SSSS");

            PrintMargin(lines);
        }

        public static void PrintT(List<StringBuilder> lines)
        {
            lines[0].Append("TTTT");
            lines[1].Append(" TT ");
            lines[2].Append(" TT ");
            lines[3].Append(" TT ");
            lines[4].Append(" TT ");
            lines[5].Append(" TT ");

            PrintMargin(lines);
        }

        public static void PrintU(List<StringBuilder> lines)
        {
            lines[0].Append("U  U");
            lines[1].Append("U  U");
            lines[2].Append("U  U");
            lines[3].Append("U  U");
            lines[4].Append("U  U");
            lines[5].Append(" UU ");

            PrintMargin(lines);
        }

        public static void PrintV(List<StringBuilder> lines)
        {
            lines[0].Append("V  V");
            lines[1].Append("V  V");
            lines[2].Append("V  V");
            lines[3].Append("V  V");
            lines[4].Append(" VV ");
            lines[5].Append(" VV ");

            PrintMargin(lines);
        }

        public static void PrintW(List<StringBuilder> lines)
        {
            lines[0].Append("W  W");
            lines[1].Append("W  W");
            lines[2].Append("W  W");
            lines[3].Append("W  W");
            lines[4].Append("W\\/W");
            lines[5].Append("W  W");

            PrintMargin(lines);
        }

        public static void PrintX(List<StringBuilder> lines)
        {
            lines[0].Append("X  X");
            lines[1].Append("X  X");
            lines[2].Append(" XX ");
            lines[3].Append(" XX ");
            lines[4].Append("X  X");
            lines[5].Append("X  X");

            PrintMargin(lines);
        }

        public static void PrintY(List<StringBuilder> lines)
        {
            lines[0].Append("Y  Y");
            lines[1].Append("Y  Y");
            lines[2].Append("Y  Y");
            lines[3].Append(" YY ");
            lines[4].Append(" YY ");
            lines[5].Append(" YY ");

            PrintMargin(lines);
        }

        public static void PrintZ(List<StringBuilder> lines)
        {
            lines[0].Append("ZZZZ");
            lines[1].Append("   Z");
            lines[2].Append(" ZZ ");
            lines[3].Append("ZZ  ");
            lines[4].Append("Z   ");
            lines[5].Append("ZZZZ");

            PrintMargin(lines);
        }
    }
}
