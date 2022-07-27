    Knight arus = new Knight("Arus", 23, "Knight");
	Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
    Ninja wedge = new Ninja("Wedge", 25, "Ninja");
    Wizard topapa = new Wizard("Topapa", 27, "Black Wizard");

	Console.WriteLine(arus.Attack()); 
	Console.WriteLine(wedge.Attack());
	Console.WriteLine(jennica.Attack(1));
	Console.WriteLine(jennica.Attack(7));
    Console.WriteLine(topapa.Attack(3));
    Console.ResetColor();