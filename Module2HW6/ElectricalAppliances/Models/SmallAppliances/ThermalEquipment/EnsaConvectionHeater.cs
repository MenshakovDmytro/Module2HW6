using ElectricalAppliances.Models.Enums;

namespace ElectricalAppliances.Models.SmallAppliances.ThermalEquipment
{
    public class EnsaConvectionHeater : ThermalEquip
    {
        public override HeaterType HeaterType => HeaterType.Convection;

        public override string Model => "ENSA Р500Е";

        public override string Type => nameof(EnsaConvectionHeater);

        public override double PowerConsumptionInkWh => 0.5;
    }
}