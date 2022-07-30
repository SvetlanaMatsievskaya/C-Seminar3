int number = 0;
Console.WriteLine("Введите число: ");
number = int.Parse(Console.ReadLine());
int PowToThree(int number)
{
    int result = 0;
    result = number*number*number;
    return result;
}
for (int i =1; i < number+1; i++)
{
    Console.Write($"{PowToThree(i)} ");
}