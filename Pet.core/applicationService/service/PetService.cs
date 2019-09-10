using System;
using System.Collections.Generic;
using System.Text;
using PetShop.core.domainService;
using PetShop.Core.Entity;

namespace PetShop.core.applicationService.service
{
    public class PetService : IPetsService
    {
        private IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public Pet Creat(Pet animal)
        {
            return  _petRepository.CreatPet(animal);
            
        }

        public Pet deletePet(int id)
        {
           return _petRepository.delete(id);
        }

        public List<Pet> GetAll()
        {
           return _petRepository.ReadAll();
        }

        public Pet ReadId(int id)
        {
            return _petRepository.ReadById(id);
        }

        public List<Pet> searchTypeAnimal(string animal)
        {
           return _petRepository.searchTypeAnimal(animal);
        }

        public Pet UpdatePet(Pet animalUpDate)
        {
            return _petRepository.Update(animalUpDate);
        }
    }
}
