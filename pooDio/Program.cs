using pooDio.src.Entities;

Knight hero = new Knight("Arus", 25, "Knight");
WhiteWizard WhiteWizard = new WhiteWizard("Jenica", 23, "White Wizard");
Ninja ninja = new Ninja("Wedge", 24, "Ninja");
BlackWizard blackWizard = new BlackWizard("Topapa", 21, "Black Wizard");

Console.WriteLine("The party members are:");
Console.WriteLine(hero);
Console.WriteLine(WhiteWizard);
Console.WriteLine(ninja);
Console.WriteLine(blackWizard);
Console.WriteLine();

Console.WriteLine("And they are using their attacks! ");
Console.WriteLine();


Console.WriteLine(hero.Attack("sword"));
Console.WriteLine(WhiteWizard.Attack("magic"));
Console.WriteLine(ninja.Attack("shuriken"));
Console.WriteLine(blackWizard.Attack("black magic"));
Console.WriteLine();

Console.WriteLine(hero.Attack("sword", 20));
Console.WriteLine(WhiteWizard.Attack("magic", 9));
Console.WriteLine(ninja.Attack("shuriken", 27));
Console.WriteLine(blackWizard.Attack("black magic", 45));
Console.WriteLine();

Console.WriteLine("The party has won the battle!");
