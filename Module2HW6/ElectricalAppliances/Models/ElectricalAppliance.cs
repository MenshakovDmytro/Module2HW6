namespace ElectricalAppliances.Models
{
    public abstract class ElectricalAppliance
    {
        public double Price { get; set; }

        public abstract string Model { get; }

        public abstract string Type { get; }

        public abstract double PowerConsumptionInkWh { get; }

        public abstract bool IsPortable { get; }
    }
}