// //Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.

// System.Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99 && num < 1000)
// {
//     //Первый вариант
//     int left = num / 100;
//     int right = num % 10;
//     //Второй вориант
//     int newnum = left * 10 + right;
//     System.Console.WriteLine(newnum);
//     //Первый способ
//     //System.Console.WriteLine(left + "" + rigt);
//     //Второй способ
//     // System.Console.WriteLine($"{left}{right}");
// }
// else
// {
//     System.Console.WriteLine("вы ввели не трехзначное число!");
// }
//--------------------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень, 
// равную третьей цифре.


// System.Console.WriteLine("Введите трехзначное");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99 && num < 1000)
// {
//     int mid = num / 10 % 10;
//     int righ = num % 10;
//     int result = 1;
//     while (righ > 0)
//     {
//         result *= mid;
//         righ--;
//     }
//     System.Console.WriteLine(result);
// }

// else
// {
//     System.Console.WriteLine("не верно");
// }
// ---------------------------------------------------------------------------------------------------------------------

 //Напишите программу, которая бедет принимать на вход два числа и выводить является ли первое число кратным второму 
 //Если первое число не кратно второму то программа выводит остаток от деленияю

System.Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum % secondNum == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет," + firstNum % secondNum);
    
}