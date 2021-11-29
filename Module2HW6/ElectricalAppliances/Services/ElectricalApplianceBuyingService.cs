using ElectricalAppliances.Models;
using ElectricalAppliances.Providers.Abstractions;
using ElectricalAppliances.Services.Abstractions;

namespace ElectricalAppliances.Services
{
    public class ElectricalApplianceBuyingService : IElectricalApplianceBuyingService
    {
        private readonly IElectricalApplianceBuyingProvider _electricalApplianceBuyingProvider;

        public ElectricalApplianceBuyingService(IElectricalApplianceBuyingProvider electricalApplianceBuyingProvider)
        {
            _electricalApplianceBuyingProvider = electricalApplianceBuyingProvider;
        }

        public ElectricalAppliance[] GetDevices()
        {
            return _electricalApplianceBuyingProvider.GetDevices();
        }
    }
}