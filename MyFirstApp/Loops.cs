using System.Globalization;

class Loops
{
    // public static void Forloop()
    // {
    //     for(int i = 1; i <= 10; i++)
    //     {
    //         Console.WriteLine("Iteration " + i);
    //     }
    // }
    // public static void Evenloop()
    // {
    //     for(int i = 1; i <= 20; i++)
    //     {
    //         if(i % 2 == 0)
    //         {
    //             Console.WriteLine(i);
    //         }
    //     }
    // }
    // public static void WhileLoop()
    // {
    //     int health = 100;
    //     while(health > 0)
    //     {
    //         Console.WriteLine("Player is alive with health: " + health);
    //         health -= 10;
    //     }
    // }
    // public static void Mygold()
    // {
    //     int gold = 0;
    //     while(gold < 100)
    //     {
    //         gold += 10;
    //         Console.WriteLine("I got more Gold! " + gold + " pieces!");
    //     }
    // }
    public static void NestedLoops()
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Iteration i:" + i);
            for(int j = 0; j <= 3; j++)
            {
                Console.WriteLine("     Iteration j: " + j);
                for(int k = 0; k <= 1; k++)
                {
                    Console.WriteLine("   Iteration k: " + k);
                }
            }
        }
    }
}