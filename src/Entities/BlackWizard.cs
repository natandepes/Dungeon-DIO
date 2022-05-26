namespace src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType,int HPNow, int HPMax, int MPNow, int MPMax)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HPNow = HPNow;
            this.HPMax = HPMax;
            this.MPNow = MPNow;
            this.MPMax = MPMax;
        }

        public override string Attack(){ 
            return this.Name + " " + "usou uma magia meramente obscura.";
        }

        public override string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name + " " + "usou uma magia das trevas profundas com bonus de +" + " " + Bonus;
            }else{
                return this.Name + " " + "usou uma magia obscura com bonus de +" + " " + Bonus;
            }
            
        }

    }
}