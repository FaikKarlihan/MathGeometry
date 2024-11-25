class GetRectangle:Methods
{
    public int SideA{get; private set;}
    public int SideB{get; private set;}
    public void GetRectangleSides()
    {
        Console.Clear();
        Console.WriteLine("Please enter the side dimensions of the rectangle.");
        SideA=GetPozitiveInteger("SideA: ");
        SideB=GetPozitiveInteger("SideB: ");
    }
}