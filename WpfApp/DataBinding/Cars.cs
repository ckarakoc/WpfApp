namespace WpfApp.DataBinding;

public class Cars
{
    public static List<Car> GetCars()
    {
        // data-source (i.e. Database)
        return new List<Car>()
        {
            new Car() {Owner = "Mike", Type = CarType.Hatchback, Branding = CarBranding.VW},
            new Car() {Owner = "Emma", Type = CarType.Sedan, Branding = CarBranding.Tesla},
            new Car() {Owner = "John", Type = CarType.SUV, Branding = CarBranding.BMW}
        }.ToList();
    }
}