//using Oop_Part1.Entities;
//// type  variabler   value
//  int    num =        5;
////type  variable    instance
////Car audi = new Car();
////audi.Name = "Audi";

////Car bmw = new Car();
////bmw.Name = "Bmw";


//Teacher teacher = new Teacher("Isa", "Sadigov");
//Console.WriteLine($"{teacher.Name} // {teacher.Surname}");

using Oop_Part1.Entities;

Circle circle = new Circle();

while (true)
{

	try
	{
		Console.WriteLine(circle.Calculate());
	}
	catch (Exception)
	{
		Console.WriteLine("Zehmet olmasa duzgun format daxil edin");
	}
}