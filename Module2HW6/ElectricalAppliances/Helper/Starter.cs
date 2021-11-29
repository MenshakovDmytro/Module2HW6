using ElectricalAppliances.Providers;
using ElectricalAppliances.Providers.Abstractions;
using ElectricalAppliances.Services;
using ElectricalAppliances.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ElectricalAppliances.Helper
{
    public class Starter
    {
        public void Run()
        {
            var start = new ServiceCollection()
                .AddTransient<IElectricalApplianceBuyingProvider, ElectricalApplianceBuyingProvider>()
                .AddTransient<IElectricalApplianceBuyingService, ElectricalApplianceBuyingService>()
                .AddTransient<ISmartSocketService, SmartSocketService>()
                .AddTransient<App>()
                .BuildServiceProvider();
            var app = start.GetService<App>();
            app.SimulateWork();
        }
    }
}