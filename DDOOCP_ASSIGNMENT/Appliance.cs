using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDOOCP_ASSIGNMENT
{
    public class Appliance
    {
        public int ApplianceID { get; set; }
        public string ApplianceType { get; set; }
        public string ApplianceBrand { get; set; }
        public string Model { get; set; }
        public string Dimensions { get; set; }
        public string Colour { get; set; }
        public string EnergyConsumption { get; set; }
        public decimal MonthlyFee { get; set; }

        public override string ToString()
        {
            return $"{ApplianceID} - {ApplianceType} - {ApplianceBrand} - {Model} - {Dimensions} - {Colour} - {EnergyConsumption} - {MonthlyFee}";
        }

    }
}
