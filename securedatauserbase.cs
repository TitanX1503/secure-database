using System;

namespace Programacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];

            arr[i] = arr[j];

            arr[j] = temp;
        }

        static void BubbleSort(int[] numbers)
        {
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                
                for (int j = 0; j < i; j++)
                {

                    if (numbers[j] > numbers[j + 1])
                    {
                        Swap(numbers, j, j + 1);
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);    
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Antes de ordenar:");
            PrintArray(testNumbers);
            BubbleSort(testNumbers);
            System.Console.WriteLine("Después de ordenar:");
            PrintArray(testNumbers);


        }
    }
}

// aaahh, mi mente no procesa mas cono hacer esto y me estan comenzando a dar horribles dolores de cabeza, lo siento, pero realmente lo intente

