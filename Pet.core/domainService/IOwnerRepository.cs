using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.core.domainService
{
   public interface IOwnerRepository
    {
        Owner Creat(Owner owner);

        Owner ReadId(int id);

        List<Owner> GetAll();

    

        Owner UpdateOwner(Owner owner);

        Owner deleteOwner(int id);
    }
}
