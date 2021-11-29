using ElectricalAppliances.Models;

namespace ElectricalAppliances.Services.Abstractions
{
    public interface IElectricalApplianceBuyingService
    {
        public ElectricalAppliance[] GetDevices();
    }
}