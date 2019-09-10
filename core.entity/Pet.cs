using System;

namespace PetShop.Core.Entity
{
    public class Pet
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime SoldDate { get; set; }
        public string color { get; set; }
        public string PreviousOwner { get; set; }
        public Double price { get; set; }
        public Owner owner { get; set; }

    }
}
