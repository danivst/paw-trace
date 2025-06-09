using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using PawTrace;
using System;
using System.Globalization;
using System.Linq;

namespace PresentationLayer
{
    public class Display
    {
        private FoundAnimalController foundAnimalController = new FoundAnimalController();
        private LostAnimalController lostAnimalController = new LostAnimalController();
        private LocationController locationController = new LocationController();

        public Display()
        {
            Input();
        }

        public void Input()
        {
            while (true)
            {
                Console.Write(new string('-', 25));
                Console.Write("MENU");
                Console.Write(new string('-', 25));
                Console.WriteLine();
                Console.WriteLine("1. Visual display (Open Windows Forms App)");
                Console.WriteLine("2. View lost animals menu");
                Console.WriteLine("3. View found animals menu");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Opening Windows Forms App...");
                        Task.Run(() => Application.Run(new Form1()));
                        Console.WriteLine("Windows Forms App successfully opened!");
                        Console.WriteLine();
                        break;

                    case 2:
                        InputLostAnimal();
                        break;

                    case 3:
                        InputFoundAnimal();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        public void InputLostAnimal()
        {
            Console.Write(new string('-', 25));
            Console.Write("LOST ANIMALS MENU");
            Console.Write(new string('-', 25));
            Console.WriteLine();
            Console.WriteLine("1. Add lost animal");
            Console.WriteLine("2. Edit lost animal");
            Console.WriteLine("3. Delete lost animal");
            Console.WriteLine("4. See all lost animals");
            Console.WriteLine("5. See all lost animals for a location");
            Console.WriteLine("6. Go back");
            Console.WriteLine();

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write(new string('-', 25));
                    Console.Write("ADD A LOST ANIMAL");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    Console.WriteLine("If you want to leave a field empty, type '-' (If a field is marked with '*', you cannot leave it empty as it is obligatory data)");
                    Console.WriteLine();
                    Console.WriteLine("Insert data for pet: (Please note that image insertion is possible only in the Windows Forms App interface)");

                    Console.Write("Name*: ");
                    string nameAddLost = Console.ReadLine();

                    Console.WriteLine("Gender*:");
                    Console.WriteLine("1. Female");
                    Console.WriteLine("2. Male");
                    Console.WriteLine("3. Castrated");
                    int genderAddLost = int.Parse(Console.ReadLine());

                    Console.Write("Color*: ");
                    string colorAddLost = Console.ReadLine();

                    Console.Write("Location* (Format: {city}, {country}): ");
                    string[] locationAddLost = Console.ReadLine().Split(", ").ToArray();

                    

                    Console.Write("Date lost* (Format: {dd/MM/yyyy}): ");
                    string dateAddLost = Console.ReadLine();
                    DateOnly dateLost;
                    if (!DateOnly.TryParseExact(dateAddLost, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateLost))
                    {
                        throw new FormatException("Invalid date format. Expected format: dd/MM/yyyy.");
                    }

                    Console.WriteLine("Choose a species*:");
                    Console.WriteLine("1. Cat");
                    Console.WriteLine("2. Dog");
                    Console.WriteLine("3. Rabbit");
                    Console.WriteLine("4. Parrot");
                    Console.WriteLine("5. Hamster");
                    Console.WriteLine("6. Guinea pig");
                    Console.WriteLine("7. Other");
                    int petAddLost = int.Parse(Console.ReadLine());

                    LostAnimal lostAnimal = new LostAnimal
                    {
                        Name = nameAddLost,
                        Gender = (Gender)genderAddLost,
                        Color = colorAddLost,
                        Location = locationLost,
                        DateLost = dateLost,
                        Species = (PetType)petAddLost,
                        Status = StatusType.Lost
                    };

                    Console.Write("Age (Enter the closest age to the real one in years): ");
                    string ageAddLost = Console.ReadLine();
                    if (ageAddLost != "-")
                    {
                        lostAnimal.Age = int.Parse(ageAddLost);
                    }

                    Console.Write("Breed: ");
                    string breedAddLost = Console.ReadLine();
                    if (breedAddLost != "-")
                    {
                        lostAnimal.Breed = breedAddLost;
                    }

                    Console.WriteLine("Description:");
                    string descriptionAddLost = Console.ReadLine();
                    if (descriptionAddLost != "-")
                    {
                        lostAnimal.Description = descriptionAddLost;
                    }

                    lostAnimalController.Add(lostAnimal);

                    Console.WriteLine("Successfully added a lost animal!");
                    Console.WriteLine();

                    break;

                case 2:
                    Console.Write(new string('-', 25));
                    Console.Write("EDIT A LOST ANIMAL");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    Console.Write("Enter ID to update: ");
                    int idToUpdate = int.Parse(Console.ReadLine());

                    LostAnimal lostAnimalToUpdate = lostAnimalController.Get(idToUpdate);
                    if (lostAnimalToUpdate != null)
                    {
                        Console.WriteLine("Data for pet:");
                        Console.WriteLine(lostAnimalToUpdate.ToString());
                        Console.Write("Do you wish to proceed and edit the information? (Y/N): ");
                        string input = Console.ReadLine().ToLower();

                        if (input == "y")
                        {
                            Location locationToDelete = lostAnimalToUpdate.Location;

                            Console.WriteLine("If you want to leave a field empty, type '-' (If a field is marked with '*', you cannot leave it empty as it is obligatory data)");
                            Console.WriteLine();
                            Console.WriteLine("Insert data for pet: (Please note that image insertion is possible only in the Windows Forms App interface)");

                            Console.Write("Name*: ");
                            lostAnimalToUpdate.Name = Console.ReadLine();

                            Console.WriteLine("Gender*:");
                            Console.WriteLine("1. Female");
                            Console.WriteLine("2. Male");
                            Console.WriteLine("3. Castrated");
                            int genderToUpdate = int.Parse(Console.ReadLine());
                            lostAnimalToUpdate.Gender = (Gender)genderToUpdate;

                            Console.Write("Color*: ");
                            lostAnimalToUpdate.Color = Console.ReadLine();

                            Console.Write("Location* (Format: {city}, {country}): ");
                            string[] locationToUpdate = Console.ReadLine().Split(", ").ToArray();

                            
                            lostAnimalToUpdate.Location = locationLostNew;

                            Console.Write("Date lost* (Format: {dd/MM/yyyy}): ");
                            string dateUpdateLost = Console.ReadLine();
                            DateOnly dateLostToUpdate;
                            if (!DateOnly.TryParseExact(dateUpdateLost, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateLostToUpdate))
                            {
                                throw new FormatException("Invalid date format. Expected format: dd/MM/yyyy.");
                            }
                            lostAnimalToUpdate.DateLost = dateLostToUpdate;

                            Console.WriteLine("Choose a species*:");
                            Console.WriteLine("1. Cat");
                            Console.WriteLine("2. Dog");
                            Console.WriteLine("3. Rabbit");
                            Console.WriteLine("4. Parrot");
                            Console.WriteLine("5. Hamster");
                            Console.WriteLine("6. Guinea pig");
                            Console.WriteLine("7. Other");
                            int petToUpdateLost = int.Parse(Console.ReadLine());
                            lostAnimalToUpdate.Species = (PetType)petToUpdateLost;

                            Console.Write("Age (Enter the closest age to the real one in years): ");
                            string ageToUpdateLost = Console.ReadLine();
                            if (ageToUpdateLost != "-")
                            {
                                lostAnimalToUpdate.Age = int.Parse(ageToUpdateLost);
                            }

                            Console.Write("Breed: ");
                            string breedToUpdateLost = Console.ReadLine();
                            if (breedToUpdateLost != "-")
                            {
                                lostAnimalToUpdate.Breed = breedToUpdateLost;
                            }

                            Console.WriteLine("Description:");
                            string descriptionToUpdateLost = Console.ReadLine();
                            if (descriptionToUpdateLost != "-")
                            {
                                lostAnimalToUpdate.Description = descriptionToUpdateLost;
                            }

                            lostAnimalController.Update(lostAnimalToUpdate);

                            bool locationIsUsed = foundAnimalController.GetAll()
                                                  .Any(a => a.Location.City.Equals(locationToDelete.City.ToUpper()) &&
                                                            a.Location.Country.Equals(locationToDelete.Country.ToUpper()));

                            if (!locationIsUsed)
                            {
                                locationController.Delete(locationToDelete.Id);
                            }

                            Console.WriteLine($"Successfully updated information about lost animal with id {idToUpdate}!");
                            Console.WriteLine();
                        }
                    }

                    Console.WriteLine();

                    break;

                case 3:
                    Console.Write(new string('-', 25));
                    Console.Write("DELETE A LOST ANIMAL");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    Console.Write("Enter ID to delete: ");
                    int idToDelete = int.Parse(Console.ReadLine());

                    LostAnimal lostAnimalToDelete = lostAnimalController.Get(idToDelete);
                    if (lostAnimalToDelete != null)
                    {
                        Console.WriteLine("Data for pet:");
                        Console.WriteLine(lostAnimalToDelete.ToString());
                        Console.Write("Do you wish to proceed and delete the information about the pet? (Y/N): ");
                        string input = Console.ReadLine().ToLower();

                        if (input == "y")
                        {
                            Location locationToDelete = lostAnimalToDelete.Location;
                            lostAnimalController.Delete(idToDelete);

                            bool locationIsUsed = foundAnimalController.GetAll()
                                                  .Any(a => a.Location.City.Equals(locationToDelete.City.ToUpper()) &&
                                                            a.Location.Country.Equals(locationToDelete.Country.ToUpper()));

                            if (!locationIsUsed)
                            {
                                locationController.Delete(locationToDelete.Id);
                            }

                            Console.WriteLine($"Successfully deleted lost animal with id {idToDelete}!");
                        }
                    }
                    
                    Console.WriteLine();

                    break;

                case 4:
                    Console.Write(new string('-', 25));
                    Console.Write("LOST ANIMALS");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    foreach (var animal in lostAnimalController.GetAll())
                    {
                        Console.WriteLine(animal.ToString());
                    }

                    if (lostAnimalController.GetAll().Count == 0)
                    {
                        Console.WriteLine("No lost animals!");
                    }

                    Console.WriteLine();

                    break;

                case 5:
                    Console.Write(new string('-', 25));
                    Console.Write("LOST ANIMALS BY LOCATION");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    Console.WriteLine("Choose a location: ");
                    int count = 1;
                    Console.WriteLine(locationController.GetAll().Count);
                    foreach (var l in locationController.GetAll())
                    {
                        Console.WriteLine($"{count}. {l.ToString()}");
                    }
                    int location = int.Parse(Console.ReadLine());
                    Location locationToFetch = locationController.Get(location);

                    Console.Write(new string('-', 25));
                    Console.Write("RESULTS");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    count = 0;
                    foreach (var animal in lostAnimalController.GetAll())
                    {
                        if (animal.Location == locationToFetch)
                        {
                            Console.WriteLine(animal.ToString());
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        Console.WriteLine("No lost animals!");
                    }

                    Console.WriteLine();

                    break;

                case 6:
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        public void InputFoundAnimal()
        {
            Console.Write(new string('-', 25));
            Console.Write("FOUND ANIMALS MENU");
            Console.Write(new string('-', 25));
            Console.WriteLine();
            Console.WriteLine("1. Add found animal");
            Console.WriteLine("2. Check for matches if you have found a pet");
            Console.WriteLine("3. Edit found animal");
            Console.WriteLine("4. Delete found animal");
            Console.WriteLine("5. See all found animals");
            Console.WriteLine("6. See all found animals for a location");
            Console.WriteLine("7. Go back");
            Console.WriteLine();

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write(new string('-', 25));
                    Console.Write("ADD A FOUND ANIMAL");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    Console.WriteLine("If you want to leave a field empty, type '-' (If a field is marked with '*', you cannot leave it empty as it is obligatory data)");
                    Console.WriteLine();
                    Console.WriteLine("Insert data for pet: (Please note that image insertion is possible only in the Windows Forms App interface)");

                    Console.Write("Name: ");
                    string nameAddFound = Console.ReadLine();

                    Console.WriteLine("Gender*:");
                    Console.WriteLine("1. Female");
                    Console.WriteLine("2. Male");
                    Console.WriteLine("3. Castrated");
                    int genderAddFound = int.Parse(Console.ReadLine());

                    Console.Write("Color*: ");
                    string colorAddFound = Console.ReadLine();

                    Console.Write("Location* (Format: {city}, {country}): ");
                    string[] locationAddFound = Console.ReadLine().Split(", ").ToArray();

                    

                    Console.Write("Date found* (Format: {dd/MM/yyyy}): ");
                    string dateAddFound = Console.ReadLine();
                    DateOnly dateFound;
                    if (!DateOnly.TryParseExact(dateAddFound, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFound))
                    {
                        throw new FormatException("Invalid date format. Expected format: dd/MM/yyyy.");
                    }

                    Console.WriteLine("Choose a species*:");
                    Console.WriteLine("1. Cat");
                    Console.WriteLine("2. Dog");
                    Console.WriteLine("3. Rabbit");
                    Console.WriteLine("4. Parrot");
                    Console.WriteLine("5. Hamster");
                    Console.WriteLine("6. Guinea pig");
                    Console.WriteLine("7. Other");
                    int petAddFound = int.Parse(Console.ReadLine());

                    FoundAnimal foundAnimal = new FoundAnimal
                    {
                        Gender = (Gender)genderAddFound,
                        Color = colorAddFound,
                        Location = locationFound,
                        DateFound = dateFound,
                        Species = (PetType)petAddFound,
                        Status = StatusType.Found
                    };

                    if (nameAddFound != "-")
                    {
                        foundAnimal.Name = nameAddFound;
                    }

                    Console.Write("Age (Enter the closest age to the real one in years): ");
                    string ageAddFound = Console.ReadLine();
                    if (ageAddFound != "-")
                    {
                        foundAnimal.Age = int.Parse(ageAddFound);
                    }

                    Console.Write("Breed: ");
                    string breedAddFound = Console.ReadLine();
                    if (breedAddFound != "-")
                    {
                        foundAnimal.Breed = breedAddFound;
                    }

                    Console.WriteLine("Description:");
                    string descriptionAddFound = Console.ReadLine();
                    if (descriptionAddFound != "-")
                    {
                        foundAnimal.Description = descriptionAddFound;
                    }

                    foundAnimalController.Add(foundAnimal);

                    Console.WriteLine("Successfully added a lost animal!");
                    Console.WriteLine();

                    break;

                case 2:
                    Console.Write(new string('-', 25));
                    Console.Write("FIND MATCHES");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    Console.Write("Have you found a pet and want to find out if it was lost? (Y/N): ");
                    string inputMatches = Console.ReadLine().ToLower();

                    if (inputMatches == "y")
                    {
                        Console.WriteLine("If you want to leave a field empty, type '-' (If a field is marked with '*', you cannot leave it empty as it is obligatory data)");
                        Console.WriteLine();
                        Console.WriteLine("Insert data for pet: (Please note that image insertion is possible only in the Windows Forms App interface)");

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Gender*:");
                        Console.WriteLine("1. Female");
                        Console.WriteLine("2. Male");
                        Console.WriteLine("3. Castrated");
                        int gender = int.Parse(Console.ReadLine());

                        Console.Write("Color*: ");
                        string color = Console.ReadLine();

                        Console.Write("Location* (Format: {city}, {country}): ");
                        string[] locationMatches = Console.ReadLine().Split(", ").ToArray();

                        Console.Write("Date found* (Format: {dd/MM/yyyy}): ");
                        string date = Console.ReadLine();
                        DateOnly dateFoundMatches;
                        if (!DateOnly.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFoundMatches))
                        {
                            throw new FormatException("Invalid date format. Expected format: dd/MM/yyyy.");
                        }

                        Console.WriteLine("Choose a species*:");
                        Console.WriteLine("1. Cat");
                        Console.WriteLine("2. Dog");
                        Console.WriteLine("3. Rabbit");
                        Console.WriteLine("4. Parrot");
                        Console.WriteLine("5. Hamster");
                        Console.WriteLine("6. Guinea pig");
                        Console.WriteLine("7. Other");
                        int pet = int.Parse(Console.ReadLine());

                        Console.Write("Age (Enter the closest age to the real one in years): ");
                        string age = Console.ReadLine();

                        Console.Write("Breed: ");
                        string breed = Console.ReadLine();

                        Console.WriteLine("Description:");
                        string description = Console.ReadLine();

                        bool hasName = false; 
                        if (name != "-")
                        {
                            hasName = true;
                        }

                        bool hasAge = false;
                        if (age != "-")
                        {
                            hasAge = true;
                        }

                        bool hasBreed = false;
                        if (breed != "-")
                        {
                            hasBreed = true;
                        }

                        Console.Write(new string('-', 25));
                        Console.Write("RESULTS");
                        Console.Write(new string('-', 25));
                        Console.WriteLine();

                        List<LostAnimal> matches = new List<LostAnimal>();

                        foreach (var animal in lostAnimalController.GetAll())
                        {
                            if (animal.Gender == (Gender)gender && animal.Color == color && animal.Species == (PetType)pet && animal.Location.City.ToUpper() == locationMatches[0] && animal.Location.Country.ToUpper() == locationMatches[1] && (animal.DateLost <= dateFoundMatches))
                            {
                                if ((hasName == true && animal.Name == name) || (hasAge == true && animal.Age == int.Parse(age)) || (hasBreed == true && animal.Breed == breed))
                                {
                                    Console.WriteLine(animal.ToString());
                                    matches.Add(animal);
                                }
                            }
                        }
                        
                        if (matches.Count == 0)
                        {
                            Console.Write("No matches for your search. Would you like to add the pet you have found to the database? (Y/N): ");
                            string input = Console.ReadLine().ToLower();

                            if (input == "y")
                            {
                                

                                FoundAnimal foundAnimalNew = new FoundAnimal
                                {
                                    Gender = (Gender)gender,
                                    Color = color,
                                    Location = locationFound,
                                    DateFound = dateFoundMatches,
                                    Species = (PetType)pet,
                                    Status = StatusType.Found
                                };

                                if (hasAge)
                                {
                                    foundAnimalNew.Age = int.Parse(age);    
                                }

                                if (hasName)
                                {
                                    foundAnimalNew.Name = name;
                                }

                                if (hasBreed)
                                {
                                    foundAnimalNew.Breed = breed;
                                }

                                foundAnimalController.Add(foundAnimalNew);
                            }
                        }
                        else if (matches.Count == 1)
                        {
                            Console.Write("One match. Is this the pet you have found? (Y/N): ");
                            string input = Console.ReadLine().ToLower();

                            if (input == "y")
                            {
                                LostAnimal animal = matches[0];
                                Location locationToDelete = animal.Location;
                                
                                animal.Status = StatusType.Found;
                                foundAnimalController.Delete(animal.Id);

                                bool locationIsUsed = foundAnimalController.GetAll()
                                                  .Any(a => a.Location.City.Equals(locationToDelete.City.ToUpper()) &&
                                                            a.Location.Country.Equals(locationToDelete.Country.ToUpper()));

                                if (!locationIsUsed)
                                {
                                    locationController.Delete(locationToDelete.Id);
                                }

                                Console.WriteLine($"Successfully marked as found and deleted found animal with id {animal.Id}!");
                            }
                        }
                        else
                        {
                            Console.Write("Do any of these pets match the one you have found? (Y/N): ");
                            string input = Console.ReadLine().ToLower();
                            Console.WriteLine();

                            if (input == "y")
                            {
                                Console.Write("Enter the ID of the pet you have found: ");
                                int id = int.Parse(Console.ReadLine());
                                bool found = false;

                                foreach (var animal in matches)
                                {
                                    if (animal.Id == id)
                                    {
                                        found = true;

                                        Location locationToDelete = animal.Location;
                                        animal.Status = StatusType.Found;
                                        foundAnimalController.Delete(animal.Id);

                                        bool locationIsUsed = foundAnimalController.GetAll()
                                                  .Any(a => a.Location.City.Equals(locationToDelete.City.ToUpper()) &&
                                                            a.Location.Country.Equals(locationToDelete.Country.ToUpper()));

                                        if (!locationIsUsed)
                                        {
                                            locationController.Delete(locationToDelete.Id);
                                        }

                                        Console.WriteLine($"Successfully marked as found and deleted found animal with id {animal.Id}!");
                                        break;
                                    }
                                }

                                if (found == false)
                                {
                                    Console.WriteLine("Invalid ID!");
                                }
                            }
                        }
                    }

                    Console.WriteLine();

                    break;

                case 3:
                    Console.Write(new string('-', 25));
                    Console.Write("EDIT A FOUND ANIMAL");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    Console.Write("Enter ID to update: ");
                    int idToUpdate = int.Parse(Console.ReadLine());

                    FoundAnimal foundAnimalToUpdate = foundAnimalController.Get(idToUpdate);
                    if (foundAnimalToUpdate != null)
                    {
                        Console.WriteLine("Data for pet:");
                        Console.WriteLine(foundAnimalToUpdate.ToString());
                        Console.Write("Do you wish to proceed and edit the information? (Y/N): ");
                        string input = Console.ReadLine().ToLower();

                        if (input == "y")
                        {
                            Location locationToDelete = foundAnimalToUpdate.Location;

                            Console.WriteLine("If you want to leave a field empty, type '-' (If a field is marked with '*', you cannot leave it empty as it is obligatory data)");
                            Console.WriteLine();
                            Console.WriteLine("Insert data for pet: (Please note that image insertion is possible only in the Windows Forms App interface)");

                            Console.Write("Name: ");
                            string nameToUpdate = Console.ReadLine();
                            if (nameToUpdate != "-")
                            {
                                foundAnimalToUpdate.Name = nameToUpdate;
                            }

                            Console.WriteLine("Gender*:");
                            Console.WriteLine("1. Female");
                            Console.WriteLine("2. Male");
                            Console.WriteLine("3. Castrated");
                            int genderToUpdate = int.Parse(Console.ReadLine());
                            foundAnimalToUpdate.Gender = (Gender)genderToUpdate;

                            Console.Write("Color*: ");
                            foundAnimalToUpdate.Color = Console.ReadLine();

                            Console.Write("Location* (Format: {city}, {country}): ");
                            string[] locationToUpdate = Console.ReadLine().Split(", ").ToArray();

                            

                            foundAnimalToUpdate.Location = locationFoundNew;

                            Console.Write("Date found* (Format: {dd/MM/yyyy}): ");
                            string dateUpdateFound = Console.ReadLine();
                            DateOnly dateFoundToUpdate;
                            if (!DateOnly.TryParseExact(dateUpdateFound, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFoundToUpdate))
                            {
                                throw new FormatException("Invalid date format. Expected format: dd/MM/yyyy.");
                            }
                            foundAnimalToUpdate.DateFound = dateFoundToUpdate;

                            Console.WriteLine("Choose a species*:");
                            Console.WriteLine("1. Cat");
                            Console.WriteLine("2. Dog");
                            Console.WriteLine("3. Rabbit");
                            Console.WriteLine("4. Parrot");
                            Console.WriteLine("5. Hamster");
                            Console.WriteLine("6. Guinea pig");
                            Console.WriteLine("7. Other");
                            int petToUpdateFound = int.Parse(Console.ReadLine());
                            foundAnimalToUpdate.Species = (PetType)petToUpdateFound;

                            Console.Write("Age (Enter the closest age to the real one in years): ");
                            string ageToUpdateFound = Console.ReadLine();
                            if (ageToUpdateFound != "-")
                            {
                                foundAnimalToUpdate.Age = int.Parse(ageToUpdateFound);
                            }

                            Console.Write("Breed: ");
                            string breedToUpdateFound = Console.ReadLine();
                            if (breedToUpdateFound != "-")
                            {
                                foundAnimalToUpdate.Breed = breedToUpdateFound;
                            }

                            Console.WriteLine("Description:");
                            string descriptionToUpdateFound = Console.ReadLine();
                            if (descriptionToUpdateFound != "-")
                            {
                                foundAnimalToUpdate.Description = descriptionToUpdateFound;
                            }

                            foundAnimalController.Update(foundAnimalToUpdate);

                            bool locationIsUsed = foundAnimalController.GetAll()
                                                  .Any(a => a.Location.City.Equals(locationToDelete.City.ToUpper()) &&
                                                            a.Location.Country.Equals(locationToDelete.Country.ToUpper()));

                            if (!locationIsUsed)
                            {
                                locationController.Delete(locationToDelete.Id);
                            }

                            Console.WriteLine($"Successfully updated information about found animal with id {idToUpdate}!");
                        }
                    }

                    Console.WriteLine();

                    break;

                case 4:
                    Console.Write(new string('-', 25));
                    Console.Write("DELETE A FOUND ANIMAL");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    Console.Write("Enter ID to delete: ");
                    int idToDelete = int.Parse(Console.ReadLine());

                    FoundAnimal foundAnimalToDelete = foundAnimalController.Get(idToDelete);
                    if (foundAnimalToDelete != null)
                    {
                        Console.WriteLine("Data for pet:");
                        Console.WriteLine(foundAnimalToDelete.ToString());
                        Console.Write("Do you wish to proceed and delete the information about the pet? (Y/N): ");
                        string input = Console.ReadLine().ToLower();

                        if (input == "y")
                        {
                            Location locationToDelete = foundAnimalToDelete.Location;
                            foundAnimalController.Delete(idToDelete);
                            bool locationIsUsed = foundAnimalController.GetAll()
                                                  .Any(a => a.Location.City.Equals(locationToDelete.City.ToUpper()) &&
                                                            a.Location.Country.Equals(locationToDelete.Country.ToUpper()));

                            if (!locationIsUsed)
                            {
                                locationController.Delete(locationToDelete.Id);
                            }

                            Console.WriteLine($"Successfully deleted found animal with id {idToDelete}!");
                        }
                    }

                    Console.WriteLine();

                    break;

                case 5:
                    Console.Write(new string('-', 25));
                    Console.Write("FOUND ANIMALS");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    foreach (var animal in foundAnimalController.GetAll())
                    {
                        Console.WriteLine(animal.ToString());
                    }

                    if (foundAnimalController.GetAll().Count == 0)
                    {
                        Console.WriteLine("No found animals!");
                    }

                    Console.WriteLine();

                    break;

                case 6:
                    Console.Write(new string('-', 25));
                    Console.Write("FOUND ANIMALS BY LOCATION");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    Console.WriteLine("Choose a location: ");
                    int count = 1;
                    foreach (var l in locationController.GetAll())
                    {
                        Console.WriteLine($"{count}. {l.ToString()}");
                    }
                    int location = int.Parse(Console.ReadLine());
                    Location locationToFetch = locationController.Get(location);

                    Console.Write(new string('-', 25));
                    Console.Write("RESULTS");
                    Console.Write(new string('-', 25));
                    Console.WriteLine();

                    count = 0;
                    foreach (var animal in foundAnimalController.GetAll())
                    {
                        if (animal.Location == locationToFetch)
                        {
                            Console.WriteLine(animal.ToString());
                            count += 1;
                        }
                    }

                    if (count == 0)
                    {
                        Console.WriteLine("No found animals!");
                    }

                    Console.WriteLine();

                    break;

                case 7:
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
