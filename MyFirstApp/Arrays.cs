class Arrays 
{
    public static void main(String[] args)
    {
        string[] bagitems = new string [5];
        bagitems[0] = "Knife";   
        bagitems[1] = "Sword";
        bagitems[2] = "health";

        string[] names = {"Alice", "Bob", "Charlie"};
        Console.WriteLine(bagitems[0][2]);

        int[] grades = new int[5];
        grades[0] = 85;
        grades[1] = 90;
        grades[2] = 78;
        grades[3] = 92;
        grades[4] = 88;

        Console.WriteLine("Grades: ");
        for(int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine(grades[0]);
        }

    }
}