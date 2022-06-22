using static System.Console;
using static System.Convert;
using static System.Math;

void AddLeftDigit(int D, ref int K)
{
    if(D <= 0 || D > 9 || K <= 0) 
        throw new ArgumentException("Неверное значение параметров");          
    int n = K;
    while (n != 0) {
        n /= 10;
        D *= 10;
    }
    K += D;

    WriteLine($"K: {K}");
}

Write("Введите K: ");
int k = ToInt32(ReadLine());
Write("Введите D1: ");
int D1 = ToInt32(ReadLine());

AddLeftDigit(D1, ref k);

Write("Введите D1: ");
int D2 = ToInt32(ReadLine());

AddLeftDigit(D2, ref k);
