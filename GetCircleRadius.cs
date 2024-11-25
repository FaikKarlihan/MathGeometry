class GetCircle:Methods
{
    public double Radius{get; private set;}
    public void GetCircleRadius()
    {
        Console.Clear();
        Console.WriteLine("Please enter radius for circle.");
        Radius = GetPozitiveDouble("Radius: ");
    }
}