using Pokemon_Challange;

//(string name, string type, int hitpoints, string weakness)
Pokemon pikachu = new Pokemon("pikachu ","electric",60,"Fighting");

Pokemon squirtle = new Pokemon("squirtle ", "water", 70, "Electric");

Pokemon Charmander = new Pokemon("Charmander ", "fire ", 60, "water");

Pokemon Bulbasaur = new Pokemon("Bulbasaur ", "Grass", 70, "Fire");

Pokemon Rockruff = new Pokemon("Rockruff ", "Fighting", 60, "Grass");

Console.WriteLine("which pokemon do you want to know about ");

string name = Console.ReadLine();

if  (name == "pikachu")
{
    Console.WriteLine(pikachu.name + " has a element of " + pikachu.type + " their power is " + pikachu.hitpoints + " the weakness of this pokemon is " + pikachu.weakness);
}
if (name == "squirtle")
{
    Console.WriteLine(squirtle.name + " has a element of " + squirtle.type + " their power is " + squirtle.hitpoints + " the weakness of this pokemon is " + squirtle.weakness);
}
if (name == "Charmander")
{
    Console.WriteLine(Charmander.name + " has a element of " + Charmander.type + " their power is " + Charmander.hitpoints + " the weakness of this pokemon is " + Charmander.weakness);
}
if (name == "Bulbasaur")
{
    Console.WriteLine(Bulbasaur.name + " has a element of " + Bulbasaur.type + " their power is " + Bulbasaur.hitpoints + " the weakness of this pokemon is " + Bulbasaur.weakness);
}
if (name == "Rockruff")
{
    Console.WriteLine(Rockruff.name + " has a element of " + Rockruff.type + " their power is " + Rockruff.hitpoints + " the weakness of this pokemon is " + Rockruff.weakness);
}
