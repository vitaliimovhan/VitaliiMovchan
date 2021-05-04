// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Module_one
{
    using System;

    /// <summary>
    /// New element program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method is entry point of application.
        /// </summary>
        /// <param name="args">
        /// String parameter.
        /// </param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter desired number of elements for array:");
            int arraySize = int.Parse(Console.ReadLine());

            int[] userArray = new int[arraySize];
            char[] oddArray = new char[arraySize];
            char[] evenArray = new char[arraySize];

            Random random = new ();

            void UserArrayGeneration(int arraySize)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    userArray[i] = random.Next(1, 26);
                }

                Console.WriteLine("userArray output:");
                foreach (var item in userArray)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }

            UserArrayGeneration(arraySize);

            int countOdd = 0;
            int countEven = 0;

            void ArrayToChar()
            {
                for (int i = 0; i < arraySize; i++)
                {
                    if (userArray[i] % 2 == 0)
                    {
                        if (userArray[i] == 4 | userArray[i] == 8 | userArray[i] == 10)
                        {
                            evenArray[i] = Convert.ToChar(userArray[i] + 64);
                            countEven++;
                        }
                        else
                        {
                            evenArray[i] = Convert.ToChar(userArray[i] + 96);
                        }
                    }
                    else
                    {
                        if (userArray[i] == 1 | userArray[i] == 5 | userArray[i] == 9)
                        {
                            oddArray[i] = Convert.ToChar(userArray[i] + 64);
                            countOdd++;
                        }
                        else
                        {
                            oddArray[i] = Convert.ToChar(userArray[i] + 96);
                        }
                    }
                }

                Console.WriteLine("oddArray output:");
                foreach (var item in oddArray)
                {
                    Console.Write($"{item}");
                }

                Console.WriteLine();
                Console.WriteLine("evenArray output:");
                foreach (var item in evenArray)
                {
                    Console.Write($"{item}");
                }
                }

            ArrayToChar();

            Console.WriteLine();

            if (countEven > countOdd)
            {
                Console.WriteLine("Even array has more uppercase letters then odd array");
            }
            else if (countEven < countOdd)
            {
                Console.WriteLine("Odd array has more uppercase letters then even array");
            }
            else
            {
                Console.WriteLine("Number of uppercase letters is equal for oddArray and evenArray");
            }
        }
    }
}
