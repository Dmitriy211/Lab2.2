using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_2
{
    class Program
    {
        static void Simple()
        {
            string t = File.ReadAllText(@"C:\Users\d_tuchashvili\Desktop\a.txt");
            string[] s = t.Split(' ');

            int max = int.Parse(s[0]);
            int min = int.Parse(s[0]);

            List<int> sim = new List<int>();
            int k = 0;

            for (int i = 0; i < s.Length; i++)
            {
                k = 0;
                int a = int.Parse(s[i]);
                for (int h = 2; h < a; h++)
                    if (a % h == 0)
                        k = 1;
                if (k == 0)
                {
                    sim.Add(a);
                }
            }

            int simmin = sim.Min();

            Console.WriteLine("Min simple = " + simmin + "\n");
            File.WriteAllText(@"C:\Users\d_tuchashvili\Desktop\a simple.txt", simmin.ToString());
            
        }






        static void MaxMin()
        {
            string t = File.ReadAllText(@"C:\Users\d_tuchashvili\Desktop\a.txt");
            string[] s = t.Split(' ');

            int max = int.Parse(s[0]);
            int min = int.Parse(s[0]);

            for (int i = 0; i < s.Length - 1; i++)
            {
                int b = int.Parse(s[i + 1]);
                if (b <= min)
                    min = b;
                if (b >= max)
                    max = b;
            }
            Console.WriteLine(t);
            Console.WriteLine("\nMax = " + max + "\nMin = " + min);
            
        }






        static void Main(string[] args)
        {
            MaxMin();
            Simple();
        }
    }
}
