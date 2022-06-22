Console.Write("Введите курс рубля к доллару: ");
var rate = double.Parse(Console.ReadLine());

Console.WriteLine("for: ");
for (int i = 5; i <= 500; i += 5) 
{ 
  Console.WriteLine($"{i} долл. = {i * rate} руб.");
}

Console.WriteLine("while: ");
int j = 5;
while (j <= 500)
{
  Console.WriteLine($"{j} долл. = {j * rate} руб.");
  j += 5;
}

Console.WriteLine("do while: ");
int k = 5;
do
{
  Console.WriteLine($"{k} долл. = {k * rate} руб.");
  k+=5;
}
while (k <= 500);