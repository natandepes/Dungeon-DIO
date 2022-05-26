namespace src.Entities
{
    public abstract class Hero // o termo abstract serve exatamente para esta classe servir como uma classe mae, ela serve para somente ser entao herdada.
    {

        public Hero() //comentei pois achei a funcionalidade do construtor vazio interessante, serve para nao obrigar a classe declarar parametros quando for citada
        {
            
        }

        public Hero(string Name, int Level, string HeroType,int HPNow, int HPMax, int MPNow, int MPMax)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HPNow = HPNow;
            this.HPMax = HPMax;
            this.MPNow = MPNow;
            this.MPMax = MPMax;
            
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public string HeroType { get; set; }

        public int HPMax { get; set; }

        public int HPNow { get; set; }

        public int MPMax { get; set; }

        public int MPNow { get; set; }


        public override string ToString(){
            return "Nome: " + this.Name + " " + " " + " " + "Level: " + this.Level + " " + " " + " " +  "Classe: " + this.HeroType + " " + " " + " " + "Vida atual: " + this.HPNow + " " + " " + "Vida máxima: " + this.HPMax + " " + " " + " " + "Mana atual: " + this.MPNow + " " + " " + " " + "Mana máxima: " + this.MPMax;
        }

        public virtual string Attack(){ // o virtual da permissao para que classes filhas sobrescrevam este metodo
            return this.Name + " " + "atacou levemente com a sua espada.";
        }

        public virtual string Attack(int Bonus){ // o virtual da permissao para que classes filhas sobrescrevam este metodo
            if(Bonus > 6){
                return this.Name + " " + "atacou com a sua espada proficientemente com bonus de +" +" "+ Bonus;
            }else{
                return this.Name + " " + "atacou com a sua espada moderadamente com bonus de +" +" "+ Bonus;
            }
        }

    }
}