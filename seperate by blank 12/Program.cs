using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seperate_by_blank_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num ;
            Console.WriteLine("enter age");
            num =Convert.ToInt32(Console.ReadLine());
            Console.Write(num+"\t"+num+"\t"+num+" "+num);
            Console.WriteLine();
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine();

            Console.Write("{0} {0} {0}",num);
            Console.WriteLine();
            Console.Write("{0}{0}{0}",num);
            Console.ReadLine();
        }
    }
}
