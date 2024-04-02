//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
//Программа должна выдать ответ: Да/Нет.

System.Console.Write("введите размер массива");
int arrSize = Convert.ToInt32(Console.ReadLine());

int[] myarr = new int[arrSize];
Random rand = new Random();   //выделил оперативную память для генерации чисел одной ячейкой 

for (int i = 0; i < myarr.Length; i++)
{
    //System.Console.WriteLine($"Введите элемент номер  {i + 1}");
    //myarr[i] = Convert.ToInt32(Console.ReadLine());
    myarr[i] = rand.Next(0, 10);
}

for(int i = 0; i < myarr.Length; i++)
{
    System.Console.Write(myarr[i] + " ");
}
System.Console.Write("\nВведите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool numFind = false;

for(int i = 0; i < myarr.Length; i++)
{
    if(myarr[i] == num)
    {
        numFind = true;
        break;
    }
}

if(numFind)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}
