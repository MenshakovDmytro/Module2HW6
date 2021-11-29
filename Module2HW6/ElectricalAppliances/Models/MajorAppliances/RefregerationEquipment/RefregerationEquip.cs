using ElectricalAppliances.Models.Enums;

namespace ElectricalAppliances.Models.MajorAppliances.RefregerationEquipment
{
    public abstract class RefregerationEquip : MajorAppliance
    {
        public override HousekeepingTask HousekeepingTask => HousekeepingTask.FoodPreservation;

        public abstract bool MaintainsTemperatureBelowFreezingPointOfWater { get; }
    }
}