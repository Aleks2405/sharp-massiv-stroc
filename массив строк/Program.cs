using System;
/* Прочитать с клавиатуры массив строк.
Перечислить их длины. Вывести на экран
первую и последнюю буквы самой длинной строки.*/
namespace массив_строк
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            string[] arr = new string[size]; 

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine(); //запись строки
            }
            string max = arr[0];
            Console.Write("Длина каждого элемента ");
            foreach (string arr2 in arr)  //подсказал дима,принцип работы усвоил
            {
                Console.Write(arr2.Length + " "); 
                if (arr2.Length > max.Length)
                {
                    max = arr2;
                  
                }
            }
            Console.WriteLine(" первая и последняя буква {0},{1}", max[0], max[max.Length-1]);
        }
    }
}
