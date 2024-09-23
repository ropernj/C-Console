using System.Runtime.CompilerServices;

class If
{
    // public static void IfElse(int number)
    // {
    //     // int number = 5;

    //     if (number > 0)
    //     {
    //         Console.WriteLine("The number is positive.");
    //     }
    //     else if (number < 0)
    //     {
    //         Console.WriteLine("The number is negative");
    //     }
    //     else 
    //     {
    //         Console.WriteLine("The number is zero.");
    //     }
    // }
    public static void Health(int number)
    {
        if( number > 75)
        {
            Console.WriteLine("This player is in great condition!");
        }
        else if ( number > 50)
        {
            Console.WriteLine("This player is in good condition");
        }
        else if (number > 0)
        {
            Console.WriteLine("This player is in danger!");
        }
        else
        {
            Console.WriteLine("Game Over");
        }

    }


}