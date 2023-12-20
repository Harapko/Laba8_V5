using Laba_8_V5;

TPPiramid pyramid2 = new TPPiramid(5);
TPPiramid pyramid = new TPPiramid();

TPTriangle triangle = new TPTriangle(3, 4);
TPTriangle triangle2 = new TPTriangle();



Console.Clear();
triangle.Input();
triangle.Output();
Console.WriteLine($"\nArea is {triangle.Area()}");
Console.WriteLine($"Perimeter is {triangle.Perimeter()}");
Console.WriteLine($"\nTriangle similar is {triangle.Similar(triangle2)}");
Console.WriteLine($"\nOperator +: {triangle + triangle2}");
Console.WriteLine($"Operator -: {triangle - triangle2}");
Console.WriteLine($"Operator *: {triangle * 3}");
Console.Write("Press any key...");
Console.ReadKey();

Console.Clear();



pyramid.Input();
Console.Clear();
pyramid.Output();
Console.WriteLine($"\nArea is {pyramid.Area()}");
Console.WriteLine($"Perimeter is {pyramid.Perimeter()}");
Console.WriteLine($"Capacity is {pyramid.Capacity()}");
Console.WriteLine($"\nTriangle similar is {pyramid.Similar(pyramid2)}");