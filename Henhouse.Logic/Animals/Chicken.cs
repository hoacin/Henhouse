using System.ComponentModel.DataAnnotations;

namespace Henhouse.Logic.Animals
{
    public class Chicken
    {
        [Required]
        public string Name { get; }
        [Required]
        public string Category { get; }

        public Chicken(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }
}
