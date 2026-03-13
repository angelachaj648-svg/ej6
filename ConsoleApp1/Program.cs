double fahrenheit = CelsiusFahrenheit(25);
Console.WriteLine("Fahrenheit: " + fahrenheit);
static double CelsiusFahrenheit(double c)
{
	return (c * 9 / 5) + 32;
}