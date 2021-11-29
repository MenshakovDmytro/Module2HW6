using ElectricalAppliances.Models.Enums;

namespace ElectricalAppliances.Models.SmallAppliances.BeverageEquipment
{
    public abstract class CookingEquip : SmallAppliance
    {
        public override HouseholdTask HouseholdTask => HouseholdTask.Cooking;

        public abstract bool NeedLiquidForWork { get; }
    }
}