
using System;
using System.Collections.Generic;

namespace C__Task6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("===== ADVENTURE GAME =====");
            Console.WriteLine();

            Warrior warrior = new Warrior("Alex", 80);
            Wizard wizard = new Wizard("Luna", 70);

            Console.WriteLine($"Warrior {warrior.Name} enters the game!");
            Console.WriteLine();

            Console.WriteLine($"Wizard {wizard.Name} enters the game!");
            Console.WriteLine();

            List<GameCharacter> characters = new List<GameCharacter>
            {
                warrior,
                wizard
            };

            foreach (GameCharacter character in characters)
            {
                character.UseSpecialAbility();
            }

            Console.WriteLine();

            warrior.TakeDamage(10);
            Console.WriteLine($"{warrior.Name}'s health: {warrior.CurrentHealth}");
            Console.WriteLine();

            wizard.TakeDamage(10);
            Console.WriteLine($"{wizard.Name}'s health: {wizard.CurrentHealth}");
            Console.WriteLine();

            warrior.Heal();
            Console.WriteLine();

            warrior.Heal(15);
            Console.WriteLine();

            HealthPotion potion = new HealthPotion("Health Potion");
            potion.Collect();
            Console.WriteLine();

            potion.Use(wizard, "15");
            Console.WriteLine();

            potion.Use(wizard, "abc");
        }
    }
}
