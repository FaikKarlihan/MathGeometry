public interface Area_Perimeter
{
    double GetArea();
    double GetPerimeter();
}
class Methods
{
    public void OfferMessage()
    {
        Console.Clear();
        Console.WriteLine("Please select the action you want to take\n");
        Console.WriteLine($"To calculate the area(1)");
        Console.WriteLine($"To calculate the perimeter(2)");
    }
    public string OperationSelection()
    {
        string reply;
        OfferMessage();
        reply = Console.ReadLine()?.Trim();
        while (!ReplyCheck(reply,"1","2"))
        {
            Console.WriteLine("Please choose one of the options offered!");
            reply = Console.ReadLine()?.Trim();
        }
        return reply;
    }
    public bool ReplyCheck(string reply, params string[] args)
    {
        foreach (string item in args)
        {
            if (reply.Equals(item))
            {
                return true;
            }
        }
        return false;
    }
    public int GetPozitiveInteger(string promt)
    {
        while (true)
        {
            Console.Write(promt);
            if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
            {
                return value;
            }
            Console.WriteLine("Please enter a valid positive number!");
        }
    }
    //FOR TRIANGLE /*
    public bool IsTriangleValid(int a, int b, int c) //valid triangle rule
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
    //FOR TRIANGLE */
    public double GetPozitiveDouble(string promt)
    {
        while (true)
        {
            Console.Write(promt);
            if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
            {
                return value;
            }
            Console.WriteLine("Please enter a valid positive number!");
        }
    }
}