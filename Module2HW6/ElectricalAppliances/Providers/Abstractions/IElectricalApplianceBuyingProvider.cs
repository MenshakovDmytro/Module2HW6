using ElectricalAppliances.Models;

namespace ElectricalAppliances.Providers.Abstractions
{
    public interface IElectricalApplianceBuyingProvider
    {
        public ElectricalAppliance[] GetDevices();
    }
}