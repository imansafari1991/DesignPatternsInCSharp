using Example1;

Console.WriteLine("***Decorator pattern Demo***\n");
#region Scenario-1
Console.WriteLine("\n**Scenario-1:");
Console.WriteLine("**Building home.Adding floor and then painting it.* *");

AbstractHome home = new ConcreteHome();
Console.WriteLine("Current bill breakups are as follows:");
home.MakeHome();
// Applying a decorator
// Adding a floor
home = new FloorDecorator(home);
Console.WriteLine("\nFloor added.Current bill breakups are as follows: ");

home.MakeHome();
// Working on top of the previous decorator.
// Painting the home
home = new PaintDecorator(home);
Console.WriteLine("\nPaint applied.Current bill breakups are as follows: ");
home.MakeHome();
#endregion
#region Scenario-2
Console.WriteLine("\n**Scenario-2:");
Console.WriteLine("**Building home,painting it and then adding two additional floors on top of it.* *");
// Fresh start once again.
home = new ConcreteHome();
Console.WriteLine("\nGoing back to original home.Current bill breakups are as follows:");

home.MakeHome();
// Applying paint on original home.
home = new PaintDecorator(home);
Console.WriteLine("\nPaint applied.Current bill breakups are as follows: ");

home.MakeHome();
// Adding a floor on the painted home.
home = new FloorDecorator(home);
Console.WriteLine("\nFloor added.Current bill breakups are as follows: ");

home.MakeHome();
// Adding another floor on the current home.
home = new FloorDecorator(home);
Console.WriteLine("\nFloor added.Current bill breakups are as follows: ");

home.MakeHome();
#endregion
Console.ReadKey();