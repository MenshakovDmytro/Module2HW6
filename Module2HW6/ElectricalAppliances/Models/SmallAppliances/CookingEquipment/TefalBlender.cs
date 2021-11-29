using ElectricalAppliances.Models.SmallAppliances.BeverageEquipment;

namespace ElectricalAppliances.Models.SmallAppliances.CookingEquipment
{
    public class TefalBlender : CookingEquip
    {
        public override bool NeedLiquidForWork => true;

        public override string Model => "TEFAL BL91HD31";

        public override string Type => nameof(TefalBlender);

        public override double PowerConsumptionInkWh => 0.4;
    }
}