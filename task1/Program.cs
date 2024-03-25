//Напиши программу,которая на вход принимает число и выдает,являится ли число четным 

System.Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    System.Console.WriteLine("Чутное");
}
else
{
    System.Console.WriteLine("не четное");
}