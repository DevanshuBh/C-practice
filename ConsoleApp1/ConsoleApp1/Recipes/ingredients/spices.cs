namespace ConsoleApp1.Recipes
{
   
    
        public abstract class spices : Ingredients
        {
            public override string Instruction => $"Take half a teaspoon. {base.Instruction}";
        }
    
}
