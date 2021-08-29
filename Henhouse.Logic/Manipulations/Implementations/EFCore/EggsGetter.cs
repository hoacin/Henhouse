using Henhouse.Logic.Manipulations.Implementations.EFCore.Models;
using Henhouse.Logic.Products;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore
{
    internal static class EggsGetter
    {
        public static Task<IEnumerable<Egg>> RunAsync(HenhouseDBContext dbContext, string chickenName)
        {
            IQueryable<EggModel> eggs = dbContext.Eggs.Where(egg => egg.ChickenName == chickenName);
            List<Egg> eggsToReturn = new();
            foreach (var egg in eggs)
                eggsToReturn.Add(egg.ToEgg());
            return Task.FromResult<IEnumerable<Egg>>(eggsToReturn.ToArray());
        }
    }
}
