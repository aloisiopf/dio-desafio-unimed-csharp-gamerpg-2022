
public class Knight : Hero {
    
    public Knight(string Name, int Level, string HeroType) {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }

    /*
    * Construtor refatorado para usar repassar os dados
    * recebidos para a classe mãe onde será inicializado os
    * valores da força (HP) e magia (MP) do Hero
    */
    public Knight(string Name, int Level, string HeroType, int HP, int MP) : base (Name, Level, HeroType, HP, MP){
        
    }
    
}