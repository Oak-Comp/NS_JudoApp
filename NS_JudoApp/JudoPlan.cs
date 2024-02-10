using System.Numerics;

namespace NS_JudoApp
{
    public class JudoPlan
    {
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        public string ToString()
        {
            return $"{Name}  £{Price:##.##}";
        }
    }
}
