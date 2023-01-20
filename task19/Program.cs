//Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно 
// палиндромом.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num % 10 == num / 10000){
    if (num / 10 % 10 == num / 1000 % 10) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.WriteLine("нет");