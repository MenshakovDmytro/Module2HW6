using System.Collections;
using ElectricalAppliances.Models;

namespace ElectricalAppliances.Services.Abstractions
{
    public interface ISmartSocketService
    {
        public ElectricalAppliance[] ElectricalAppliances { get; }

        public double CountPowerConsumption();

        public void SortElectricalAppliances(IComparer comparer);

        public void PlugInAppliances(ElectricalAppliance[] electricalAppliances);
    }
}