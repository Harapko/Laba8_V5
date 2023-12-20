namespace Laba_8_V5;

public class TPTriangle
{
    protected double _firstCat;
    protected double _secondCat;

    public TPTriangle()
    {
        _firstCat = 3;
        _secondCat = 4;
    }
    
    public TPTriangle(double firstCat, double secondCat)
    {
        _firstCat = firstCat;
        _secondCat = secondCat;
    }

    public TPTriangle(TPTriangle a)
    {
        _firstCat = a._firstCat;
        _secondCat = a._secondCat;
    }

    public virtual void Input()
    {
        Console.Write("Enter first cat: ");
        _firstCat = double.Parse(Console.ReadLine());
        Console.Write("Enter second cat: ");
        _secondCat = double.Parse(Console.ReadLine());
    }

    public virtual void Output() =>
        Console.WriteLine($"First cat is {_firstCat}\nSecond cat is {_secondCat}");

    public virtual double Area() =>
        (_firstCat * _secondCat) / 2;

    public virtual double Perimeter() =>
        Math.Sqrt(Math.Pow(_firstCat, 2) + Math.Pow(_secondCat, 2)) + _firstCat + _secondCat;

    public virtual bool Similar(TPTriangle a) =>
        Area().Equals(a.Area());

    public static TPTriangle operator +(TPTriangle a, TPTriangle b) =>
        new TPTriangle(a._firstCat + b._firstCat, a._secondCat + b._secondCat);
    
    public static TPTriangle operator -(TPTriangle a, TPTriangle b) =>
        new TPTriangle(a._firstCat - b._firstCat, a._secondCat - b._secondCat);

    public static TPTriangle operator *(TPTriangle a, double b) =>
        new TPTriangle(a._firstCat * b, a._secondCat * b);

    public override string ToString() =>
        $"First cat is {_firstCat}\nSecond cat is {_secondCat}";
}