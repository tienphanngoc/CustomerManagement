using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Entities
{
    public class CarModelCategory
    {
        public int CarModelId { get; set; }
        public int CarCategoryId { get; set; }

        //Navigations
        public virtual CarModel CarModel { get; set; }
        public virtual CarCategory CarCategory { get; set; }

    }
}
