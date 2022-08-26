////Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine("Введите чило:");
int n = Convert.ToInt32 (Console.ReadLine());
int index = 1;
while (index<=n)
{
Console.WriteLine(Math.Pow(index,3));
index++;
}