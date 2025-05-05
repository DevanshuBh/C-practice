namespace ConsoleApp1.Recipes
{
    
    
        public abstract class Ingredients
        {
            public abstract int Id { get; }

            public abstract string Name { get; }

            public virtual string Instruction => "Add to other ingredients";
        }
    
}
