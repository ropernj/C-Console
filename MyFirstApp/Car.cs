class Car
{
    public string model = "Ford";
    public int speed = 50;
    public static void Drive(string model, int speed)
    {
        Console.WriteLine("The " + model + " is driving at " + speed + " mph");
    }
}