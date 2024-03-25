//Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.

using System.Security.AccessControl;

System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    //Первый вариант
    int left = num / 100;
    int right = num % 10;
    //Второй вориант
    int newnum = left * 10 + right;
    System.Console.WriteLine(newnum);
    //Первый способ
    //System.Console.WriteLine(left + "" + rigt);
    //Второй способ
    // System.Console.WriteLine($"{left}{right}");
}
else
{
    System.Console.WriteLine("вы ввели не трехзначное число!");
}