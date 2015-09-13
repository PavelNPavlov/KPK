public class Car
{
    public Car()
    {
    }

    public int Wheels { get; set; }

    public string Colour { get; set; }
}

//The builder abstraction
public interface ICarBuilder
{
    void SetColour(string colour);

    void SetWheels(int count);

    Car GetResult();
}

//Concrete builder implementation
public class CarBuilder : ICarBuilder
{
    private Car _car;

    public CarBuilder()
    {
        this._car = new Car();
    }

    public void SetColour(string colour)
    {
        this._car.Colour = colour;
    }

    public void SetWheels(int count)
    {
        this._car.Wheels = count;
    }

    public Car GetResult()
    {
        return this._car;
    }
}

//The director
public class CarBuildDirector
{
    public Car Construct()
    {
        CarBuilder builder = new CarBuilder();

        builder.SetColour("Red");
        builder.SetWheels(4);

        return builder.GetResult();
    }
}