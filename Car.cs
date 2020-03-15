using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        string _species;
        string _color;
        int _chair;
        int _speed;

        public string Species { get => _species; set => _species = value; }
        public string Color { get => _color; set => _color = value; }
        public int Chair { get => _chair; set => _chair = value; }
        public int Speed { get => _speed; set => _speed = value; }

        public string move()
        {
            string say="汽车停下来了";
            return say;
        }
        public string move(int speed)
        {
            string say = "汽车开起来了";
            return say;
        }
    }
}
