using ElectricalAppliances.Models.SmallAppliances.BeverageEquipment;

namespace ElectricalAppliances.Models.SmallAppliances.CookingEquipment
{
    public class CuisinartFoodProcessor : CookingEquip
    {
        public override bool NeedLiquidForWork => false;

        public override string Model => "Cuisinart FP8SE";

        public override string Type => nameof(CuisinartFoodProcessor);

        public override double PowerConsumptionInkWh => 0.4;
    }
}