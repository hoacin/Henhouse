using Henhouse.Logic.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore.Models
{
    public class EggModel
    {
        public int EggModelId { get; set; }
        public string ChickenName { get; set; } = string.Empty;
        public int WeightInGrams { get; set; }
        public bool IsWhite { get; set; }
        public DateTime CreationTime { get; set; }

        public Egg ToEgg() => new(ChickenName!, WeightInGrams, IsWhite, CreationTime);
    }
}
