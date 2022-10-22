using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // Step 1: Add a reference to your UnitTestingExercise project:

        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        // and add your reference to the UnitTestingExercise project



        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        //For Example:
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


        // Step 4: 
        // Create a Subtract method that accepts 2 integers
        public int subtract(int minued, int subtrhend)
        {
            return minued - subtrhend;

        }


        // Step 6: 
        // Create a Multiply method that passes 2 intergers
        public int Multiply(int one, int two)
        {
             return one * two;
        }


        
        // Create a Divide method that method that passes 2 intergers
        public int Divide(int one,int two)
        {
            return two / one;
        }

       


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
