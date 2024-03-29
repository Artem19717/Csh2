// int[] arr = new int[5];
// arr[0] = 2;
// arr[1] = 7;
// arr[2] = 5;
// arr[3] = 4;
// arr[4] = 5;
// System.Console.WriteLine(arr[0]);
// System.Console.WriteLine(arr[1]);
// System.Console.WriteLine(arr[2]);
// System.Console.WriteLine(arr[3]);
// System.Console.WriteLine(arr[4]);

// //System.Console.WriteLine(arr[5]);

// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };


// int[] arr3 = { 1, 2, 3, 4, 5 };

//------------------------------------------------------------------------------------------------------------------------

//Создать масив и заполнить его целыми числами от 1 до N 

// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// while (i < n)
// {
//     arr[i] = i + 1;
//     // System.Console.Write(arr[i]);
//     // System.Console.Write(' ');
//     System.Console.Write($"{arr[i]} ");
//     i = i + 1;
// }
//------------------------------------------------------------------------------------------------------------------------

//Создать целочисленный массив на 10 элементов и заполнить его произвольными числами 
//Вывести на экран четные элементы массива

// int n = 10;
// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8 };
// int i = 0;

// while (i < n)
// {
//     if (array[i] % 2 == 0)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     i = i + 1;
// }
//------------------------------------------------------------------------------------------------------------------------

//Задача с гирями



int n = 5;
int[] array = { 3, 4, 6, 7, 9 };
int i = 0;
int max = array[0];

while(i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
System.Console.Write(max);