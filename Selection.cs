class Selection:Methods
{
    public void SelectedShape(string shape)
    {
        string reply;
        char key = '0';
        
        do
        {
            switch (shape)
            {
                case "Triangle":
                Triangle tri = new Triangle();
                reply = OperationSelection();
                if (reply=="1")
                {
                    Console.Clear();
                    Console.WriteLine("Area of triangle: " + tri.GetArea());
                }  
                if (reply=="2")
                {
                    Console.Clear();
                    Console.WriteLine("Perimeter of triangle: " + tri.GetPerimeter());
                }
                break;


                case "Circle":
                Circle circ = new Circle();
                reply = OperationSelection();
                if (reply=="1")
                {
                    Console.Clear();
                    Console.WriteLine("Area of Cirlce: " + circ.GetArea());
                }  
                if (reply=="2")
                {
                    Console.Clear();
                    Console.WriteLine("Perimeter of Circle: " + circ.GetPerimeter());
                }
                break;


                case "Rectangle":
                Rectangle rec = new Rectangle();
                reply = OperationSelection();
                if (reply=="1")
                {
                    Console.Clear();
                    Console.WriteLine("Area of Rectangle: " + rec.GetArea());
                }  
                if (reply=="2")
                {
                    Console.Clear();
                    Console.WriteLine("Perimeter of Rectangle: " + rec.GetPerimeter());
                }                
                break;
            }


            Console.WriteLine("\nPress (1) to try again, or any other key to exit.");
            key = Console.ReadKey(false).KeyChar;
            Console.ReadLine();

        }while (key == '1');
    }
}

