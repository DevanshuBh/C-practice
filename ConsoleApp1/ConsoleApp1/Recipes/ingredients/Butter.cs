namespace ConsoleApp1.Recipes
{
   
        public class Butter : Ingredients
        {
            public override int Id => 3;

            public override string Name => "Butter";

            public override string Instruction => $"Melt in low heat . {base.Instruction}";
        }
    
}
