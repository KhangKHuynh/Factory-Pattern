namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int wheelCount)
    {
        switch (wheelCount)
        {
            case 2: return new Motorcycle();
            case 3: return new Truck();
            case 4: return new Car();
            default: return new Car(); 
        }
    }
}