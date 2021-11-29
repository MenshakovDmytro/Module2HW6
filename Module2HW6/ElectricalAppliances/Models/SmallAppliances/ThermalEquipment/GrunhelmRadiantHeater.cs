using ElectricalAppliances.Models.Enums;

namespace ElectricalAppliances.Models.SmallAppliances.ThermalEquipment
{
    public class GrunhelmRadiantHeater : ThermalEquip
    {
        public override HeaterType HeaterType => HeaterType.Radiant;

        public override string Model => "Grunhelm GI-2300S";

        public override string Type => nameof(GrunhelmRadiantHeater);

        public override double PowerConsumptionInkWh => 0.6;
    }
}