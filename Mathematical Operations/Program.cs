// Operations mathematical (+)(-)(*)(/)
using Mathematical_Operations;

Operations operations = new Operations();

int sum = operations.Sum(6, 8); // Here the public method is executed in the sum operation
Console.WriteLine("The sum is: "+sum);

Console.WriteLine("---------------------------------------------------------------------------------------------");

//int subtract = operations.Subtract(5, 3); // Here an error occurs because the subtract method is protected.
//Console.WriteLine("Subtraction is: "+subtract);

Console.WriteLine("---------------------------------------------------------------------------------------------");

int multiplication = operations.Multiplication(8, 10);
Console.WriteLine("Multiplication is: "+multiplication);

Console.WriteLine("---------------------------------------------------------------------------------------------");

//double divition = operations.Division(8, 2); // As the divide method is private, it cannot be accessed from outside the class.
//Console.WriteLine("Division is :"+divition);

Console.WriteLine("---------------------------------------------------------------------------------------------");
Console.ReadLine();
