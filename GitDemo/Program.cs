// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("First change of my repo");

int a, b;
string operation = "";

Console.Write("Enter The first number : ");
int.TryParse(Console.ReadLine(), out a);

Console.Write("Enter The first number : ");
int.TryParse(Console.ReadLine(), out b);

Console.Write("Enter +,-,/,*  :  ");
operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine($"The Given Number Addition is : {a + b}");
        break;

    case "-":
        Console.WriteLine($"The Given Number Substraction is : {a - b}");
        break;

    case "/":
        Console.WriteLine($"The Given Number Division is : {a / b}");
        break;

    case "*":
        Console.WriteLine($"The Given Number Product is : {a * b}");
        break;
    default:
        Console.WriteLine("Invalid Operation");
        break;
}

