using static System.Console;
using System.Text.RegularExpressions;

bool IsPalindrom(string s)
{
    string newS = Regex.Replace(s, "[-.?!)(,: ]", "").ToLower();
    char[] arr = newS.ToCharArray();

    Array.Reverse(arr);

    string temp   = new string(arr);

    return newS.Equals(temp);
}

Write("Введите строку: ");
string s = ReadLine();

if (IsPalindrom(s))
{
    WriteLine("Палиндром");
}
else
{
    WriteLine("Не палиндром");
}