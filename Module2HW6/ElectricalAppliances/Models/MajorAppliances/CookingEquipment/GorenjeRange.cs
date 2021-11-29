namespace ElectricalAppliances.Models.MajorAppliances.CookingEquipment
{
    public class GorenjeRange : CookingEquip
    {
        public override bool CanBePlacedSeparatelyFromCooktop => false;

        public override string Model => "Gorenje EC 5341 SC";

        public override string Type => nameof(GorenjeRange);

        public override double PowerConsumptionInkWh => 2;
    }
}