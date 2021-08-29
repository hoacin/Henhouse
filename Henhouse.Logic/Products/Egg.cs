using System;

namespace Henhouse.Logic.Products
{
    public class Egg
    {
        public string ChickenName { get; }
        public int WeightInGrams { get; }
        public bool IsWhite { get; }
        public DateTime CreationTime { get; }

        public Egg(string chickenName, int weightInGrams, bool isWhite, DateTime creationTime)
        {
            ChickenName = chickenName;
            WeightInGrams = weightInGrams;
            IsWhite = isWhite;
            CreationTime = creationTime;
        }
    }
}
