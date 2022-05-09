using System;
using System.Collections.Generic;

namespace MunchersandMidgets
{
    public class Entity
    {
        Dictionary<string, int> abilityScores = new Dictionary<string, int>(); //ett dictionary som lagrar AS med hjälp av stringen som key. och sedan lagrar numerära värdet. exempel "strenght" löser ut värdet 17

        Random generator = new Random();

        public Entity() //en konstruktor som körs när en entitet skapas, den lagrar alla stats i en array och sedan andvänder den arrayen för en foreach loop som slumpar stats mellan 5-20 för varje respektive ability score. 
        {
            string[] scoreNames = { "Strength", "Intelligence", "Charisma", "Dexterity", "Constitution", "Wisdom" };

            foreach (string scoreName in scoreNames)
            {                                                                                                                                                                           
                abilityScores.Add(scoreName, generator.Next(5, 21));

            }
        }
        public void PrintAS() //funktion som kan kallas som skriver ut entitetens ability scores.
        {

            System.Console.WriteLine($"Strenght: {abilityScores["Strength"]}\nDexterity: {abilityScores["Dexterity"]}\nConstitution: {abilityScores["Constitution"]}\nIntelligence: {abilityScores["Intelligence"]}\nWisdom: {abilityScores["Wisdom"]}\nCharisma: {abilityScores["Charisma"]}\n");
        }
    }
}