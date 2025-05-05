namespace ConsoleApp1.Recipes
{
    
        public abstract class Flour : Ingredients
        {
            public override string Instruction => $"Sieve.{base.Instruction}";
        }
    
}
