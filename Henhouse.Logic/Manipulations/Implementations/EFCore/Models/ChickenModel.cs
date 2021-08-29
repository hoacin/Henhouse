using Henhouse.Logic.Animals;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore.Models
{
    public class ChickenModel
    {
        public int ChickenModelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        public ChickenModel()
        {
        }
        public ChickenModel(string chickenName, string category)
        {
            Name = chickenName;
            Category = category;
        }

        public Chicken ToChicken() => new(Name!, Category!);
    }
}
