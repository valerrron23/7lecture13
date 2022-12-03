using System;
namespace lecture13_7
{
    public class example
    {
        static void heapSort(int[] arr, int n) //лекция 13 пример 7
        {
            for (int i = n / 2 - 1; i >= 0; i--) //цикл, пока верно условие
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)//цикл, пока верно условие
            {
                int temp = arr[0]; //объявление массива
                arr[0] = arr[i]; //присвоение значения элементу массива
                arr[i] = temp; //присвоение значения элементу массива
                heapify(arr, i, 0); //сортировка
            }
        }
        static void heapify(int[] arr, int n, int i)
        {
            int largest = i; //задание целочисленных переменных
            int left = 2 * i + 1; //задание переменной
            int right = 2 * i + 2; //задание переменной
            if (left < n && arr[left] > arr[largest]) //выполнять, если верно условие
                largest = left; //задание переменной
            if (right < n && arr[right] > arr[largest])//выполнять, если верно условие
                largest = right; //задание переменной
            if (largest != i)//выполнять, если верно условие
            {
                int swap = arr[i]; //задание переменной
                arr[i] = arr[largest]; //присвоение значения элементу массива
                arr[largest] = swap; //присвоение значения элементу массива
                heapify(arr, n, largest); //сортировка
            }
        }
        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 }; //задание элементов массива
            int n = 10, i; //задание целочисленных переменных
            Console.WriteLine("Heap Sort"); //вывод
            Console.Write("Initial array is: ");//вывод
            for (i = 0; i < n; i++) //цикл, пока верно условие
            {
                Console.Write(arr[i] + " "); //вывод массива
            }
            heapSort(arr, 10); //пирамидальная сортировка
            Console.Write("\nSorted Array is: "); //вывод массива
            for (i = 0; i < n; i++) //цикл, пока верно условие
            {
                Console.Write(arr[i] + " "); //вывод массива
            }
        }
    }
}