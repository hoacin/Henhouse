using System;
using System.ComponentModel.DataAnnotations;

namespace Henhouse.Logic.Products
{
    public class Egg
    {
        [Required]
        public string ChickenName { get; }
        [Required]
        public int WeightInGrams { get; }
        [Required]
        public bool IsWhite { get; }
        [Required]
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
