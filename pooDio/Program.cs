using pooDio.src.Entities;

Knight hero = new Knight("Arus", 12, "Knight");
Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

Console.WriteLine(hero.Attack("sword"));
Console.WriteLine(wizard.Attack("magic"));
Console.WriteLine();

Console.WriteLine(hero.Attack("sword", 20));
Console.WriteLine(wizard.Attack("magic", 37));
