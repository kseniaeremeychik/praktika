using static System.Console;
using System;

Write("Введите строку: ");
string inputStr = ReadLine();

if(!IsCorrectString(inputStr))
{
    WriteLine("Необходимо ввести только цифры и буквы");

    return;
}
int sum = 0;

for(int i = 0; i < inputStr.Length; i++)
{
    if(char.IsDigit(inputStr[i]))
    {
        sum += Convert.ToInt32(inputStr[i].ToString());
    }
}
if(sum == inputStr.Length)
{
    WriteLine("Сумма цифр в строке равна длине строки");
}
else
{
    WriteLine("Сумма цифр в строке не равна длине строки");
}

bool IsCorrectString(string inputStr)
{
    for(int i = 0; i < inputStr.Length; i++)
    {
        if(!char.IsLetterOrDigit(inputStr[i]))
        {
            return false;
        }
    }
    return true;
}