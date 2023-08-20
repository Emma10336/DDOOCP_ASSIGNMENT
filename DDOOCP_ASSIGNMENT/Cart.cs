using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDOOCP_ASSIGNMENT
{
    internal class Cart
    {
            public string UserID { get; set; }
            public List<Appliance> SelectedAppliances { get; set; }

            // Constructor
            public Cart()
            {
                SelectedAppliances = new List<Appliance>();
            }
        
    }
}
