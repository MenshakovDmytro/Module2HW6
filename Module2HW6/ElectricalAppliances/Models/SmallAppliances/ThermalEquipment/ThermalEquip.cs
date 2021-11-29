using ElectricalAppliances.Models.Enums;

namespace ElectricalAppliances.Models.SmallAppliances.ThermalEquipment
{
    public abstract class ThermalEquip : SmallAppliance
    {
        public override HouseholdTask HouseholdTask => HouseholdTask.ThermalComfort;

        public abstract HeaterType HeaterType { get; }
    }
}