///-----------------------------------------------------------------
///   Description:  Fizz Buzz Game Challenge in C#
///   Author:       Leon Goodwin
///   Date:         19 April, 2024
///-----------------------------------------------------------------

//Loop
for (int i=1 ;i<=100 ; i++) 
{
    //Check If Divisble By 3
    if (i % 3 == 0)
    {
        //Check If Divisble By 5 And 3
        if (i % 5 == 0)
        {
            //Write FizzBuzz If Divisble By 3 & 5
            Console.WriteLine("FizzBuzz");
        }
        else
        {
            //Write Fizz If Only Divisble By 3
            Console.WriteLine("Fizz");
        }
    }
    //Check If Divisble By 5
    else if (i % 5 == 0)
    {
        //Write Fizz If Only Divisble By 5
        Console.WriteLine("Buzz");
    }
    else
    {
        //Output If Not Divisble By 5 Or 3
        Console.WriteLine(i);
    }
}
