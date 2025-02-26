bool repeat = true;
double result=0;
Console.WriteLine("Please enter the first number:");
var firstInput = Convert.ToDouble(Console.ReadLine());
while (repeat) 
{
    Console.WriteLine("Choose an operation (+, -, *, /) and enter it here:");
    var operation = Console.ReadLine();
    Console.WriteLine("Please enter the second number:");
    var secondInput = Convert.ToDouble(Console.ReadLine());
    
    switch (operation)
    {
        case "+":
            result = firstInput + secondInput;
            Console.WriteLine("Your result " + result);
            break;
        case "-":
            result = firstInput - secondInput;
            Console.WriteLine("Your result " + result);
            break;
        case "/":
            result = firstInput / secondInput;
            Console.WriteLine("Your result " + String.Format("{0:0.00}", result));
            break;
        case "*":
            result = firstInput * secondInput;
            Console.WriteLine("Your result " + result);
            break;
    }
    Console.WriteLine("Do you want to continue? y or n :");
    var continuing = Console.ReadLine();
    if (continuing == "y")
    {
        firstInput = result;
    }
    else
    {
        repeat = false;
    }
}
