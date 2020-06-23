using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Entities
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Engine { get; set; }
        public string GearBox { get; set; }
        public int YOM { get; set; }
        public int MY { get; set; }
        public long OriginalPrice { get; set; }

    }
}
