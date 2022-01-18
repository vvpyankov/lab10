using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10zadacha
{
    public class Program
    {
        public static void Main(string[] args)
        {
			Angle angle = new Angle();
			try
			{
				Console.WriteLine("Укажите значение угла (целочисленные значения!!!)");
				Console.Write("Градусы угла - ");
				angle.Grad = Convert.ToInt32(Console.ReadLine());

				Console.Write("Минуты угла - ");
				angle.Min = Convert.ToInt32(Console.ReadLine());

				Console.Write("Секунды угла - ");
				angle.Sec = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Формат значений - некорректен!");
				return;
			}
			angle.ToRadians();
			Console.ReadKey();
		}
	}
	class Angle
	{
		int grad;
		int min;
		int sec;

		public int Grad
		{
			set
			{
				if (value >= 0 && value <= 180)
				{
					grad = value;
				}
				else
				{
					Console.WriteLine("Это не целое число от 0 до 180");
				}
			}
			get
			{
				return grad;
			}
		}

		public int Min
		{
			set
			{
				if (value >= 0 && value <= 60)
				{
					min = value;
				}
				else
				{
					Console.WriteLine("Это не целое число от 0 до 60");
				}
			}
			get
			{
				return min;
			}
		}
		public int Sec
		{
			set
			{
				if (value >= 0 && value <= 60)
				{
					sec = value;
				}
				else
				{
					Console.WriteLine("Это не целое число от 0 до 60");
				}
			}
			get
			{
				return sec;
			}
		}

		public Angle()
		{
			Grad = grad;
			Min = min;
			Sec = sec;
		}

		public void ToRadians()
		{
			double Radian = (grad + (min + sec / 60) / 60) * Math.PI / 180;
			Console.WriteLine("Угол в радианах - {0:f2}", Radian);
		}
    }
}
