namespace ElectricalAppliances.Models.MajorAppliances.RefregerationEquipment
{
    public class SamsungFreezer : RefregerationEquip
    {
        public override bool MaintainsTemperatureBelowFreezingPointOfWater => true;

        public override string Model => "Samsung RZ32M7110SA";

        public override string Type => nameof(SamsungFreezer);

        public override double PowerConsumptionInkWh => 0.7;
    }
}