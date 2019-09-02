using PetShop.Core.Entity;
using System;
using System.Collections.Generic;


namespace PetShop.core.domainService
{
   public interface IPetRepository
    {
        Pet CreatPet(Pet animal);

        Pet ReadById(int id);

        List<Pet> ReadAll();

        List<Pet> searchTypeAnimal(String animal);

        Pet Update(Pet animalUpDate);

        Pet delete(int id);
    }
}
