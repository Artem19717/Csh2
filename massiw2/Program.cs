// // Создание масива из 4 строк и 5 столбцов


// int[,] createMatrix(int powCount, int columsCount)
// {
//     int[,] matrix = new int[powCount, columsCount];

//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 11);
//         }
//     }
//     return matrix;
// }
// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] matrix = createMatrix(4, 5);
// ShowMatrix(matrix);

//--------------------------------------------------------------------------------------------------------------------
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// void Main()
// {
//     int rows = ReadInt("Введите количество строк: ");
//     int cols = ReadInt("Введите количество столбцов: ");

//     int[,] matrix = GenerateMatrix(rows, cols, 0, 9);
//     PrintMatrix(matrix);
//     ChangeMatrix(matrix);
//     PrintMatrix(matrix);

// }

// void ChangeMatrix(int[,] myMatrix)
// {
//     for (int i = 0; i < myMatrix.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < myMatrix.GetLength(1); j += 2)
//         {
//             myMatrix[i, j] *= myMatrix[i, j];
//         }
//     }
// }

// void PrintMatrix(int[,] myMatrix)
// {
//     for (int i = 0; i < myMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < myMatrix.GetLength(1); j++)
//         {
//             System.Console.Write(myMatrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
// {
//     int[,] tempMatrix = new int[row, col];
//     Random rand = new Random();

//     for (int i = 0; i < row; i++)
//         for (int j = 0; j < col; j++)
//             tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);

//     return tempMatrix;
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();

//-------------------------------------------------------------------------------------------------------------------

//Задайте двумерный массив из целых чисел. 
//Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.

void Main()
{
    int rows = ReadInt("Введите количество строк: ");
    int cols = ReadInt("Введите количество столбцов: ");

    int[,] matrix = GenerateMatrix(rows, cols, 0, 9);
    PrintMatrix(matrix);

    PrintArray(RowsAverages(matrix));
}

void PrintArray(double[] array)
{
    System.Console.WriteLine(string.Join(", ", array));
}

double[] RowsAverages(int[,] myMatrix)
{
    double[] averages = new double[myMatrix.GetLength(0)];

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            averages[i] += myMatrix[i, j];
        }
        averages[i] = Math.Round(averages[i] / myMatrix.GetLength(1), 3);
    }

    return averages;

}

void PrintMatrix(int[,] myMatrix)
{
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            System.Console.Write(myMatrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);

    return tempMatrix;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();