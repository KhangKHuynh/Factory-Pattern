namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in the amount of wheels you want!");
            int wheelCount;
            var input = int.TryParse(Console.ReadLine(), out wheelCount);
            
            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
                
        }
        
    }
}
