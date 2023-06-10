using abstraindo_RPG_dotnet.src.Entities;

class Program
{
    static void Main (string[] args)
    {
        //Arus hero = new Arus();
        //hero.Name = "Arus";
        //hero.level = 3;
        //hero.HeroType = "Knight";

        //Hero hero = new Hero("Arus", 35, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "White Mage");
        Knight arus = new Knight("Arus", 35, "Knight");
        //Console.WriteLine(hero.ToString());
        Console.WriteLine(wizard.Attack());
    } 
}
