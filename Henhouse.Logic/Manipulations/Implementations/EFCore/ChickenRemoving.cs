using Henhouse.Logic.Manipulations.Implementations.EFCore.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore
{
    internal static class ChickenRemoving
    {
        public static async Task<bool> RunAsync(HenhouseDBContext dbContext, string chickenName)
        {
            ChickenModel? chicken = dbContext.Chickens.FirstOrDefault(chicken => chicken.Name == chickenName);
            if (chicken is null)
                return false;
            _ = dbContext.Chickens.Remove(chicken);
            dbContext.Eggs.RemoveRange(dbContext.Eggs.Where(egg => egg.ChickenName == chickenName));
            _ = await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
