Selection _selection = new Selection();
Methods newmeth = new Methods();

while (true)
{
    Console.Clear();
    Console.WriteLine("Welcome to Simple Math App!");
    Console.WriteLine("Please make a choice...");
    Console.WriteLine("Which geometric shape do you want to work with?");
    Console.WriteLine("-----------------------------------------------\n");
    Console.WriteLine("Triangle(1)\nCircle(2)\nRectangle(3)\nExit(0)");
    string reply = Console.ReadLine();
    while (!newmeth.ReplyCheck(reply,"1","2","3","0"))
    {
        Console.WriteLine("Please choose one of the options offered!");
        reply = Console.ReadLine();
    }

    switch (reply)
    {
        case "1":
        _selection.SelectedShape("Triangle");
        break;

        case "2":
        _selection.SelectedShape("Circle");
        break;

        case "3":
        _selection.SelectedShape("Rectangle");
        break;

        case "0":
        Environment.Exit(0);
        break;
    }
}

