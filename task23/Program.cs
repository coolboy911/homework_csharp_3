﻿// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= n){
    Console.Write(Math.Pow(count, 3));
    if (count < n) Console.Write(", ");
    count++;
}
Console.WriteLine("");