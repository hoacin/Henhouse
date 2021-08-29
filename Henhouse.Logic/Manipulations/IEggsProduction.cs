using Henhouse.Logic.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations
{
    public interface IEggsProduction
    {
        Task<bool> AddEggAsync(string chickenName, int weightInGrams, bool isWhite, DateTime creationTime);
        Task<IEnumerable<Egg>> GetAllEggsAsync(string chickenName);
    }
}
