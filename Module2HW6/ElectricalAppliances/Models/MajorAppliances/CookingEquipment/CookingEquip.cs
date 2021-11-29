using ElectricalAppliances.Models.Enums;

namespace ElectricalAppliances.Models.MajorAppliances.CookingEquipment
{
    public abstract class CookingEquip : MajorAppliance
    {
        public override HousekeepingTask HousekeepingTask => HousekeepingTask.Cooking;

        public abstract bool CanBePlacedSeparatelyFromCooktop { get; }
    }
}