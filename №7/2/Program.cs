using static System.Console;
using System.Text.RegularExpressions;

Write("Введите текст: ");
string text = ReadLine();

WriteLine((Regex.IsMatch(text, @"\d")) ? "Текст содержит цифры." : "Текст не содержит цифр.");