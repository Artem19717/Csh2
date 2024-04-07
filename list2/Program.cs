// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

// while (true)
// {
//     System.Console.Write("Введите число или 'q' для выхода ");
//     string input = Console.ReadLine();

//     if (input == "q")
//     {
//         break;
//     }
//     int num;
//     if (int.TryParse(input, out num))
//     {
//         int sum = 0;
//         while (num > 0)
//         {
//             sum += num % 10;
//             num /= 10;
//         }
//         if (sum % 2 == 0)
//         {
//             System.Console.WriteLine("[STOP]");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("Некорректный ввод");
//     }
// }

//----------------------------------------------------------------------------------------------------------------------

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int[] num = new int[10];
// Random random = new Random();
// int evenCount = 0;

// for (int i = 0;i < num.Length;i++)
// {
//     num[i] = random.Next(100, 1000);
//     System.Console.Write(num[i] + " ");

//     if (num[i] % 2 == 0)
//     {
//         evenCount++;
//     }
// }
// System.Console.WriteLine($"\nКоличество четных чисел в масиве: {evenCount}");

//-------------------------------------------------------------------------------------------------------------------

// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним,
//  второй – предпоследним и т.д.)

// int[] num = { 1, 4, 5, 8, 9, 7 };
// int temp;

// System.Console.Write("Исходный масси: ");
// foreach (int numb in num )
// {
//     System.Console.Write(num + " ");
// }
// for (int i = 0; i < num.Length / 2; i++)
// {
//     temp = num[i];
//     num[i] = num[num.Length - 1 - i];
//     num[num.Length - 1 -i] = temp;

// }
// System.Console.Write("\nПеревернутый массив: ");
// foreach (int numb in num)
// {
//     System.Console.Write(numb + " ");
// }



