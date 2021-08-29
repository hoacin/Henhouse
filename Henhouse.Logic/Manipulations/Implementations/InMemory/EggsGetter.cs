using Henhouse.Logic.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.InMemory
{
    internal static class EggsGetter
    {
        public static Task<IEnumerable<Egg>> RunAsync(List<Egg> eggs, string chickenName)
        {
            return Task.FromResult(eggs.Where(egg => egg.ChickenName == chickenName));
        }
    }
}
