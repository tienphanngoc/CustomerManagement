using CustomerManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public EntityStatus Status { get; set; }

        //Navigations
        public virtual HashSet<CarCategory> CarCategories { get; set; }

        public Brand()
        {
            CarCategories = new HashSet<CarCategory>();
        }

    }
}
