// //Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// //Программа должна выдать ответ: Да/Нет.

// System.Console.Write("введите размер массива");
// int arrSize = Convert.ToInt32(Console.ReadLine());

// int[] myarr = new int[arrSize];
// Random rand = new Random();   //выделил оперативную память для генерации чисел одной ячейкой 

// for (int i = 0; i < myarr.Length; i++)
// {
//     //System.Console.WriteLine($"Введите элемент номер  {i + 1}");
//     //myarr[i] = Convert.ToInt32(Console.ReadLine());
//     myarr[i] = rand.Next(0, 10);
// }

// for(int i = 0; i < myarr.Length; i++)
// {
//     System.Console.Write(myarr[i] + " ");
// }
// System.Console.Write("\nВведите искомое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool numFind = false;

// for(int i = 0; i < myarr.Length; i++)
// {
//     if(myarr[i] == num)
//     {
//         numFind = true;
//         break;
//     }
// }

// if(numFind)
// {
//     System.Console.WriteLine("yes");
// }
// else
// {
//     System.Console.WriteLine("no");
// }
//----------------------------------------------------------------------------------------------------------------------

//Задайте массив из 10 элементов заполненный из промежутка (-10, 10) Замените отрицательные элементы 
//на положительные,а положительные на отрицательные

// System.Console.WriteLine("Введите размер массива");
// int arrSize = Convert.ToInt32(Console.ReadLine());

// int[] myarr = new int[arrSize];
// Random rand = new Random();

// for (int i = 0; i < myarr.Length; i++)
// {
//     myarr[i] = rand.Next(-10, 11);
// }

// for (int i = 0; i < myarr.Length; i++)
// {
//     System.Console.Write(myarr[i] + "\t");
// }

// for (int i = 0; i < myarr.Length; i++)
// {
//     myarr[i] *= -1;
// }
// System.Console.WriteLine();
// for (int i = 0; i < myarr.Length; i++)
// {
//     System.Console.Write(myarr[i] + "\t");
// }

//----------------------------------------------------------------------------------------------------------------------

//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,второй и предпоследний
// и т.д. Результат запешите в новый массив


// System.Console.WriteLine("Введите размер массива");
// int arrSize = Convert.ToInt32(Console.ReadLine());

// int[] myarr = new int[arrSize];
// Random rand = new Random();

// for (int i = 0; i < myarr.Length; i++)
// {
//     myarr[i] = rand.Next(-10, 11);
// }

// for (int i = 0; i < myarr.Length; i++)
// {
//     System.Console.Write(myarr[i] + " ");
// }

// int[] newarr = new int[myarr.Length / 2];

// for(int i = 0; i < newarr.Length; i++)
// {
//     newarr[i] = myarr[i] * myarr [myarr.Length - 1 - i];
// }
// System.Console.WriteLine();

// for(int i = 0; i < newarr.Length; i++)
// {
//     System.Console.Write(newarr[i] + " ");
// }

//-----------------------------------------------------------------------------------------------------------------------
