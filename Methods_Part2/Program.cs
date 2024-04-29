////Console.WriteLine();



////Console.WriteLine(SumNumbers(1,2,5)); ;

////int SumNumbers(params int[] nums)
////{
////	int sum = 0;
////	foreach (var item in nums)
////	{
////		sum+= item;
////	}
////	return sum;
////}


////deep copy
//int a = 5;
//int b =  a;
//////Console.WriteLine("Deep copy");

//Console.WriteLine(b);
//Console.WriteLine(a);
////shallow copy
////Console.WriteLine("Shallow copy");
//b -= 2;
//Console.WriteLine(b);
//Console.WriteLine(a);








//int reqem = 5;
//// in keyword = 

//int Sum(in int deyisen)
//{
//	int a = deyisen + 1;
//	return a;
//}


//out
//string name = "asdas";

//getName(out name);
//string getName(out string name)
//{
//	name = "Asd";
//	return name;
//}

//bool res;
//int a;
//res = int.TryParse(Console.ReadLine(), out a);

//if(res == true)
//{
//	Console.WriteLine($"Sizin yasiniz {2024-a}");
//}
//else
//{
//	Console.WriteLine("Qardas zehmet olmasa reqem daxil ele");
//}
//Console.WriteLine(res);


//try
//{
//	Console.WriteLine("Yasiniz");
//	int age = int.Parse(Console.ReadLine());
//	Console.WriteLine(age);

//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//}




//->subhan, mehemmed, kenan, nurlan

//Console.WriteLine("Task 1. Print the numbers which are between two values.");

//static void PrintNumbers()
//{
//    int[] range = { 2, 4, 1, 8, 34, 21, 98, 12 };
//    Console.WriteLine("Please enter lowborder for the array:");
//    int lowborder = int.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter upborder for the array:");
//    int upborder = int.Parse(Console.ReadLine());
//    int l_index = 1;
//    int u_index = 1;
//	var updatedlist = new List<int>();

//	for (int i = 0; i < range.Length; i++)
//    {
//        if (range[i] >= lowborder && range[i] <= upborder)
//        {
//            updatedlist.Add(range[i]);
//        }
//    }
//    foreach (var item in updatedlist)
//    {
//        Console.Write(item + " ");
//    }

//}



