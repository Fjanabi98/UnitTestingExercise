﻿using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // Step 1: Add a reference to your UnitTestingExercise project:

        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        // and add your reference to the UnitTestingExercise project

        
        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }

        public int Subtract(int minuend, int subtrend)
        {
            return minuend - subtrend;
        }

        public int Multiply(int one, int two)
        {
            return one * two;
        }

        public int divide(int one, int two)
        {
            return two / one;
        }

        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        //For Example:
        // public int Add(int num1, int num2, int num3)
        //{
        //return num1 + num2 + num3;
        //}


        // Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 


        // Step 4: 
        // Create a Subtract method that accepts 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend


        // Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method


        // Step 6: 
        // Create a Multiply method that passes 2 integers


        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // Step 8: 
        // Create a Divide method that passes 2 integers

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
