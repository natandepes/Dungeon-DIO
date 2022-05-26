namespace src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType,int HPNow, int HPMax, int MPNow, int MPMax)
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
            return this.Name + "arremessou lâminas imprecisamente.";
        }

        public override string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + "arremesou kunais perfeitamente com bonus de +" + " " + Bonus;
            }else{
                return this.Name + "arremesou shurikens com um bom ângulo com bonus de +" + " " + Bonus;
            }
        }    
    }  
}