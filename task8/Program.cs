﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.Write("Введите число, больше еденицы: ");
int n = int.Parse(Console.ReadLine());
while (n <= 1) {
    Console.WriteLine ("Непрвильно!");
    Console.Write("Введите число, больше еденицы: ");
    n = int.Parse(Console.ReadLine());
}
int i = 2;
while(i <= n) {
    Console.Write($"{i} ");
    i = i + 2;
}