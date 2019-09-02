using System;
using System.Collections.Generic;
using System.Text;

namespace entity
{
   public class Pet
    {
        int ID { get; }
        string Name { get; set; }
        string type { get; set; }
        DateTime Birthdate { get; set; }
        DateTime SoldDate { get; set; }
        string color { get; set; }
        string PreviousOwner { get; set; }
        double Price { get; set; }
    }
}
