using System;

class Warrior : GameCharacter
{

    public Warrior(string name, int health) : base(name, health)
    {
    }

    public override void UseSpecialAbility()
    {
        Console.WriteLine("The Warrior attacks with a sword!");
    }

    public override void TakeDamage(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Damage cannot be negative.");
            return;
        }

        int actualDamage;

        if (amount > 2)
        {
            actualDamage = amount - 2;
        }
        else
        {
            actualDamage = 0;
        }

        Health -= actualDamage;

        Console.WriteLine($"{Name} takes {actualDamage} damage.");
    }
}