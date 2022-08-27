// Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4
using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите несколько чисел (через пробел): ");
int [] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
WriteLine($"Чисел больше ноля - {String.Join(",",QuantPositive(array))}");



int QuantPositive(int[]arr)
{
    int result = 0;
    for (int i =0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            result++;
        }
    }
    return result;
}