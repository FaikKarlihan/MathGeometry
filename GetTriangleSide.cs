class GetTriangle:Methods
{
    public int SideA { get; private set; }
    public int SideB { get; private set; }
    public int SideC { get; private set; }
    public void GetTriangleSides()
    {
        Console.Clear();
        Console.WriteLine("Please enter the side dimensions of the triangle.");

        while (true)
        {
            SideA = GetPozitiveInteger("Side A: ");
            SideB = GetPozitiveInteger("Side B: ");
            SideC = GetPozitiveInteger("Side C: ");

            if (!IsTriangleValid(SideA, SideB, SideC))
            {
                Console.Clear();
                Console.WriteLine("The entered sides do not form a valid triangle! Please try again.");
            }
            else
            {
                break;
            }            
        }
    }
}