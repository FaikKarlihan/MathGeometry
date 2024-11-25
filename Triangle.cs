class Triangle :Area_Perimeter
{
    private double sideA, sideB, sideC;
    private GetTriangle triangleInput = new GetTriangle(); // get sides of triangle
    public Triangle()
    {
        triangleInput.GetTriangleSides();
        sideA = triangleInput.SideA;
        sideB = triangleInput.SideB;
        sideC = triangleInput.SideC;
    }
    public double GetArea() //heron formula
    {
        double s = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(s* (s-sideA) * (s-sideB) * (s-sideC));
        return area;
    }
    public double GetPerimeter()
    {
        double perimeter = sideA + sideB + sideC;
        return perimeter;
    }
}