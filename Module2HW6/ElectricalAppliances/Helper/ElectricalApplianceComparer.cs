using System.Collections;
using ElectricalAppliances.Models;

namespace ElectricalAppliances.Helper
{
    public class ElectricalApplianceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var firstItem = x as ElectricalAppliance;
            var secondItem = y as ElectricalAppliance;
            return firstItem.PowerConsumptionInkWh.CompareTo(secondItem.PowerConsumptionInkWh);
        }
    }
}