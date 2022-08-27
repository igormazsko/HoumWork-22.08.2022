// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2; значения b1, k1, 
// b2 и k2 задаются пользователем.
// y=k1*x+b1, y=k2*x+b2
// k1*x+b1=k2*x+b2
// k1*x-k2*x=b2-b1
// x*(k1-k2)=b2-b1
// x=(b2-b1)/(k1-k2)
using static System.Console;
Clear();
Write("Введите коордитнату k1 - ");
double k1 = Convert.ToDouble(ReadLine());
Write("Введите коордитнату b1 - ");
double b1 = Convert.ToDouble(ReadLine());
Write("Введите коордитнату k2 - ");
double k2 = Convert.ToDouble(ReadLine());
Write("Введите коордитнату b2 - ");
double b2 = Convert.ToDouble(ReadLine());
double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
WriteLine ($"Точка пересечения прямых: ({x};{y})");