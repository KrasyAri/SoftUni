using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string trainerName, int numberOfBadges, List<Pokemon> pokemonCollection)
        {
            TrainerName = trainerName;
            NumberOfBadges = numberOfBadges;
            PokemonCollection = pokemonCollection;
        }

        public string TrainerName { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> PokemonCollection { get; set; }

    }
}
