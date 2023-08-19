
do
{
    Console.WriteLine("which number is greater");
    Console.WriteLine("======================================================");
    Console.WriteLine("Enter integer numbers or Ctrl + C to exit the program.");
    int a = GetNumber("a? ");
    int b = GetNumber("b? ");
    int c = GetNumber("c? ");
    // && and, || or, ! not
    //if (a > b)
    //{
    //    if (a > c)    
    //    {
    //        Console.WriteLine($"The greater number is a =  {a}");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"The greater number is c = {c}");
    //    }
    //}
    //else
    //{
    //    if (b > c)
    //    {
    //        Console.WriteLine($"The greater number is b = {b}");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"The greater number is c =  {c}");
    //    }
    //}
    if (a > b && a > c)
    {
        Console.WriteLine($"The greater number is a =  {a}");
        if (b > c)
        {
            Console.WriteLine($"The number in the middle is b = {b}");
            Console.WriteLine($"the smaller number is c = {c}");
        }

        else
        {
            Console.WriteLine($"The number in the middle is c = {c}");
            Console.WriteLine($"the smaller number is b = {b}");
        }
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"The greater number is b =  {b}");
        if (a > c)
        {
            Console.WriteLine($"The number in the middle is a = {a}");
            Console.WriteLine($"the smaller number is c = {c}");
        }
        else
        {
            Console.WriteLine($"The number in the middle is c = {c}");
            Console.WriteLine($"the smaller number is b = {a}");
        }
    }
    else
    {
        Console.WriteLine($"The greater number is c =  {c}");
        if (a > b)
        {
            Console.WriteLine($"The number in the middle is a = {a}");
            Console.WriteLine($"the smaller number is b = {b}");
        }
        else
        {
            Console.WriteLine($"The number in the middle is b = {b}");
            Console.WriteLine($"the smaller number is  a= {a}");
        }
    }

    // To format code use Ctrl + K, D
    Console.WriteLine("----------------------------------------------");
} while (true);

int GetNumber(string message)
{
    Console.Write(message);
    var numberString = Console.ReadLine();
    try
    {
        var number = Convert.ToInt32(numberString);
        return number;
    }
    catch
    {
        Console.WriteLine($"The input: '{numberString}' can't conver to a interger number.");
        return -9999999;
    }
}