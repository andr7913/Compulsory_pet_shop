using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.core.applicationService
{
   public interface IOwnerService
    {

        Owner Creat(Owner owner);

        Owner ReadId(int id);

        List<Owner> GetAll();



        Owner UpdateOwner(Owner OwnerUpDate);

        Owner deleteOwner(int id);
    }
}
