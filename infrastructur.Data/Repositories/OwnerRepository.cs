using PetShop.core.domainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace infrastructur.Data.Repositories
{
   public class OwnerRepository: IOwnerRepository
    {
        static int id = 1;
        private static List<Owner> _owner = new List<Owner>();

        public Owner Creat(Owner owner)
        {
            owner.id = id++;
            _owner.Add(owner);
            return owner;
        }

        public Owner deleteOwner(int id)
        {
            var ownerFound = this.ReadId(id);
            if (ownerFound != null)
            {
                _owner.Remove(ownerFound);
                return ownerFound;
            }
            return null;
        }

        public List<Owner> GetAll()
        {
            return _owner;

        }

        public Owner ReadId(int id)
        {
            foreach (var owner in _owner)
            {
                if (owner.id == id)
                {
                    return owner;
                }
            }
            return null;
        }

        public Owner UpdateOwner(Owner owner)
        {
            var ownerFromDb = this.ReadId(owner.id);
            if (ownerFromDb != null)
            {
                ownerFromDb.name = owner.name;
                ownerFromDb.age = owner.age;
                ownerFromDb.name = owner.name;
                ownerFromDb.ListOfPets = owner.ListOfPets;

                return ownerFromDb;


            }
            else
            {
                return null;

            }
        }
    }
}
