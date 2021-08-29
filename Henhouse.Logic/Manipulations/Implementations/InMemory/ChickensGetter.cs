using Henhouse.Logic.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.InMemory
{
    internal static class ChickensGetter
    {
        public static Task<IEnumerable<Chicken>> RunAsync(List<Chicken> chickens)
        {
            return Task.FromResult<IEnumerable<Chicken>>(chickens.ToArray());
        }
    }
}
