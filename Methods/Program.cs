﻿using System.Net.Http.Headers;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------USER STORY-------------------------
            //Declare variables
            /*string userName;
            string favoriteAnimal;
            string favoriteColor;
            string favoriteBand;

            //Get user input
            Console.WriteLine($"What is your name?");
            userName = Console.ReadLine();

            Console.WriteLine($"What is your favorite animal?");
            favoriteAnimal = Console.ReadLine();

            Console.WriteLine($"What is your favorite color?");
            favoriteColor = Console.ReadLine();

            Console.WriteLine($"What is your favorite band?");
            favoriteBand = Console.ReadLine();

            //Storytime!
            Console.WriteLine($"There once was a kid named {userName}. They lived in a fairytale land with their talking {favoriteColor} {favoriteAnimal}.");
            Console.WriteLine($"They loved to go on adventures, but when {userName} heard {favoriteBand} floating in from the sky, {userName} knew that they had to wake up.");*/

            //--------------------------MATH---------------------------------
            //Declare variables
            int x;
            int y;
            int sum;
            int diff;
            int product;
            int quotient;

            //ADDITION
            Console.WriteLine($"ADDITION:");
            Console.WriteLine($"Enter x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter y:");
            y = int.Parse(Console.ReadLine());
            sum = Add(x, y);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine();

            //SUBTRACTIONS
            Console.WriteLine($"SUBTRACTION:");
            Console.WriteLine($"Enter x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter y:");
            y = int.Parse(Console.ReadLine());
            diff = Sub(x, y);
            Console.WriteLine($"The difference is {diff}");

            Console.WriteLine();

            //MULTIPLICATION
            Console.WriteLine($"MULTIPLICATION:");
            Console.WriteLine($"Enter x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter y:");
            y = int.Parse(Console.ReadLine());
            product = Mul(x, y);
            Console.WriteLine($"The product is {product}");

            Console.WriteLine();

            //DIVISION
            Console.WriteLine($"DIVISION:");
            Console.WriteLine($"Enter x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter y:");
            y = int.Parse(Console.ReadLine());
            quotient = Div(x, y);
            Console.WriteLine($"The quotient is {quotient} (rounded down)");
        }

        //--------MATH METHODS----------
        //Addition Method
        public static int Add(params int[] list)
        {
            int sum = list[0];

            for (int i = 1; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

        //Subtraction Method
        public static int Sub(params int[] list)
        {
            int diff = list[0];

            for (int i=1; i < list.Length; i++)
            {
                diff = diff - list[i];
            }
            return diff;
        }

        //Multiplication Method
        public static int Mul(params int[] list)
        {
            int prod = list[0];

            for (int i = 1; i < list.Length ; i++)
            {
                prod = prod * list[i];
            }
            return prod;
        }

        //Division Method
        public static int Div(params int[] list)
        {
            int quot = list[0];

            for (int i = 1 ; i < list.Length ; i++)
            {
                quot = quot / list[i];
            }
            return quot;
        }
    }
    
}