using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] scores = new float[5];
            char[] grades = new char[5];

            Console.WriteLine("Enter 5 percentage scores (0-100):");
            
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Score {i + 1}: ");
                
                while (true)
                {
                    if (float.TryParse(Console.ReadLine(), out float score) && score >= 0 && score <= 100)
                    {
                        scores[i] = score; 
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a score between 0 and 100.");
                    }
                }
            }
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >= 90)
                {
                    grades[i] = 'A';
                }
                else if (scores[i] >= 80)
                {
                    grades[i] = 'B';
                }
                else if (scores[i] >= 70)
                {
                    grades[i] = 'C';
                }
                else if (scores[i] >= 60)
                {
                    grades[i] = 'D';
                }
                else
                {
                    grades[i] = 'F';
                }
            }
            Console.WriteLine("\nResults:");
            
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Score: {scores[i]} - Grade: {grades[i]}");

                switch (grades[i])
                {
                    case 'A':
                        Console.WriteLine("Excellent work!");
                        break;
                    case 'B':
                        Console.WriteLine("Great job!");
                        break;
                    case 'C':
                        Console.WriteLine("Good effort!");
                        break;
                    case 'D':
                        Console.WriteLine("You passed, but there's room for improvement.");
                        break;
                    case 'F':
                        Console.WriteLine("Unfortunately, you failed. Please try again.");
                        break;
                }
            }
        }
    }
}
