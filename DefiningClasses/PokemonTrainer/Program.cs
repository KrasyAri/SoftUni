using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            List<Pokemon> pokemons = new List<Pokemon>();
            int numOfBadges = 0;

            while (input != "Tournament")
            {
                string[] splited = input.Split();
                string trainName = splited[0];
                string pokemonName = splited[1];
                string element = splited[2];
                int health = int.Parse(splited[3]);
               
                Pokemon pokemon = new Pokemon(pokemonName, element, health);
                Trainer trainer = new Trainer(trainName, numOfBadges, new List<Pokemon>() { pokemon});

                if (!trainers.ContainsKey(trainName))
                {
                    pokemons.Add(pokemon);
                    trainers.Add(trainName, trainer);
                }
                else
                {
                    trainers[trainName].PokemonCollection.Add(pokemon);
                }
                
                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.PokemonCollection.Any(p => p.Element == command))
                    {
                        trainer.Value.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.PokemonCollection)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Value.PokemonCollection = trainer.Value.PokemonCollection.Where(p => p.Health > 0).ToList();
                    }
                }

                command = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(x => x.Value.NumberOfBadges).ToDictionary(a => a.Key, b => b.Value);

            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.PokemonCollection.Count}");
            }
        }
    }
}
