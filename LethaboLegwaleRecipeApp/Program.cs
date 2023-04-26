using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LethaboLegwaleRecipeApp
{
    internal class Program
    {
      
        public static List<Ingredient> ingredients = new List<Ingredient>();
        public static List<string> steps = new List<string>();
        public static double scalingFactor = 1.0;
        static void Main(string[] args)
        {
            //Classes that store the variables required for the app 
            Ingredient obj = new Ingredient();
            Recipe obj2 = new Recipe();
            //The method that begins the whole app by providing options 
            displayMenu();
        }

        // This method displays the options for the user to input
        public static void displayMenu()
        {

            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Enter recipe details");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset quantities");
            Console.WriteLine("5. Clear all data");
            Console.WriteLine("-PRESS ANY KEY TO EXIT-");
            Console.WriteLine(" ");
            Console.WriteLine("ENTER MENU OPTION: ");
            int userOption = int.Parse(Console.ReadLine());

            //If statement that goes through the number option the user has selected
            if (userOption == 1)
            {

                EnterRecipeDetails();

            }

            if (userOption == 2)
            {
                DisplayFullRecipe();
            }

            if (userOption == 3)
            {
                ScaleRecipe();
            }

            if (userOption == 4)
            {
                ResetQuantities();
            }

        }
        //Method that allows the user to insert the recipe details 
        public static void EnterRecipeDetails()
        {
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write($"Enter the name of ingredient {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter the quantity of {name} (in grams, milliliters, etc.): ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write($"Enter the unit of measurement for {quantity} {name}: ");
                string unit = Console.ReadLine();

            }

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                steps.Add(Console.ReadLine());
            }

            Console.WriteLine("Recipe details entered successfully!");

            displayMenu();
            Console.ReadLine();
        }


        //This method provides the full recipe that was inserted in EnterRecipeDetails();
        public static void DisplayFullRecipe()
        {
            Console.WriteLine("\nRecipe:");
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity * scalingFactor} {ingredient.Unit}");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
            displayMenu();
            Console.ReadLine();

        }
        //The use can choose to scale the recipe to any of the available options
        public static void ScaleRecipe()
        {
            Console.Write("Enter scaling factor (0.5, 2, or 3): ");
            double factor = double.Parse(Console.ReadLine());
            if (factor != 0.5 && factor != 2 && factor != 3)
            {
                Console.WriteLine("Invalid scaling factor. Please enter 0.5, 2, or 3.");
                return;
            }

            scalingFactor = factor;
            Console.WriteLine($"Recipe scaled by factor of {factor}.");

            DisplayFullRecipe();
            displayMenu();
            Console.ReadLine();
        }

        //THis nethod resets all the quantities 
        public static void ResetQuantities()
        {
            scalingFactor = 0.5;
            Console.WriteLine("Quantities reset to original values.");

            displayMenu();
            Console.ReadLine();
        }

        //Clears all the data in the system
        public static void ClearData()
        {
            ingredients.Clear();
            steps.Clear();

        }

    }
}
