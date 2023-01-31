//Задание 8.
Console.WriteLine("Please, Enter number1");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please,Enter number2");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Please,Enter number3");
int number3 = int.Parse(Console.ReadLine());
int max = number1;

if (number2 > max)
{
    max = number2;
  
}
if (number3 > max)

{max = number3;

}

Console.WriteLine($"the largest number out of three {max}");