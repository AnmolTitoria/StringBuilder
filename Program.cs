using System;
using System.Text;
using System.Diagnostics;


namespace StringBuilde
{
    public class Program
    {

        static void Main(string[] args)
        {
            Stopwatch sw1 = Stopwatch.StartNew();
            sw1.Start();
            {
                string Name = "String";
                for (int i = 0; i <= 100; i++)
                {
                    Name = Name + i;
                }
            }
            sw1.Start();


            StringBuilder sb = new StringBuilder("String Builder");
            Stopwatch sw2 = Stopwatch.StartNew();
            sw1.Start();
            for (int i = 0; i <= 100; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("Time Taken for String="+ sw1.ElapsedMilliseconds );
            Console.WriteLine("Time Taken for StringBuilder="+ sw2.ElapsedMilliseconds);
            

            StringBuilder sb1 = new StringBuilder("This is a StringBuilder & String Comparesion Program");
            sb1.Append("in ");
            sb1.AppendLine("C#");
            Console.WriteLine(sb1);
            sb1.Remove(8, 2);
            sb1.Replace("&", "and");
            Console.WriteLine(sb1);

            Console.ReadLine();

        }

        
    }

}
