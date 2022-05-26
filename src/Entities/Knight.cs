namespace src.Entities
{
    public class Knight : Hero
    {
        
        public Knight(string Name, int Level, string HeroType,int HPNow, int HPMax, int MPNow, int MPMax)
        {   
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HPNow = HPNow;
            this.HPMax = HPMax;
            this.MPNow = MPNow;
            this.MPMax = MPMax;
        }

    }
}