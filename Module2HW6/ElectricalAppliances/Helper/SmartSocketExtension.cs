using ElectricalAppliances.Models;

namespace ElectricalAppliances.Helper
{
    public static class SmartSocketExtension
    {
        public static ElectricalAppliance FindApplianceByCriteria(this ElectricalAppliance[] electricalAppliances, string type, double powerConsumption)
        {
            for (var i = 0; i < electricalAppliances.Length; i++)
            {
                if (electricalAppliances[i].Type.Equals(type) && electricalAppliances[i].PowerConsumptionInkWh.Equals(powerConsumption))
                {
                    return electricalAppliances[i];
                }
            }

            return null;
        }
    }
}