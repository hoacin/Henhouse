using Henhouse.Logic.Animals;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.Mock
{
    internal static class ChickensGetter
    {
        public static Task<IEnumerable<Chicken>> RunAsync(List<Chicken> chickens)
        {
            return Task.FromResult<IEnumerable<Chicken>>(chickens.ToArray());
        }
    }
}
