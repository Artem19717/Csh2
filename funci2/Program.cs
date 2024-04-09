//Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

// void main()
// {
//     int arr = ReadInt("Введите размер массива: ");
//     int[] array = GenerateArray(arr, 0, 50);
//     PrintArray(array);
//     System.Console.WriteLine(CountPrimes(array));
// }

// void PrintArray(int[] arrFor)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arrFor) + "]");
//     System.Console.WriteLine();
// }

// int CountPrimes(int[] myarr)
// {
//     int count = 0;
//     foreach (int num in myarr)
//         if (isPrime(num))
//             count++;
//     return count;
// }


// bool isPrime(int num)
// {
//     if (num < 2)
//         return false;
//     for (int i = 2; i <= Math.Sqrt(num); i++)
//     {
//         if (num % i == 0)
//             return false;
//     }
//     return true;
// }

// int[] GenerateArray(int size, int Left, int right)
// {
//     int[] tempArray = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < size; i++)
//         tempArray[i] = rand.Next(Left, right + 1);
//     return tempArray;
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }
// main();

//------------------------------------------------------------------------------------------------------------------

//Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
//Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

// void Main()
// {
// int arraySize = ReadInt("Введите размер массива: ");
// int[] array = GenerateArray(arraySize, 19, 22);
// PrintArray(array);
// System.Console.WriteLine(CountNumbers(array, 7, 1));
// }

// int CountNumbers(int[] array, int div, int end)
// {
// int count = 0;

// foreach(int number in array)
// if(number % div == 0 && number % 10 == end)
// count++;

// return count;
// }

// void PrintArray(int[] arrayForPrint)
// {
// System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
// }

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
// int[] tempArray = new int[size];
// Random rand = new Random();

// for(int i = 0; i < size; i++)
// tempArray[i] = rand.Next(leftRange, rightRange + 1);

// return tempArray;
// }

// int ReadInt(string msg)
// {
// System.Console.Write(msg);
// return Convert.ToInt32(Console.ReadLine());
// }

// Main();
//------------------------------------------------------------------------------------------------------------------
//Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем.

void Main()
{
int arraySize = ReadInt("Введите размер массива: ");

if (arraySize < 1 || arraySize > 8)
{
System.Console.WriteLine("Число не удовлетворяет требованиям! ");
return;
}

int[] array = GenerateArray(arraySize, 0, 9);

PrintArray(array);

System.Console.WriteLine(FromArrayToNumber(array));
// Console.WriteLine(Convert.ToInt32(string.Concat(array))); //второй способ вывода 
}

int FromArrayToNumber(int[] array)
{
int resultNumber = 0;

for(int i = 0; i < array.Length; i++)
resultNumber = resultNumber * 10 + array[i]; //первый способ

return resultNumber;
}

void PrintArray(int[] arrayForPrint)
{
System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
int[] tempArray = new int[size];
Random rand = new Random();

for (int i = 0; i < size; i++)
tempArray[i] = rand.Next(leftRange, rightRange + 1);

return tempArray;
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}

Main();