using Henhouse.Logic.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.InMemory
{
    internal static class ChickenAdding
    {
        public static Task<bool> RunAsync(List<Chicken> chickens, string chickenName, string category)
        {
            if (chickens.Any(chicken => chicken.Name == chickenName))
                return Task.FromResult(false);
            chickens.Add(new Chicken(chickenName, category));
            return Task.FromResult(true);
        }
    }
}
