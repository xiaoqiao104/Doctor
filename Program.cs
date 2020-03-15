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
            Car car = new Car();
            car.Species = "路虎";
            car.Color = "白色";
            car.Chair = 8;
            Console.WriteLine("车的类型：{0}", car.Species);
            Console.WriteLine("车的颜色:{0}", car.Color);
            Console.WriteLine("车的椅子数:{0}", car.Chair);
            Console.WriteLine(car.move());
            car.Speed = 100;
            Console.WriteLine(car.move(car.Speed));

        }
    }
}
