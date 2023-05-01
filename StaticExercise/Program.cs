namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Celsius = TempConverter.FahrenheitToCelsius(50);
            var Fahrenheit = TempConverter.CelsiusToFahrenheit(21);

            Console.WriteLine("after conversion");
            Console.WriteLine($"Celsius {Celsius}");
            Console.WriteLine($"Fahrenheit {Fahrenheit}");
        }
    }
}
