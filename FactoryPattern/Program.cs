namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" How many tires of type of vehicle you want to create???:");
            int wheelCount;

            var input = int.TryParse(Console.ReadLine(), out wheelCount);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
            
        }
    }
}
