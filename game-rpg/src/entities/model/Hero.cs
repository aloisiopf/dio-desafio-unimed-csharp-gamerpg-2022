public abstract class Hero {

    private string _Name = "";
    private int _Level = 1;
    private string _HeroType = "";

    //Denife the initial value of life
    private int _HP = 10;

    private int _HPNow;

    //Define the initial value of power
    private int _MP = 10;
    private int _MPNow;

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
        this._HPNow = this.HP;
        this._MPNow = this.MP;
    }

    public Hero(string Name, int Level, string HeroType, int HP, int MP)
    {
        this._Name = Name;
        this._Level = Level;
        this._HeroType = HeroType;
        this._HP = HP;
        this._MP = MP;
        this._HPNow = this.HP;
        this._MPNow = this.MP;
    }

    public Hero() {}

    public virtual string Attack() {
        return this._Name + " realizou o ataque com sua espada!";
    }

    public override string ToString()
    {
        return $"Name: {this.Name}, Level: {this.Level}, Hero Tpye: {this.HeroType}, " 
        + $" Heart Power: {this._HPNow} / {this._HP}, Magic Power: {this._MPNow} / {this._MP}";
    }

    public virtual string UpdateStatusHero (int HP, int MP, Boolean UPLevel){
        if (UPLevel) {
            this._Level++;
            this._HP += HP;
            this._HPNow = this._HP;
            this._MP += MP;
            this._MPNow = this._MP;
            
        } else {
            this._HPNow -= HP;
            this._MPNow -= MP;
        }
        return $"Name: {this.Name} teve o seu status de força {this._HPNow} e magia {this._MPNow} atualizados!";
    }
    
}