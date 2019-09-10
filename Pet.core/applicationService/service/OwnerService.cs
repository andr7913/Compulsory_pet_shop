using System;
using System.Collections.Generic;
using System.Text;
using PetShop.core.domainService;
using PetShop.Core.Entity;

namespace PetShop.core.applicationService.service
{
   public class OwnerService : IOwnerService
    {

        private IOwnerRepository _OwnerRepository;

        public OwnerService(IOwnerRepository petRepository)
        {
            _OwnerRepository = petRepository;
        }
        public Owner Creat(Owner owner)
        {
            return _OwnerRepository.Creat(owner);
        }

        public Owner deleteOwner(int id)
        {
            return _OwnerRepository.deleteOwner(id);
        }

        public List<Owner> GetAll()
        {
            return _OwnerRepository.GetAll();

        }

        public Owner ReadId(int id)
        {
            return _OwnerRepository.ReadId(id);
        }

        public Owner UpdateOwner(Owner OwnerUpDate)
        {
            return _OwnerRepository.UpdateOwner(OwnerUpDate);

        }
    }
}
