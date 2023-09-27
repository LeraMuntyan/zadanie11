using System;
using System.Linq;

class Program
{
    static void Main()
    {

        Random rand = new Random();
        int n = 20;
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)

        {

            Console.Write("{0,5}", i);

        }
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
           
        {
           
            arr[i] = rand.Next(0, 30);
            Console.Write("{0,5}", arr[i]);
          
        }
        Console.WriteLine();
        

        int max = arr.Max();
        int min = arr.Min();

        Console.WriteLine($"Максимальное значение: {max}");
        Console.WriteLine($"Минимальное значение: {min}");

        
        Console.WriteLine("Числа из интервала (min; max), которые не встречаются в массиве:");
        for (int i = min + 1; i < max; i++)
        {
            if (!arr.Contains(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Если хотите повторить ввод, введите 1, иначе любую другую цифру.");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {
            Main(); 
        }
    }
}