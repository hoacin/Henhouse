using Henhouse.Logic.Animals;
using Henhouse.Logic.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.Mock
{
    internal static class EggAdding
    {
        public static Task<bool> RunAsync(List<Chicken> chickens, List<Egg> eggs, string chickenName, int weightInGrams, bool isWhite, DateTime creationTime)
        {
            Chicken? chicken = chickens.FirstOrDefault(chicken => chicken.Name == chickenName);
            if (chicken is null)
                return Task.FromResult(false);
            eggs.Add(new Egg(chickenName, weightInGrams, isWhite, creationTime));
            return Task.FromResult(true);
        }
    }
}
