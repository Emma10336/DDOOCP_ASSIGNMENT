using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDOOCP_ASSIGNMENT
{
    public class Orders : Appliance
    {
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public int Length { get; set; }
        public decimal Total { get; set; }

        // Add a property to store the associated Appliance object
        public Appliance Appliance { get; set; }

        public override string ToString()
        {
            // Customize the string representation of the order
            // For example, you can show the OrderID and the Appliance Brand
            return $"Order ID: {OrderID}, Appliance: {Appliance?.ApplianceBrand}, Length: {Length}, Total: {Total}";

        }
    }
}
