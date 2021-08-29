using Henhouse.Logic.Animals;
using Henhouse.Logic.Products;
using System;
using System.Collections.Generic;
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

        //Chickens
        public Task<bool> AddChickenAsync(string chickenName, string category) => ChickenAdding.RunAsync(_dbContext, chickenName, category);
        public Task<IEnumerable<Chicken>> GetAllChickensAsync() => ChickensGetter.RunAsync(_dbContext);
        public Task<string> GetChickenCategoryAsync(string chickenName) => ChickenCategory.RunAsync(_dbContext, chickenName);
        public Task<bool> RemoveChickenAsync(string chickenName) => ChickenRemoving.RunAsync(_dbContext, chickenName);
        //Eggs
        public Task<IEnumerable<Egg>> GetAllEggsAsync(string chickenName) => EggsGetter.RunAsync(_dbContext, chickenName);
        public Task<bool> AddEggAsync(string chickenName, int weightInGrams, bool isWhite, DateTime creationTime)
            => EggAdding.RunAsync(_dbContext, chickenName, weightInGrams, isWhite, creationTime);

    }
}
