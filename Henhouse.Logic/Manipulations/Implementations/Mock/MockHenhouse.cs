using Henhouse.Logic.Animals;
using Henhouse.Logic.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.Mock
{
    public class MockHenhouse : IHenhouse
    {
        private readonly List<Chicken> _chickens = new();
        private readonly List<Egg> _eggs = new();

        //Chickens
        public Task<bool> AddChickenAsync(string chickenName, string category) => ChickenAdding.RunAsync(_chickens, chickenName, category);
        public Task<IEnumerable<Chicken>> GetAllChickensAsync() => ChickensGetter.RunAsync(_chickens);
        public Task<bool> RemoveChickenAsync(string chickenName) => ChickenRemoving.RunAsync(_chickens, _eggs, chickenName);
        public Task<string> GetChickenCategoryAsync(string chickenName) => ChickenCategory.RunAsync(_chickens, chickenName);
        //Eggs
        public Task<bool> AddEggAsync(string chickenName, int weightInGrams, bool isWhite, DateTime creationTime)
            => EggAdding.RunAsync(_chickens, _eggs, chickenName, weightInGrams, isWhite, creationTime);
        public Task<IEnumerable<Egg>> GetAllEggsAsync(string chickenName) => EggsGetter.RunAsync(_eggs, chickenName);
    }
}
