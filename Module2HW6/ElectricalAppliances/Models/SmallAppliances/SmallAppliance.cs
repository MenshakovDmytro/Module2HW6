using ElectricalAppliances.Models.Enums;

namespace ElectricalAppliances.Models.SmallAppliances
{
    public abstract class SmallAppliance : ElectricalAppliance
    {
        public override bool IsPortable => true;

        public abstract HouseholdTask HouseholdTask { get; }
    }
}