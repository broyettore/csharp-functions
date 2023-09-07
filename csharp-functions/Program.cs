using System;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array used for our examples
            int[] arrTest = { 2, 6, 7, 5, 3, 9 };

            // Function to print an array content with example
            void PrintArray(int[] array)
            {
                Console.Write("[");

                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Console.Write(array[i]);
                    }
                }

                Console.Write("]");
            }

            PrintArray(arrTest);

            // Function to print the square of the input(number)
            int SquareNum(int number)
            {
                return (int)Math.Pow(number, 2);
            }

            int testSquareNum = 6;

            Console.WriteLine($"il numero è {testSquareNum} e elevato al quadrato diventa {SquareNum(testSquareNum)}");
            Console.WriteLine();

            // Function take an array and return a new array with the square of each element of the input

            //solution 1
            int[] SquareArray(int[] arr)
            {
                return arr.Select(key => SquareNum(key)).ToArray();
            }

            //solution 2
            int[] SquareArrayTwo(int[] arr)
            {
                int[] finalArr = new int[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    finalArr[i] = arr[i] * arr[i];
                }

                return finalArr;
            }

            Console.WriteLine("array originale: " + string.Join(",", arrTest));
            Console.WriteLine("array elevato al quadrato: " + string.Join(",", SquareArray(arrTest)));
            Console.WriteLine();


            // Function takes an array as input and outputs the sum of ist content
            int arraySum(int[] arr)
            {
                int sum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                return sum;
            }

            Console.WriteLine(arraySum(arrTest));
            Console.WriteLine(arraySum(SquareArray(arrTest)));
            Console.WriteLine();

            // BONUS

            // function that takes an input(number) and creates an array to store numbers inserted by user, finally returns the array.
            int[] userInput(int num)
            {
                int[] newArr = new int[num];
                for (int i = 0; i < num; i++)
                {
                    int insertNum = int.Parse(Console.ReadLine());
                    newArr[i] = insertNum;
                }

                return newArr;
            }


            Console.WriteLine("Write a number of your choice");
            int selectNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please write {selectNum} numbers");

            int[] userArray = userInput(selectNum);
            Console.WriteLine("these are the numbers you inserted: " + string.Join(",", userArray));
            Console.WriteLine();

            PrintArray(userArray);
            Console.WriteLine();

            Console.WriteLine("array originale: " + string.Join(",", userArray));
            Console.WriteLine("array elevato al quadrato: " + string.Join(",", SquareArray(userArray)));
            Console.WriteLine();


            Console.WriteLine("somma elementi dell'array: " + arraySum(userArray));
            Console.WriteLine("somma elementi elevati al quadrato dell'array: " + arraySum(SquareArray(userArray)));



        }
    }
}