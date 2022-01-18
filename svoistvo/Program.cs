using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svoistvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "Черный", 1);
            cat.Say();
            Console.ReadKey();
        }
    }
    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        int age;

        public int Age
        {
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст не м.б. отрицательным");
                }
            }
            get
            {
                return age;
            }
        }
        public Cat(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }
        public void Say()
        {
            Console.WriteLine("Мяу! Меня зовут {0}. У меня {1} цвет! Мне {2} лет!", Name, Color, Age);
        }
    }
}
