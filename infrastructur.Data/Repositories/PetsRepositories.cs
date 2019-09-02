using PetShop.core.domainService;
using PetShop.Core.Entity;
using System.Collections.Generic;
using System.Linq;

namespace infrastructur.Data.Repositories
{
    public class PetsRepositories : IPetRepository
    {
        static int id=1;
        private  List<Pet> _pets = new List<Pet>();

        
        public Pet CreatPet(Pet animal)
        {
            animal.id = id++;
            _pets.Add(animal);
            return animal;


        }

        public Pet delete(int id)
        {
            var petsFound = this.ReadById(id);
            if (petsFound != null)
            {
                _pets.Remove(petsFound);
                return petsFound;
            }
            return null;
        }

        public List<Pet> ReadAll()
        {
            return _pets;

        }

        public Pet ReadById(int id)
        {
            foreach (var pet in _pets)
            {
                if (pet.id == id)
                {
                    return pet;
                }
            }
            return null;
        }

        public List<Pet> searchTypeAnimal(string animal)
        {
            var founded = _pets.Where(_pets => _pets.type.Equals(animal) );
            return founded.ToList();
        }

        public Pet Update(Pet animalUpDate)
        {
            
            var petFromDb = this.ReadById(animalUpDate.id);
            if (petFromDb != null)
            {
                petFromDb.name = animalUpDate.name;
                petFromDb.type = animalUpDate.type;
                petFromDb.Birthday = animalUpDate.Birthday;
                petFromDb.SoldDate = animalUpDate.SoldDate;
                petFromDb.color = animalUpDate.color;
                petFromDb.PreviousOwner = animalUpDate.PreviousOwner;
                petFromDb.price = animalUpDate.price;
                return petFromDb;


            }
            else
            {
                return null;

            }

        }
    }
}
