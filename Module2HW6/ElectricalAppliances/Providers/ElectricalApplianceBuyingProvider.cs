using ElectricalAppliances.Models;
using ElectricalAppliances.Models.MajorAppliances.CookingEquipment;
using ElectricalAppliances.Models.MajorAppliances.RefregerationEquipment;
using ElectricalAppliances.Models.SmallAppliances.CookingEquipment;
using ElectricalAppliances.Providers.Abstractions;

namespace ElectricalAppliances.Providers
{
    public class ElectricalApplianceBuyingProvider : IElectricalApplianceBuyingProvider
    {
        public ElectricalAppliance[] GetDevices()
        {
            var appliances = new ElectricalAppliance[6];
            appliances[0] = new BoschWallOven() { Price = 10000 };
            appliances[1] = new GorenjeRange() { Price = 10888 };
            appliances[2] = new BoschRefrigerator() { Price = 15800 };
            appliances[3] = new CuisinartFoodProcessor() { Price = 4890 };
            appliances[4] = new TefalBlender() { Price = 7000 };
            appliances[5] = new TefalBlender() { Price = 7000 };
            return appliances;
        }
    }
}