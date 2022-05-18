// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.WriteLine("Välkommen till Huvudmenyn");
Console.WriteLine("Tryck (1) Ungdom eller pensionär");
Console.WriteLine("Tryck (2) Räkna ut pris för sällskap");
Console.WriteLine("Tryck (3) ");
Console.WriteLine("Tryck (4) Avsluta program");


do
{
	//int menyVal = int.Parse(Console.ReadLine());
	int menyVal = int.TryParse(Console.ReadLine());																						

	switch (menyVal)
	{
		case 1:
			Console.WriteLine("Ungdom eller pensionär 1");
			//UngEllerPensioner();
			break;
		case 2:
			Console.WriteLine("Räkna ut pris för sällskap 2");
			//SallskapPris();
			break;
		case 3:
			Console.WriteLine("3 ordet 3");
			break;
		case 4:
			Console.WriteLine("Avsluta program 4");
			Environment.Exit(0);
			break;
		default:
			break;
			// varför funkar inte break med 0
			//Hur skapa felaktigt input tryparse

	}
}
while (true);	