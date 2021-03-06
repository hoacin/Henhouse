using Henhouse.Logic.Products;
using System;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore.Models
{
    public class EggModel
    {
        public int EggModelId { get; set; }
        public string ChickenName { get; set; } = string.Empty;
        public int WeightInGrams { get; set; }
        public bool IsWhite { get; set; }
        public DateTime CreationTime { get; set; }

        public EggModel(string chickenName, int weightInGrams, bool isWhite, DateTime creationTime)
        {
            ChickenName = chickenName;
            WeightInGrams = weightInGrams;
            IsWhite = isWhite;
            CreationTime = creationTime;
        }
        public EggModel()
        {
        }
        public Egg ToEgg() => new(ChickenName, WeightInGrams, IsWhite, CreationTime);
    }
}
