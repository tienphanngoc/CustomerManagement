using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Entities
{
    public class CarColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string HEX { get; set; }
        public int CarCategoryId { get; set; }

        //Navigations
        public virtual CarCategory CarCategory { get; set; }
    }
}
