using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public int id { get; set; }
        public int Userid { get; set; }
        public List<Ingredients> IngredientsList { get; set; }
        public List<Step> StepsList { get; set; }
    }
}
