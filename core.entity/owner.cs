﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.Entity
{
  public  class Owner
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public List<Pet> ListOfPets { get; set; }

    }
}
