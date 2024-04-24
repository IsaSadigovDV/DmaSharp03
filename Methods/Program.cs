Console.WriteLine();
// public private -> access modifier

// [access modifier][return type][name](){}




#region return type-i olmayan ve parametr teleb etmeyen

//SayHello();
//SayHello();
//SayHello();
//SayHello();


//void SayHello()
//{
//	Console.WriteLine("Zehmet olmasa adinizi daxil eden");
//	string name = Console.ReadLine();

//	Console.WriteLine($"Sizin adini {name}. Sehifemize xos gelmisiz");
//}


#endregion
#region return type-i olmayan ve parametr teleb eden

//SayHello("asd");
//void SayHello(string name)
//{
//	Console.WriteLine($"Sizin adini {name}. Sehifemize xos gelmisiz");
//}

#endregion
#region return type-i olan ve parametr teleb etmeyen

//Console.WriteLine(Sum());
//int Sum()
//{
//	int reqem1 = int.Parse(Console.ReadLine());
//	int reqem2 = int.Parse(Console.ReadLine());
//	int result = reqem1+ reqem2;
//	return result ;
//}

#endregion
#region return type-i olan ve parametr teleb eden

//Metodlara default deyer vererken sol terefdeki deyisenlere vermeliyik sag teref
//ise default deyer versek de olar vermesek de, lakin default deyer verendern sonra
// ortada biz deyisen teyin edib deyer vermemek olmaz
//Console.WriteLine(Sum(1));
//int Sum(int c, int a =1, int b = 2)
//{
//	return a+b;
//}
#endregion


