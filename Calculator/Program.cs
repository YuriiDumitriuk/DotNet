while (true) 
{
    Console.WriteLine("Please enter the first number:");
    var firstInput = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Choose an operation (+, -, *, /) and enter it here:");
    var operation = Console.ReadLine();
    Console.WriteLine("Please enter the second number:");
    var secondInput = Convert.ToDouble(Console.ReadLine());
    double result = operation switch
    {
        "+" => firstInput + secondInput,
        "-" => firstInput - secondInput,
        "*" => firstInput * secondInput,
        "/" when secondInput != 0 => firstInput / secondInput,
        "/" when secondInput == 0 => throw new Exception("You cannot divide by zero"),
        _ => throw new ArgumentException("Operation unknown"),
    };
    Console.WriteLine("Your result " + result);
    Console.WriteLine("Do you want to continue? y or n :");
    var continuing = Console.ReadLine();
    if (continuing == "y")
    {
        firstInput = result;
    }
    return;
    
}


