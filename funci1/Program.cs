// //Функция  

// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numen = a * b;
//     int denome = c + d;
//     double result = numen / denome;
//     return result;
// }
// double result = CalculateFormula(1, 2, 3, 4);
// System.Console.WriteLine(result);

//-----------------------------------------------------------------------------------------------------------------------
//Функция нахождения квадрата 
void PrintSquares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i*i} ");
        i++;
    }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);