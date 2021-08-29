using Henhouse.Logic.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations
{
    public interface IChickenTeam
    {
        Task<bool> AddChickenAsync(string chickenName, string category);
        Task<bool> RemoveChickenAsync(string chickenName);
        Task<IEnumerable<Chicken>> GetAllChickensAsync();
        Task<string> GetChickenCategoryAsync(string chickenName);
    }
}
