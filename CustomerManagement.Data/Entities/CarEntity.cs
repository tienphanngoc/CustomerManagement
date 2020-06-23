using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Entities
{
    public class CarEntity
    {
        public int Id { get; set; }
        public int CarModelId { get; set; }
        public string VIN { get; set; }
        public string EngineNo { get; set; }
        public int CarColorId { get; set; }
        public long PurchasePrice { get; set; }
        public long SalePrice { get; set; }

    }
}
