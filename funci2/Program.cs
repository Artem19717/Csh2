//Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

void main()
{
    int arr = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arr, 0, 50);
    PrintArray(array);
    System.Console.WriteLine(CountPrimes(array));
}

void PrintArray(int[] arrFor)
{
    System.Console.WriteLine("[" + string.Join(", ", arrFor) + "]");
    System.Console.WriteLine();
}

int CountPrimes(int[] myarr)
{
    int count = 0;
    foreach (int num in myarr)
        if (isPrime(num))
            count++;
    return count;
}


bool isPrime(int num)
{
    if (num < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}

int[] GenerateArray(int size, int Left, int right)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(Left, right + 1);
    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
main();