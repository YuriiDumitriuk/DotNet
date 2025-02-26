Console.WriteLine("Please enter the first number:");
var firstInput = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choose an operation (+, -, *, /) and enter it here:");
var operation = Console.ReadLine();
Console.WriteLine("Please enter the second number:");
var secondInput = Convert.ToDouble(Console.ReadLine());
switch (operation)
{
    case "+":
        Console.WriteLine("Your result " + (firstInput + secondInput));
        break;
    case "-":
        Console.WriteLine("Your result " + (firstInput - secondInput));
        break;
    case "/":
        Console.WriteLine("Your result " + String.Format("{0:0.00}", (firstInput / secondInput)));
        break;
    case "*":
        Console.WriteLine("Your result " + (firstInput * secondInput));
        break;
}