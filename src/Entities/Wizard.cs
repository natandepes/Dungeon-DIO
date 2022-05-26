namespace src.Entities{

    public class Wizard : Hero{

        public Wizard(string Name, int Level, string HeroType,int HPNow, int HPMax, int MPNow, int MPMax)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HPNow = HPNow;
            this.HPMax = HPMax;
            this.MPNow = MPNow;
            this.MPMax = MPMax;
        }
        
        public override string Attack(){ // o virtual da permissao para que classes filhas sobrescrevam este metodo
            return this.Name + " " + "usou uma magia fraca.";
        }

        public override string Attack(int Bonus){ // o virtual da permissao para que classes filhas sobrescrevam este metodo

            if(Bonus > 6){
                return this.Name + " " + "usou uma magia super efetiva com bonus de +" + " " + Bonus;
            }else{
                return this.Name + " " + "usou uma magia regular com bonus de +" + " " + Bonus;
            }
            
        }


    }
}