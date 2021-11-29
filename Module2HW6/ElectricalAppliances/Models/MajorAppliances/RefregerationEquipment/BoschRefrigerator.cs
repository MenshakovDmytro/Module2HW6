namespace ElectricalAppliances.Models.MajorAppliances.RefregerationEquipment
{
    public class BoschRefrigerator : RefregerationEquip
    {
        public override bool MaintainsTemperatureBelowFreezingPointOfWater => false;

        public override string Model => "Bosch KGN39XI326";

        public override string Type => nameof(BoschRefrigerator);

        public override double PowerConsumptionInkWh => 0.6;
    }
}