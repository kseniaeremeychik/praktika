using static System.Console;
using System.Text.RegularExpressions;

Write("Введите текст: ");
var line = ReadLine();

Regex regex = new Regex(@"[йцкнгшщзхфвпрлджчсмтб]");
MatchCollection matches = regex.Matches(line);

if (matches.Count > 0)
{
    foreach (var i in matches)
        WriteLine(i);
}
else
{
    WriteLine("Текст не содержит согласных");
}