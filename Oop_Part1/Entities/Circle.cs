using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Part1.Entities
{
	internal class Circle
	{
		public const double Pi = Math.PI;
		public double R;


		public double Calculate()
		{
			Console.WriteLine("Radius:");
			double r = double.Parse(Console.ReadLine());
			return r * r * Pi;
		}
	}
}
