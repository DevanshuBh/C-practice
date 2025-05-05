using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredients> Ingredients { get; }

        public Recipe(IEnumerable<Ingredients> ingredients)
        {
            Ingredients = ingredients;

        }

        public override string ToString()
        {
            var steps = new List<string>();
            foreach(var ingredients in Ingredients)
            {
                steps.Add($"{ingredients.Name}. {ingredients.Instruction}");
            }

            return string.Join(Environment.NewLine, steps);
        }
    }
}
