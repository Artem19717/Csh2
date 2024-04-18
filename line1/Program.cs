
//Задайте массив символов (тип char []). Создайте строку из символов этого массива.
// string ArrayToString(char[] c)
// {
// string str = "";

// foreach (char letter in c)
// str += letter;

// return str;
// }

// char[] chars = { 'a', 'b', 'c', 'd' };

// // 1 способ:
// // string str = new string(chars);

// // 2 способ:
// string str = ArrayToString(chars);

// // 3 способ:
// // string str = string.Concat(chars);

// // 4 способ:
// // string str = string.Join("", chars);

// System.Console.WriteLine(str);
//-------------------------------------------------------------------------------------

//На основе символов строки (тип string) сформировать массив символов (тип char[]). 
//Вывести массив на экран.

// void Main()
// {
// System.Console.Write("Введите текст: ");
// string? str = Console.ReadLine();
// // char[] chars = str!.ToCharArray();
// char[] chars = StringToCharArray(str);
// PrintArray(chars);

// }

// char[] StringToCharArray(string? s)
// {
// char[] tempChars = new char[s!.Length];

// for(int i = 0; i < s.Length; i++)
// tempChars[i] = s[i];

// return tempChars;
// }

// void PrintArray(char[] c)
// {
// System.Console.WriteLine("['" + string.Join("', '", c) + "']");
// }

// Main();
//-------------------------------------------------------------------------------------

// System.Console.WriteLine("Введите массив одной строкой: ");

// int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// System.Console.WriteLine(string.Join(", ", array));
// ---------------------------------------------------------------------------------------

//Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
//Выяснить, сколько среди введённых букв гласных.

void Main()
{
System.Console.Write("Введите строку: ");
string? str = Console.ReadLine()!.ToLower();
System.Console.WriteLine(CountVowels(str));
}

int CountVowels(string? str)
{
int count = 0;

foreach(char letter in str!)
if(isVowel(letter))
count++;

return count;
}

bool isVowel(char c)
{
return "aeiouy".Contains(c);
}

Main();

