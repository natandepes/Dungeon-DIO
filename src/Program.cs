using src.Entities;

namespace RPG{

    class Program{
        
        static void Main(string[] args){
            Knight arus = new Knight("Arus", 42, "Knight", 469, 749, 72, 72);
            Wizard jennica = new Wizard("Jenica", 42, "White Wizard", 325, 601, 474, 482);
            BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard", 106, 385, 611, 641);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 292, 574, 89, 89);
             
            
            //Console.WriteLine(hero); //toda vez que voce tenta escrever um objeto o console
            // automaticamente usa o ToString, metodo padrao que eu dei override na classe abstrata Hero
            
            // Apresentando as características e atacando como Arus(Knight)
            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(arus.Attack(4));
            Console.WriteLine(arus.Attack(7));
            
            // Apresentando as características e atacando como Jenica(White Wizard)
            Console.WriteLine(); // pulando uma linha para ficar mais legível
            Console.WriteLine(jennica);
            Console.WriteLine(jennica.Attack());
            Console.WriteLine(jennica.Attack(4));
            Console.WriteLine(jennica.Attack(7));
            
            // Apresentando as características e atacando como Topapa(Black Wizard)
            Console.WriteLine(); // pulando uma linha para ficar mais legível
            Console.WriteLine(topapa);
            Console.WriteLine(topapa.Attack());
            Console.WriteLine(topapa.Attack(4));
            Console.WriteLine(topapa.Attack(7));
            
            // Apresentando as características e atacando como Wedge(Ninja)
            Console.WriteLine(); // pulando uma linha para ficar mais legível
            Console.WriteLine(wedge);
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(wedge.Attack(4));
            Console.WriteLine(wedge.Attack(7));



        }
    }
}
