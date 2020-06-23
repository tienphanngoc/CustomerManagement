using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Entities
{
    public class CarCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        //Navigarions
        public virtual Brand Brand { get; set; }
        public virtual HashSet<CarColor> CarColors { get; set; }
        public virtual HashSet<CarModelCategory> CarModelCategories { get; set; }

        public CarCategory()
        {
            CarColors = new HashSet<CarColor>();
            CarModelCategories = new HashSet<CarModelCategory>();
        }
    }
}
