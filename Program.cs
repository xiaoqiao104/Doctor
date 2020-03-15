using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ji_suan ji = new Ji_suan();
           
            Console.WriteLine( ji.ji_suan(2, 3, '+'));
            Console.WriteLine( ji.ji_suan(2, 3, '-'));
            Console.WriteLine( ji.ji_suan(2, 3, '*'));
            Console.WriteLine( ji.ji_suan(2, 3, '/'));
            Console.WriteLine( ji.ji_suan(2, 0, '/'));

            Console.WriteLine("Equals方法重载：{0}", ji.Equals(2));
            Console.WriteLine("Equals方法重载：{0}", ji.Equals(2,3));

        }
    }
}
