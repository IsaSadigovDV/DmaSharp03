using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Part1.Entities
{
	public class Teacher:Person
	{
		public double Salary { get; set; }
		public const double Pi = Math.PI;

		//constructor nedir? Biz ne zamanki objectden instacne aliriq ilk ishe dushen
		//constructor-dir

		public Teacher()
		{

		}
		public Teacher(string name)
		{
			this.Name = name;
		}

		public Teacher(string name, string surname) 
		{
			this.Name = name;
			this.Surname = surname;
		}


		//overloading -> eyni adli metodun muxtelif parametrlerle istifadesi
	}
}



