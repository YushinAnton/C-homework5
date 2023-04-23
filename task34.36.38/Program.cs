using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void FillArray(int[] numbers, int minValue = -9, int maxValue = 9)
            {
                maxValue++;
                Random rnd = new Random();                
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(minValue, maxValue);
                }               
            }

            void FillArrayDouble(double[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToDouble(new Random().Next(-100,100)) / 100;
                }               
            }
            void PrintArray(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();                
            }

            void PrintArrayDouble(double[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();                
            }

            int CountEvenNumbers(int[] numbers)
            {
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i] % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            int SumOddNumbers(int[] numbers)
            {
                  int sumOdd = 0;
                for (int i = 0; i < numbers.Length; i = i + 2)
                {
                        sumOdd = sumOdd + numbers[i];
                }
                return sumOdd;  
            }


            double DevMaxMin(double[] numbers)
            {
                double max = 0;
                double min = 0;

                for (int i = 0; i < numbers.Length; i = i + 2)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    if (numbers[i] < min)
                    {
                    min = numbers[i];
                    }
                }
                  double dev = max - min;
                  return dev;
            }

            void Tak34()
        {
                int size = 10;
                int[] numbers = new int[size];
                FillArray(numbers, 100, 999);
                PrintArray(numbers); 
                Console.WriteLine($"Количество четных элементов равно {CountEvenNumbers(numbers)}"); 

        }

        void Task36()
        {
            int size = 10;
                int[] numbers = new int[size];
                FillArray(numbers);
                PrintArray(numbers); 
                Console.WriteLine($"Сумма элементов с нечетными индексами {SumOddNumbers(numbers)}");
        }

        void Task38()
        {
                int size = 10;
                double[] numbers = new double[size];
                FillArrayDouble(numbers);
                PrintArrayDouble(numbers); 
                Console.WriteLine($"Разница мужду минимальным и максимальным зачением {DevMaxMin(numbers)}");
        }


            
            //Задача 34: Задача 34: Задайте массив заполненный случайными 
            //положительными трёхзначными числами. Напишите программу, 
            //которая покажет количество чётных чисел в массиве.
            
            //Tak34();


            //Задача 36: Задайте одномерный массив, заполненный случайными 
            //числами. Найдите сумму элементов с нечётными индексами.
            
            //Task36();


            //Задача 38: Задайте массив вещественных чисел. 
            //Найдите разницу между максимальным и минимальным 
            //элементами массива.

            Task38();


        
        }   
    }

}
