using ElectricalAppliances.Services.Abstractions;

namespace ElectricalAppliances.Helper
{
    public class App
    {
        private readonly IElectricalApplianceBuyingService _electricalApplianceBuyingService;

        private readonly ISmartSocketService _smartSocketService;

        public App(IElectricalApplianceBuyingService electricalApplianceBuyingService, ISmartSocketService smartSocketService)
        {
            _electricalApplianceBuyingService = electricalApplianceBuyingService;
            _smartSocketService = smartSocketService;
        }

        public void SimulateWork()
        {
            var comparer = new ElectricalApplianceComparer();
            var devices = _electricalApplianceBuyingService.GetDevices();
            _smartSocketService.PlugInAppliances(devices);
            var totalPowerConsumption = _smartSocketService.CountPowerConsumption();
            _smartSocketService.SortElectricalAppliances(comparer);
            var appliance = _smartSocketService.ElectricalAppliances.FindApplianceByCriteria("TefalBlender", 0.4);
        }
    }
}