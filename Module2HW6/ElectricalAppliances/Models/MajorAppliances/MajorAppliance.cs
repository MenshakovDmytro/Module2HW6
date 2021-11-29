using ElectricalAppliances.Models.Enums;

namespace ElectricalAppliances.Models.MajorAppliances
{
    public abstract class MajorAppliance : ElectricalAppliance
    {
        public override bool IsPortable => false;

        public abstract HousekeepingTask HousekeepingTask { get; }
    }
}