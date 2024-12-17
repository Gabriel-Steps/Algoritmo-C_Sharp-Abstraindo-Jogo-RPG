using projetoGFT.src.Entities;

Heroi heroi = new Heroi("Gabriel", 15, "Guerreiro");
Mago mago = new Mago("Gabriel Mago", 19, "Mago de Fogo");
Ninja ninja = new Ninja("Gabriel Ninja", 22, "Ninja dattebayo");

Console.WriteLine(heroi.Attack());
Console.WriteLine(mago.Attack());
Console.WriteLine(ninja.Attack());

//Ataques com bônus
Console.WriteLine(heroi.Attack(7));
Console.WriteLine(mago.Attack(2));
Console.WriteLine(ninja.Attack(9));