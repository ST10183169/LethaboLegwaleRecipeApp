# LethaboLegwaleRecipeApp
  // This method displays the options for the user to input
        public static void displayMenu()
        {
        
  //Provides user with the menu
         Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Enter recipe details");
          
  //If statement that goes through the number option the user has selected
            if (userOption == 1)
            {

                EnterRecipeDetails();
   //Allows user to enter the ingridients
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            for (int i = 0; i < numIngredients; i++)
            
    //Allows use to enter amount of steps 
            Console.Write("Enter the number of steps: ");
            
     //This method provides the full recipe that was inserted in EnterRecipeDetails();
        public static void DisplayFullRecipe()
        {
     
     //The use can choose to scale the recipe to any of the available options
        public static void ScaleRecipe()
        {
        
      //THis method resets all the quantities 
        public static void ResetQuantities()
        {
      
        //Clears all the data in the system
        public static void ClearData()
        {

https://github.com/ST10183169/LethaboLegwaleRecipeApp.git
