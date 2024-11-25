class Circle:Area_Perimeter
{
    private double Radius;
    private GetCircle circleInput = new GetCircle();
    public Circle()
    {
        circleInput.GetCircleRadius();
        Radius=circleInput.Radius;
    }
    public double GetArea()
    {
        double area = Math.Pow(Radius, 2)*Math.PI;
        return area;
    }
    public double GetPerimeter()
    {
        double perimeter = 2 * Radius * Math.PI;
        return perimeter;
    }
}