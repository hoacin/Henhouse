using Henhouse.Logic.Animals;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.Mock
{
    internal static class ChickenCategory
    {
        public static Task<string> RunAsync(List<Chicken> chickens, string chickenName)
        {
            Chicken? chicken = chickens.FirstOrDefault(chicken => chicken.Name == chickenName);
            return Task.FromResult(chicken is null ? string.Empty : chicken.Category);
        }
    }
}
