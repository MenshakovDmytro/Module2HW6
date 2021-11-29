using System;
using System.Collections;
using ElectricalAppliances.Models;
using ElectricalAppliances.Services.Abstractions;

namespace ElectricalAppliances.Services
{
    public class SmartSocketService : ISmartSocketService
    {
        private ElectricalAppliance[] _electricalAppliances;

        public ElectricalAppliance[] ElectricalAppliances
        {
            get
            {
                var devices = new ElectricalAppliance[_electricalAppliances.Length];
                for (var i = 0; i < _electricalAppliances.Length; i++)
                {
                    devices[i] = _electricalAppliances[i];
                }

                return devices;
            }
        }

        public double CountPowerConsumption()
        {
            var totalPowerConsumption = 0D;
            for (var i = 0; i < _electricalAppliances.Length; i++)
            {
                totalPowerConsumption += _electricalAppliances[i].PowerConsumptionInkWh;
            }

            return totalPowerConsumption;
        }

        public void SortElectricalAppliances(IComparer comparer)
        {
            Array.Sort(_electricalAppliances, comparer);
        }

        public void PlugInAppliances(ElectricalAppliance[] electricalAppliances)
        {
            _electricalAppliances = electricalAppliances;
        }
    }
}