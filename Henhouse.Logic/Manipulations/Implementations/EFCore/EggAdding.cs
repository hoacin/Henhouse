using Henhouse.Logic.Manipulations.Implementations.EFCore.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore
{
    internal static class EggAdding
    {
        public static async Task<bool> RunAsync(HenhouseDBContext dbContext, string chickenName, int weightInGrams, bool isWhite, DateTime creationTime)
        {
            ChickenModel? chicken = dbContext.Chickens.FirstOrDefault(chicken => chicken.Name == chickenName);
            if (chicken is null)
                return false;
            _ = dbContext.Eggs.Add(new EggModel(chickenName, weightInGrams, isWhite, creationTime));
            _ = await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
