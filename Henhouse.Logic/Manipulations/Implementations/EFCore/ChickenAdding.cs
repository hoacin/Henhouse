using Henhouse.Logic.Manipulations.Implementations.EFCore.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore
{
    internal static class ChickenAdding
    {
        public static async Task<bool> RunAsync(HenhouseDBContext dbContext, string chickenName, string category)
        {
            if (dbContext.Chickens.Any(chicken => chicken.Name == chickenName))
                return false;
            _ = dbContext.Chickens.Add(new ChickenModel(chickenName, category));
            _ = await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
