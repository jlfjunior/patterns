namespace Patterns.Models.Builder
{
    public class Director
    {
        public VehicleBuilder VehicleBuilder;

        public Director(VehicleBuilder vehicleBuilder)
        {
            VehicleBuilder = vehicleBuilder;
        }
    }
}