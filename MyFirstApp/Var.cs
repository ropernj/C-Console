class Var
{
    public static void MyVar()
    {
        string helloWorld = "Hello World";

        Console.WriteLine(helloWorld);
    }
    public static void DataTypes()
    {
        string firstName = "Natalie";
        string lastName = "Roper";
        
        string myName = firstName + " " + lastName;
        int age = 16;
        float gpa = 5.03f;
        bool is_Student = true;

        double length = 2.6;
        decimal dollar = 100.98m;

        Console.WriteLine(myName);
        Console.WriteLine(age);
        Console.WriteLine(gpa);
        Console.WriteLine(is_Student);
        Console.WriteLine(length);
        Console.WriteLine(dollar);
    }
}