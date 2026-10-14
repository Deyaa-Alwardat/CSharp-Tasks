
using System;

interface ICollectible
{
    void Collect();
}

class HealthPotion : ICollectible
{
    public string PotionName;

    public HealthPotion(string potionName)
    {
        PotionName = potionName;
    }

    public void Collect()
    {
        Console.WriteLine($"{PotionName} collected!");
    }

    public void Use(GameCharacter character, string amountText)
    {
        try
        {
            int amount = Convert.ToInt32(amountText);
            character.Heal(amount);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid input! Please enter a number.");
        }
    }
}
