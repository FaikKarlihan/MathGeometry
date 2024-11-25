class Rectangle:Area_Perimeter
{
    public int SideA, SideB;
    GetRectangle rec = new GetRectangle();
    public Rectangle()
    {
        rec.GetRectangleSides();
        SideA = rec.SideA;
        SideB = rec.SideB;
        if (SideA==SideB)
        {
            Console.WriteLine("This is a square!...press any key");
            Console.ReadKey();
        }
    }
    public double GetArea()
    {
        double area = SideA * SideB;
        return area;
    }
    public double GetPerimeter()
    {
        double perimeter = 2*(SideA+SideB);
        return perimeter;
    }
}