using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.Data.Entities
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Engine { get; set; }
        public string GearBox { get; set; }

        [Range(0,int.MaxValue)]
        public int YOM { get; set; }

        [Range(0, int.MaxValue)]
        public int MY { get; set; }

        [Range(0, long.MaxValue)]
        public long OriginalPrice { get; set; }

        //Navigations
        public virtual HashSet<CarModelCategory> CarModelCategories { get; set; }
        

        public CarModel()
        {
            CarModelCategories = new HashSet<CarModelCategory>();
        }
    }
}
