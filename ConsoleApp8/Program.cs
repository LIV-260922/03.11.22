int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int oddNumberCount = 0;
int evenNumberCount = 0;
int oddsumm =0 ;
int evensumm=0;
while (number1 <= number2)
{
    if (number1 % 2 == 0)
    {
        evenNumberCount++;
        evensumm = evensumm + number1;
    }
    else
        oddsumm = oddsumm + number1;
        oddNumberCount++;
    number1++;
}
    Console.WriteLine("Количество нечетных чисел на этой области=" + oddNumberCount);
    Console.WriteLine("Количество четных чисел на этой области=" + evenNumberCount);
Console.WriteLine("summa нечетных чисел на этой области=" + oddsumm);
Console.WriteLine("summa четных чисел на этой области=" + evensumm);
Console.ReadLine();


