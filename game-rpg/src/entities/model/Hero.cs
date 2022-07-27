public abstract class Hero {

    private string _Name = "";
    private int _Level = 1;
    private string _HeroType = "";

    //Denife the initial value of life
    private int _HP = 10;

    //Define the initial value of power
    private int _MP = 10;

    public string Name { get => _Name; set => _Name = value; }
    public int Level { get => _Level; set => _Level = value; }
    public string HeroType { get => _HeroType; set => _HeroType = value; }

    public int HP { get => _HP; set => _HP = value; }

    public int MP { get => _MP; set => _MP = value; }

    public Hero(string Name, int Level, string HeroType)
    {
        this._Name = Name;
        this._Level = Level;
        this._HeroType = HeroType;
    }

    public Hero() {}

    public virtual string Attack() {
        return this._Name + " realizou o ataque com sua espada!";
    }

    public override string ToString()
    {
        return "Name: " + this._Name + "\n Level: " + this._Level + "\n Hero Type: " + this._HeroType;
    }
    
}