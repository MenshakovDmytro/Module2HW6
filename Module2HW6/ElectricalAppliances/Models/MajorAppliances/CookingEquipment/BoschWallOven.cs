namespace ElectricalAppliances.Models.MajorAppliances.CookingEquipment
{
    public class BoschWallOven : CookingEquip
    {
        public override bool CanBePlacedSeparatelyFromCooktop => true;

        public override string Model => "Bosch HBJ558YW0Q";

        public override string Type => nameof(BoschWallOven);

        public override double PowerConsumptionInkWh => 4;
    }
}