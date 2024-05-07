using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.DTO
{
    public abstract class AAnimal
    {
        public string? SuperFamily { get; set; }
        public string? Name { get; set; }
        public string? Breed { get; set; }
        public float? Weight { get; set; }
        public AAnimal(string? name, string? breed, float? weight)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
        }
        
        public abstract int CalcGA(double GA, int x) ;
    }
}
