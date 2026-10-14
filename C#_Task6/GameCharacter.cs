using System;

abstract class GameCharacter
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _name = value;
            }
        }
    }

    private int _health;

    protected int Health
    {
        get { return _health; }
        set
        {
            if (value < 0)
            {
                _health = 0;
            }
            else if (value > 100)
            {
                _health = 100;
            }
            else
            {
                _health = value;
            }
        }
    }

    public int CurrentHealth
    {
        get { return Health; }
    }

    public GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void UseSpecialAbility();

    public virtual void TakeDamage(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Damage cannot be negative.");
            return;
        }

        Health -= amount;
        Console.WriteLine($"{Name} takes {amount} damage.");
    }

    public void Heal()
    {
        Health += 10;
        Console.WriteLine($"{Name} heals 10 points.");
        Console.WriteLine($"{Name}'s health: {Health}");
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Healing amount cannot be negative.");
            return;
        }

        Health += amount;
        Console.WriteLine($"{Name} heals {amount} points.");
        Console.WriteLine($"{Name}'s health: {Health}");
    }
}