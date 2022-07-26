public abstract class Hero {

    private string Name;
    private int Level;
    private string HeroType;

    public string GetName { get; set; }
    public int GetLevel { get; set; }
    public string getHeroType { get; set; }

    public Hero(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }

    public Hero() {}

    public virtual string Attack() {
        return this.Name + ", realizou o ataque com sua espada!";
    }

    public override string ToString()
    {
        return "Name: " + this.Name + "\n Level: " + this.Level + "\n Hero Type: " + this.HeroType;
    }
}