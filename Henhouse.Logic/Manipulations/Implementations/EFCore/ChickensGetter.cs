using Henhouse.Logic.Animals;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore
{
    internal static class ChickensGetter
    {
        public static Task<IEnumerable<Chicken>> RunAsync(HenhouseDBContext dbContext)
        {
            List<Chicken> chickens = new();
            foreach (var chicken in dbContext.Chickens)
                chickens.Add(chicken.ToChicken());
            return Task.FromResult<IEnumerable<Chicken>>(chickens.ToArray());
        }
    }
}
