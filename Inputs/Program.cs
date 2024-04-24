//Console.WriteLine();
//#region IfElse


////Console.WriteLine("Ay istifadeci birinic ededi daxil ele");
////int number1 =int.Parse(Console.ReadLine());
////Console.WriteLine("Ay istifadeci ikinci ededi daxil ele");

////int number2 =int.Parse(Console.ReadLine());

//////scope
////if(number1 > number2)
////{
////	Console.WriteLine($"{number1} boyukdur");
////}
////else if (number1 == number2)
////{
////	Console.WriteLine("Beraberdir");
////}
////else
////{
////	Console.WriteLine($"{number2} boyukdur");
////}

//#endregion

//#region Ternary

//////ternary operator
////bool secim = false? false: true;	

//#endregion

//#region Switch case


////Console.WriteLine("1. Az dili");
////Console.WriteLine("2. Rus dili");
////Console.WriteLine("3. Ingilisdili");


////string secim = Console.ReadLine();

////// if else conditionun butun sertlerini yoxlayirdisa 
////// switch case secilmis conditiona bir basa dusur

//////case jumping
////switch (secim)
////{
////	case "1":
////		Console.WriteLine("Az dili");
////		break;
////	case "2":
////		Console.WriteLine("Rus dili");
////		break;
////	case "3":
////		Console.WriteLine("Ingilis dili");
////		break;
////		default: 
////		break;
////}
//#endregion
//#region AndOr
//// task 3 ededin en boyuyunu tapin

////Console.WriteLine("Birinci ededi daxil edin");
////int number1 = int.Parse(Console.ReadLine());
////Console.WriteLine("Birinci ededi daxil edin");
////int number2 = int.Parse(Console.ReadLine());
////Console.WriteLine("Birinci ededi daxil edin");
////int number3 = int.Parse(Console.ReadLine());

//// and 
//// or

////if(number1 > number2 && number1 > number3)
////{
////	Console.WriteLine($"{number1} boyukdur");
////}
////else if( number2 > number1 && number2 > number3)
////{
////	Console.WriteLine($"{number2} boyukdur");
////}
////else
////{
////	Console.WriteLine($"{number3} boyukdur");

////}
//#endregion

//#region Equality operators
////7311597
////string name = "Isa";
////			//10511597
////string name2 = "isa";
//// ==   deyerlerin bir birine beraberliyini yoxlayir
//// !=
////if(name.ToLower() != name2.ToLower())
////{
////	Console.WriteLine("eyni");
////}
////else
////{
////	Console.WriteLine("eyni deyil");
////};

//#endregion


// //arraylar birden cox datani saxlamaq ucun istifade olunur;
// //datalar eyni tipde olmalidir;
////int[] arr = new int[10];
////arr[0] = 10;
////arr[1] = 12;
////arr[9] = 22;


////for (int i = 0;i < arr.Length; i++)
////{
////	Console.WriteLine(arr[i]);
////}

////          c         b   a	
////foreach (var arrayinindexi in arr)
////{
////	Console.WriteLine(arrayinindexi);
////}



//bool choose = true;

//while (choose)
//{
//	Console.Clear();
//	Thread.Sleep(1000);

//	Console.WriteLine("1. Az dili");
//	Console.WriteLine("2. Rus dili");
//	Console.WriteLine("3. Ingilisdili");
//	Console.WriteLine("0. Cixis");

//	string secim = Console.ReadLine();

//	// if else conditionun butun sertlerini yoxlayirdisa 
//	// switch case secilmis conditiona bir basa dusur

//	switch (secim)
//	{
//		case "1":
//			Console.ForegroundColor = ConsoleColor.Green;
//			Console.WriteLine("Az dili");
//			break;
//		case "2":
//			Console.WriteLine("Rus dili");
//			break;
//		case "3":
//			Console.WriteLine("Ingilis dili");
//			break;
//		case "0":
//			choose = false;
//			break;
//		default:
//			Console.WriteLine("Secim dogru deyil");
//			break;
//	}

//}



