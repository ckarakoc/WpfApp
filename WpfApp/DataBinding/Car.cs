namespace WpfApp.DataBinding;

public class Car
{
    public required string Owner { get; set; }
    public required CarType Type { get; set; }
    public required CarBranding Branding { get; set; }
}