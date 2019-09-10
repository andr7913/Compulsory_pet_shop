using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.core.applicationService
{
    public interface IPetsService
    {

        Pet Creat(Pet animal);

        Pet ReadId(int id);

        List<Pet> GetAll();

        List<Pet> searchTypeAnimal(String animal);

        Pet UpdatePet(Pet animalUpDate);

        Pet deletePet(int id);
    }
}
