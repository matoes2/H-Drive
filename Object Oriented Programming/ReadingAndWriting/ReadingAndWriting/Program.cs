using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingAndWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamWriter sw = new StreamWriter("n00bz.txt"))
            {
                sw.WriteLine("Hello World");
                sw.WriteLine("Pussy Lover!!");
                sw.WriteLine("Hello World");
                sw.WriteLine("Pussy Lover!!");
                sw.WriteLine("Hello World");
                sw.WriteLine("Pussy Lover!!");
                sw.WriteLine("Hello World");
                sw.WriteLine("Pussy Lover!!");
                sw.WriteLine("Hello World");
                sw.WriteLine("Pussy Lover!!");
            }
            using (StreamReader sr = new StreamReader("n00bz.txt"))
            {
                string name = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine() + name);
                }
            }
        }
    }
}
