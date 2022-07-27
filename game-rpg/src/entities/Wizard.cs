public class Wizard : Hero {
    public Wizard(string Name, int Level, string HeroType){
		this.Name = Name;
		this.Level = Level;
		this.HeroType = HeroType;
	}

    //Sobrescrevendo o método Attack
	public override string Attack(){
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		return this.Name + " Lançou Magia";
	}

	public string Attack(int Bonus){

		if (Bonus > 6){
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			return this.Name + " Lançou Magia super com bônus de ataque de " + Bonus;
		} else {
			Console.ForegroundColor = ConsoleColor.Magenta;
			return this.Name + " Lançou Magia com força fraca com bônus de ataque de " + Bonus;
		}
	}
}