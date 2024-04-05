//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// System.Console.WriteLine("Вудите число num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 7 == 0 && num % 23 == 0)
// {
//     System.Console.Write("да");
// }
// else
// {
//     System.Console.Write("не");
// }

//-----------------------------------------------------------------------------------------------------------------------

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// System.Console.WriteLine("Введите кординаты точки X и Y через пробел ");
// string[] coordinates = Console.ReadLine().Split(' ');

// int x = Convert.ToInt32(coordinates[0]);
// int y = Convert.ToInt32(coordinates[1]);

// if (x > 0 && y > 0)
// {
//     System.Console.WriteLine(("1"));
// }
// else if (x < 0 && y > 0)
// {
//     System.Console.WriteLine("2");
// }
// else if (x < 0 && y < 0)
// {
//     System.Console.WriteLine("3");
// }
// else if (x > 0 && y < 0)
// {
//     System.Console.WriteLine("4");
// }
// else
// {
//     System.Console.WriteLine("Точка находится на оси кординат");
// }

//---------------------------------------------------------------------------------------------------------------------

//задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает 
//наибольшую цифру числа.

// System.Console.WriteLine("Введите число из отрезка 10, 99");
// int num = Convert.ToInt32(Console.ReadLine());
// int firstDigit = num / 10;
// int secondDigit = num % 10;
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// System.Console.WriteLine(maxDigit);

//---------------------------------------------------------------------------------------------------------------------

//Задача 4 :

//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


System.Console.WriteLine("Введите натуральное число N:");
string input = Console.ReadLine();
if (int.TryParse(input, out int num) && num > 0)
{
    string numstring = num.ToString();
    System.Console.Write(numstring[0]);
    for (int i = 1; i < numstring.Length; i++)
    {
        System.Console.Write(", " + numstring[i]);
    }
    System.Console.WriteLine();
}
else
{
    System.Console.WriteLine("ошибка");
}







