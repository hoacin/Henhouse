using Henhouse.Logic.Manipulations.Implementations.EFCore.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore
{
    internal static class ChickenCategory
    {
        public static Task<string> RunAsync(HenhouseDBContext dbContext, string chickenName)
        {
            ChickenModel? chicken = dbContext.Chickens.FirstOrDefault(chicken => chicken.Name == chickenName);
            return Task.FromResult(chicken is null ? string.Empty : chicken.Category);
        }
    }
}
