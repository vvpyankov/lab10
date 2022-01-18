using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(/*"Мурка", "черный", 1*/);
            // cat.Say();
            cat.name = "Мурка"; 
            cat.color = "Черный";
            cat.age = 1;
            Console.WriteLine(cat.name);
            Console.WriteLine(cat.color);
            Console.WriteLine(cat.age);
            Console.ReadKey();

        }
    }
    class Cat
    {
        public string name;
        public string color;
        public int age;
        /*public Cat(string name, string color = "Grey", int age = 1)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }*/
        public void Say()
        {
            Console.WriteLine("Мяу! Меня зовут {0}!", name);
        }
    }

}

