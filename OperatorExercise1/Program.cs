var a = 17;
var b = 4;
var answer = a / b;
var remainder = a % b;

Console.WriteLine($"{a} / {b} is {answer} with a remainder of {remainder}");

Console.WriteLine("Please enter the radius of your circle: ");
var radius = double.Parse(Console.ReadLine());



static double AreaOfCircle(double radius)
{
    var area = Math.PI * Math.Pow(radius, 2);

    return area;
}

Console.WriteLine(AreaOfCircle(radius));