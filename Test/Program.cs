using System;
using System.Linq;

namespace Test
{
    class Program
    {
        private static string _choice;
        private static int _menu;

        static void Main(string[] args)
        {
            PrintMenu();   
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih soal:");
            Console.WriteLine("[1]. 1 2 Hop!");
            Console.WriteLine("[2]. Sort Berdasarkan Posisi");
            Console.WriteLine("[3]. Panda Buku");
            Console.WriteLine("[4]. Angka Amicable");
            Console.WriteLine("[5]. Rentang Terbesar");
            Console.WriteLine("[6]. Struktur Total");
            Console.WriteLine("[0]. Keluar");
            Console.WriteLine("");
            Console.Write("Pilihan dalam angka? ");

            _choice = Console.ReadLine();
            int.TryParse(_choice, out _menu);

            switch (_menu)
            {
                case 1:
                    OneTwoHop();
                    break;
                case 2:
                    SortAlphabet();
                    break;
                case 3:
                    PandaBook();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }

        static void ShowResult()
        {
            Console.ReadLine();
            PrintMenu();
        }

        static void OneTwoHop() {
            int i;
            string s;

            Console.Clear();
            Console.Write("One Two Hop!");
            Console.WriteLine("Input angka integer? ");

            s = Console.ReadLine();
            int.TryParse(s, out i);

            Console.WriteLine();

            if (i > 9)
            {
                Console.Write("Apa?");
            }
            else
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        if (k < i)
                        {
                            Console.Write(k);
                        }
                        else
                        {
                            Console.Write("Hop!");
                        }
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            ShowResult();
        }

        static void SortAlphabet()
        {
            string s;

            Console.Clear();
            Console.Write("Sort Berdasarkan Posisi");
            Console.WriteLine("Masukan kata? ");

            s = Console.ReadLine();
            char[] c = s.Where(i => !string.IsNullOrWhiteSpace(i.ToString())).ToArray();

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = i + 1 ; j < c.Length; j++)
                {
                    if (c[j] == c[i])
                    {
                        char tmp = c[j];
                        c[i] = c[j];
                        c[j] = tmp;
                    }    
                }
            }

            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i]);
            }

            ShowResult();
        }

        static void PandaBook()
        {
            string s;
            int i;

            Console.Clear();
            Console.WriteLine("Buku Panda ");
            Console.WriteLine("Jumlah kata? ");

            s = Console.ReadLine();
            int.TryParse(s, out i);

            Console.WriteLine();

            string[] kata = new string[i];

            for (int j = 0; j < i; j++)
            {
                Console.Write("Masukan kata ke ");
                Console.WriteLine(j+1);
                kata[j] = Console.ReadLine();
            }

            int[] huruf = new int[i];

            for (int j = 0; j < i; j++)
            {
                char[] c = kata[j].ToCharArray();
                Console.WriteLine(c.Distinct().Count());
            }

            ShowResult();
        }

        static void Amicable()
        {
            ShowResult();
        }

        static void Range()
        {
            ShowResult();
        }

        static void Total()
        {
            ShowResult();
        }
    }

    
}
