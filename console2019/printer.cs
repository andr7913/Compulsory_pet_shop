using infrastructur.Data.Repositories;
using PetShop.core.domainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;

namespace console2019
{
    public class printer
    {
        public printer()
        {
            #region main
             IPetRepository PetRepository;

             PetRepository = new PetsRepositories();

            Pet p1 = new Pet
            {
                name = "hans",
                type = "wombat",
                Birthday = new DateTime(2000, 12, 25),
                SoldDate = new DateTime(2011, 10, 07),
                color = "black",
                PreviousOwner = "ole",
                price = 10000.00
            };

            Pet p2 = new Pet
            {
                name = "anne",
                type = "hest",
                Birthday = new DateTime(2001, 11, 4),
                SoldDate = new DateTime(2007, 1, 7),
                color = "red",
                PreviousOwner = "snoop dog",
                price = 4375.82
            };

            PetRepository.CreatPet(p1);
            PetRepository.CreatPet(p2);
            //alt over her skal beholdes

            List<string> menu = new List<string>
            {
                "list all pets",// done 1
                "creat a pet",// done 2
                "read pet",//done 3
                "update pet",//done 4
                "Delet pet",// done5
                "search by type",// done6
                "Exit",//done7 
            };

            int selected = showMenu(menu);

            while (selected != 7)
            {
                switch (selected)
                {
                    case 1:// show all
                        Console.WriteLine(" show All pets");
                        showAllPets(PetRepository);
                        break;

                    case 2:// add a pets
                        Console.WriteLine("add pets");

                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Type: ");
                        string type = Console.ReadLine();

                        Console.WriteLine("birthday: YYYY,MM,DD ");
                        DateTime birth = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("soldDay: YYYY,MM,DD ");
                        DateTime soldDay = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("color: ");
                        string color = Console.ReadLine();

                        Console.WriteLine("PreviousOwner: ");
                        string PreviousOwner = Console.ReadLine();

                        Console.WriteLine("price: ");
                        Double price = Double.Parse(Console.ReadLine());

                        Pet pet = new Pet()
                        {
                            name = name,
                            type = type,
                            Birthday = birth,
                            SoldDate = soldDay,
                            color = color,
                            PreviousOwner = PreviousOwner,
                            price = price
                        };

                        creat(pet, PetRepository);
                        break;

                    case 3:// find et dyr
                        Console.WriteLine("skriv id:");
                        int id = int.Parse(Console.ReadLine());
                        var p = findpet(id, PetRepository);
                        Console.WriteLine(p.name + " " + p.type + " " + p.Birthday + " " + p.SoldDate + " " +
                        p.color + " " + p.PreviousOwner + " " + p.price);
                        break;

                    case 4:// update pet
                        Console.WriteLine("update pet");

                        Console.WriteLine("id på pet der skal updates");
                        int idToBeUpdated = int.Parse(Console.ReadLine());

                        Console.WriteLine("Name: ");
                        string nameToBeUpdated = Console.ReadLine();

                        Console.WriteLine("Type: ");
                        string typeToBeUpdated = Console.ReadLine();

                        Console.WriteLine("birthday: ");
                        DateTime birthToBeUpdated = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("soldDay: ");
                        DateTime soldDayToBeUpdated = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("color: ");
                        string colorToBeUpdated = Console.ReadLine();

                        Console.WriteLine("PreviousOwner: ");
                        string PreviousOwnerToBeUpdated = Console.ReadLine();

                        Console.WriteLine("price: ");
                        Double priceToBeUpdated = int.Parse(Console.ReadLine());

                        Pet petToBeUpdated = new Pet()
                        {

                            id = idToBeUpdated,
                            name = nameToBeUpdated,
                            type = typeToBeUpdated,
                            Birthday = birthToBeUpdated,
                            SoldDate = soldDayToBeUpdated,
                            color = colorToBeUpdated,
                            PreviousOwner = PreviousOwnerToBeUpdated,
                            price = priceToBeUpdated
                        };

                        /**
                         * idToBeUpdated id på dyret der skal opdateres
                         * PetRepository.Update(petToBeUpdated) værdierne der skal updateres til
                         * etRepository.ReadAll() alle elm for at finde det dyret der skal updateres
                         */

                        updatePet(petToBeUpdated, PetRepository);


                        break;
                    case 5:// delete pets
                        Console.WriteLine("delet pet");

                        Console.WriteLine("skriv id på dyret");
                        int idToBeDelete = int.Parse(Console.ReadLine());

                        deletepet(idToBeDelete, PetRepository);
                        break;
                    case 6: // search animale by type
                        Console.WriteLine("find animal by type");
                        string anitype = Console.ReadLine();
                        var pets = searchTypeAnimal(anitype,PetRepository);
                        foreach (var _pets in pets)
                        {
                            Console.WriteLine(_pets.name+" "+_pets.type);
                            Console.ReadLine();
                        }
                        
                        break;

                    case 7: // Exit program
                        Console.WriteLine("Exit");
                        break;

                }

                Console.WriteLine("press enter to continue");
                Console.ReadLine();
                Console.Clear();
                selected = showMenu(menu);
            }

            #endregion
        }

        private List<Pet> searchTypeAnimal(string anitype, IPetRepository petRepository)
        {
           var founded = petRepository.searchTypeAnimal(anitype);
            foreach (var found in founded)
            {
                Console.WriteLine(found.id +""+ found.name + "" + found.type);

            }
            return founded;
        }

        #region methode_kald

        private  Pet findpet(int id, IPetRepository petRepository)
        {
            return petRepository.ReadById(id);
        }

        private  void updatePet(Pet petToBeUpdated, IPetRepository petRepository)
        {
            petRepository.Update(petToBeUpdated);
        }

        private  void showAllPets(IPetRepository petRepository)
        {
            var p = petRepository.ReadAll();
            foreach (var pet in p)
            {
                Console.WriteLine(pet.id + " " + pet.name + " " + pet.type + " " + pet.Birthday + " " + pet.SoldDate + " " +
                            pet.color + " " + pet.PreviousOwner + " " + pet.price);

            }
        }

        private  void deletepet(int idToBeDelete, IPetRepository petRepository)
        {
            petRepository.delete(idToBeDelete);
        }

        private  void creat(Pet entity, IPetRepository petRepository)
        {
            petRepository.CreatPet(entity);
        }

        private  int showMenu(List<string> menu)
        {


            for (int i = 0; i < menu.Count; i++)
            {

                Console.WriteLine((i + 1) + " : " + menu[i]);
            }
            Console.WriteLine("select a number between 1-6");

            int selected;
            while (!int.TryParse(Console.ReadLine(), out selected) || selected < 1 || selected > 6)
            {
                Console.Clear();
                Console.WriteLine("type a number beewen 1-6");

            }

            return selected;

        }
        #endregion
    }
}
