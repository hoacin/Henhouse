using Henhouse.Logic.Animals;
using Henhouse.Logic.Manipulations.Implementations.EFCore.Models;
using Henhouse.Logic.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore
{
    public class EFCoreHenhouse : IHenhouse
    {
        private readonly HenhouseDBContext _dbContext;

        public EFCoreHenhouse(string connectionsString)
        {
            _dbContext = new HenhouseDBContext(connectionsString);
        }
        public async Task<bool> AddChickenAsync(string chickenName, string category)
        {
            if (_dbContext.Chickens!.Any(chicken => chicken.Name == chickenName))
                return false;
            _ = _dbContext.Chickens!.Add(new ChickenModel(chickenName, category));
            _ = await _dbContext.SaveChangesAsync();
            return true;
        }

        public Task<bool> AddEggAsync(string chickenName, int weightInGrams, bool isWhite, DateTime creationTime)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Chicken>> GetAllChickensAsync()
        {
            List<Chicken> chickens = new();
            foreach (var chicken in _dbContext.Chickens!)
                chickens.Add(new Chicken(chicken.Name!, chicken.Category!));
            return Task.FromResult<IEnumerable<Chicken>>(chickens.ToArray());
        }

        public Task<IEnumerable<Egg>> GetAllEggsAsync(string chickenName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetChickenCategoryAsync(string chickenName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveChickenAsync(string chickenName)
        {
            throw new NotImplementedException();
        }
    }
}
