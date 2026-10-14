using System;

class Wizard : GameCharacter
{
    public Wizard(string name, int health) : base(name, health)
    {
    }

    public override void UseSpecialAbility()
    {
        Console.WriteLine("The Wizard uses magic!");
    }
}