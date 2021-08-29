using Henhouse.Logic.Animals;
using Henhouse.Logic.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.InMemory
{
    internal static class ChickenRemoving
    {
        public static Task<bool> RunAsync(List<Chicken> chickens, List<Egg> eggs, string chickenName)
        {
            Chicken? chicken = chickens.FirstOrDefault(chicken => chicken.Name == chickenName);
            if (chicken is null)
                return Task.FromResult(false);
            _ = chickens.Remove(chicken);
            _ = eggs.RemoveAll(egg => egg.ChickenName == chickenName);
            return Task.FromResult(true);
        }
    }
}
