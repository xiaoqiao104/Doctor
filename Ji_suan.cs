using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ji_suan
    {
        float  z;
       
       
        public float ji_suan(float x, float y, char f)
        {

            switch (f)
            {
                case '+':
                    Console.WriteLine("两个数相加，结果为：");
                    z = x + y;
                    break;
                case '-':
                    Console.WriteLine("两个数相减，结果为：");
                    z = x - y;
                    break;
                case '*':
                    Console.WriteLine("两个数相乘，结果为：");
                    z = x * y;
                    break;
                case '/':
                    z = x / y;
                    Console.WriteLine("两个数相除，结果为：");
                    if (y == 0)
                    {
                        Console.WriteLine("分母为0无意义");
                        break;
                    }
                    break;

            }
            return z;



        }
        public bool Equals(int x)
        {
            Console.WriteLine("只有一个参数不能进行比较");
            return false;


        }
        public bool Equals(int x,int y)
        {
            if (x == y)
            {
                Console.WriteLine("两个数相等");
                return true;

            }
            else
            {
                Console.WriteLine("两个数不相等");
                return false;
            }
           
        }
    }
}
