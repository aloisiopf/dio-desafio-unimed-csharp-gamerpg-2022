public class Ninja : Hero {
     public Ninja(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;    
    }

    public override string Attack()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        return this.Name + " Lançou 1 Bomba";
    }


}