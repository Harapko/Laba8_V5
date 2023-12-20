namespace Laba_8_V5;

public class TPPiramid : TPTriangle
{
    private double _height;

    public TPPiramid(double height)
    {
        _height = height;
    }

    public TPPiramid()
    {
        _height = 5;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Enter height: ");
        _height = double.Parse(Console.ReadLine());
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Height is {_height}");
    }

    public override double Area()
    {
        double firstHypotenuse = Math.Sqrt(Math.Pow(_firstCat, 2) + Math.Pow(_secondCat, 2));
        double secondHypotenuse = Math.Sqrt(Math.Pow(_firstCat, 2) + Math.Pow(_height, 2));
        double thirdHypotenuse = Math.Sqrt(Math.Pow(_secondCat, 2) + Math.Pow(_height, 2));
        double firstTriangleArea = (_firstCat * _height) / 2;
        double secondTriangleArea = (_secondCat * _height) / 2;
        double p = (firstHypotenuse + secondHypotenuse + thirdHypotenuse) / 2;
        double thirdTriangleArea =
            Math.Sqrt(p * (p - firstHypotenuse) * (p - secondHypotenuse) * (p - thirdHypotenuse));
        return base.Area() + firstTriangleArea + secondTriangleArea + thirdTriangleArea;
    }


    public override double Perimeter()
    {
        double firstHypotenuse = Math.Sqrt(Math.Pow(_firstCat, 2) + Math.Pow(_secondCat, 2));
        double secondHypotenuse = Math.Sqrt(Math.Pow(_firstCat, 2) + Math.Pow(_height, 2));
        double thirdHypotenuse = Math.Sqrt(Math.Pow(_secondCat, 2) + Math.Pow(_height, 2));
        return (firstHypotenuse + secondHypotenuse + thirdHypotenuse) + (_firstCat + _height + firstHypotenuse) +
               (_secondCat + _height + secondHypotenuse) + base.Perimeter();
    }

    public override bool Similar(TPTriangle a) =>
        Area().Equals(a.Area());

    public double Capacity() =>
        (base.Area() * _height)/3;
}