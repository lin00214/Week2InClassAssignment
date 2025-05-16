public class Engine
{
    public int HorsePower { get; set; }
}

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public void Describe()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Engine Horsepower: {Engine.HorsePower}");
    }
}