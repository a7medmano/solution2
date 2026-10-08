
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.WriteLine("\nP - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("F - Search for a number");
            Console.WriteLine("C - Clear the list");
            Console.WriteLine("D - Don't allow duplicate entries");
            Console.WriteLine("N - Display number of elements");
            Console.WriteLine("Q - Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "P":
                case "p":

                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");

                        foreach (int number in numbers)
                        {
                            Console.Write(number + " ");
                        }

                        Console.WriteLine("]");
                    }

                    break;


                case "A":
                case "a":

                    Console.Write("Enter an integer to add: ");
                    int numberToAdd = Convert.ToInt32(Console.ReadLine());

                    numbers.Add(numberToAdd);

                    Console.WriteLine(numberToAdd + " added");

                    break;


                case "M":
                case "m":

                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        int sum = 0;

                        foreach (int number in numbers)
                        {
                            sum = sum + number;
                        }

                        double mean = (double)sum / numbers.Count;

                        Console.WriteLine("The mean is " + mean);
                    }

                    break;


                case "S":
                case "s":

                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int smallest = numbers[0];

                        foreach (int number in numbers)
                        {
                            if (number < smallest)
                            {
                                smallest = number;
                            }
                        }

                        Console.WriteLine("The smallest number is " + smallest);
                    }

                    break;


                case "L":
                case "l":

                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int largest = numbers[0];

                        foreach (int number in numbers)
                        {
                            if (number > largest)
                            {
                                largest = number;
                            }
                        }

                        Console.WriteLine("The largest number is " + largest);
                    }

                    break;

                case "F":
                case "f":

                    Console.Write("Enter a number to search: ");
                    int searchNumber = Convert.ToInt32(Console.ReadLine());

                    int index = numbers.IndexOf(searchNumber);

                    if (index != -1)
                    {
                        Console.WriteLine("Number found at index " + index);
                    }
                    else
                    {
                        Console.WriteLine("Number not found");
                    }

                    break;

                case "C":
                case "c":

                    numbers.Clear();

                    Console.WriteLine("The list has been cleared");

                    break;

                case "D":
                case "d":

                    Console.Write("Enter a number to add: ");
                    int newNumber = Convert.ToInt32(Console.ReadLine());

                    if (numbers.Contains(newNumber))
                    {
                        Console.WriteLine("Duplicate number is not allowed");
                    }
                    else
                    {
                        numbers.Add(newNumber);

                        Console.WriteLine(newNumber + " added");
                    }

                    break;

                case "N":
                case "n":

                    Console.WriteLine("Number of elements: " + numbers.Count);

                    break;


                case "Q":
                case "q":

                    Console.WriteLine("Goodbye");

                    return;


                default:

                    Console.WriteLine("Unknown selection, please try again");

                    break;
            }
        }
    }
}