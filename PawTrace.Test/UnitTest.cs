using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace PawTrace.Test
{
    public class Tests
    {
        private ProjectContext context;
        private FoundAnimalController foundAnimalController;
        private LostAnimalController lostAnimalController;
        private LocationController locationController;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ProjectContext>().UseInMemoryDatabase(databaseName: "TestDatabase").Options;

            context = new ProjectContext(options);
            context.Database.EnsureCreated();
            context.Database.EnsureDeleted();

            var location = new Location("PLOVDIV", "BULGARIA");

            var lostAnimal = new LostAnimal
            {
                Id = 1,
                Name = "Sivka",
                Gender = Gender.Female,
                Color = "Grey",
                LocationId = location.Id,
                DateLost = new DateOnly(2021, 12, 12),
                Species = PetType.Cat,
                Age = 1,
                Breed = "-",
                Description = "-"
            };

            var foundAnimal = new FoundAnimal
            {
                Id = 1,
                Name = "Sharo",
                Gender = Gender.Male,
                Color = "Brown",
                LocationId = location.Id,
                DateFound = new DateOnly(2022, 12, 12),
                Species = PetType.Dog,
                Age = 5,
                Breed = "-",
                Description = "-"
            };

            locationController = new LocationController(context);
            lostAnimalController = new LostAnimalController(context);
            foundAnimalController = new FoundAnimalController(context);

            context.LostAnimals.Add(lostAnimal);
            context.FoundAnimals.Add(foundAnimal);
            context.Locations.Add(location);
            context.SaveChanges();
        }

        [TearDown]
        public void TearDown()
        {
            context?.Dispose();
        }

        // LOCATIONS

        [Test]
        public void AddLocation_AddsSuccessfully()
        {
            var location = new Location("SOFIA", "BULGARIA");
            locationController.Add(location);

            var added = context.Locations.FirstOrDefault(l => l.City == "SOFIA" && l.Country == "BULGARIA");
            Assert.IsNotNull(added);
            Assert.AreEqual(added.City, "SOFIA");
        }

        [Test]
        public void AddDuplicateLocation_DoesNotAdd()
        {
            var duplicate = new Location("plovdiv", "bulgaria");

            locationController.Add(duplicate);
            var all = locationController.GetAll();

            Assert.AreEqual(1, all.Count);
        }

        [Test]
        public void GetExistingLocation_GetsSuccessfully()
        {
            var location = locationController.Get(1);
            Assert.IsNotNull(location);
            Assert.AreEqual(location.City, "PLOVDIV");
        }

        [Test]
        public void GetNonxistingLocation_ReturnsNull()
        {
            var location = locationController.Get(999);
            Assert.IsNull(location);
        }

        [Test]
        public void GetAllLocations_ReturnsLocations()
        {
            var all = locationController.GetAll();
            Assert.AreEqual(1, all.Count);
        }

        [Test]
        public void UpdateExistingLocation_UpdatesSuccessfully()
        {
            var updated = locationController.Get(1);
            updated.City = "VARNA";
            locationController.Update(updated);

            var result = locationController.Get(1);

            Assert.AreEqual(result.City, "VARNA");
        }

        [Test]
        public void RemoveNonexistingLocation_DoesNothing()
        {
            locationController.Delete(999);
            var result = locationController.GetAll();

            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void RemoveExistingLocation_RemovesSuccessfully()
        {
            locationController.Delete(1);
            var result = locationController.Get(1);

            Assert.IsNull(result);
            Assert.AreEqual(0, locationController.GetAll().Count);
        }

        // LOST ANIMALS

        [Test]
        public void AddLostAnimal_AddsSuccessfully()
        {
            var lostAnimal = new LostAnimal
            {
                Id = 2,
                Name = "Marco",
                Gender = Gender.Male,
                Color = "Yellow",
                LocationId = 1,
                DateLost = new DateOnly(2024, 12, 11),
                Species = PetType.Parrot,
                Age = 4,
                Breed = "-",
                Description = "-"
            };

            lostAnimalController.Add(lostAnimal);

            var added = context.LostAnimals.FirstOrDefault(l => l.Name == "Marco"); 
            
            Assert.IsNotNull(added);
            Assert.AreEqual(added.Name, "Marco");
            Assert.AreEqual(added.LocationId, 1);
        }

        [Test]
        public void GetLostAnimal_GetsSuccessfully()
        {
            var lostAnimal = lostAnimalController.Get(1);
            Assert.IsNotNull(lostAnimal);
            Assert.AreEqual(lostAnimal.Name, "Sivka");
        }

        [Test]
        public void GetNonxistingLostAnimal_ReturnsNull()
        {
            var lostAnimal = lostAnimalController.Get(999);
            Assert.IsNull(lostAnimal);
        }

        [Test]
        public void GetAllLostAnimals_ReturnsLocations()
        {
            var all = lostAnimalController.GetAll();
            Assert.AreEqual(1, all.Count);
        }

        [Test]
        public void UpdateExistingLostAnimal_UpdatesSuccessfully()
        {
            LostAnimal lostAnimal = lostAnimalController.Get(1);
            lostAnimal.Age = 2;
            lostAnimalController.Update(lostAnimal);

            var result = lostAnimalController.Get(1);
            Assert.AreEqual(result.Age, 2);
        }

        [Test]
        public void RemoveNonexistingLostAnimal_DoesNothing()
        {
            lostAnimalController.Delete(999);
            var result = lostAnimalController.GetAll();

            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void RemoveExistingLostAnimal_RemovesSuccessfully()
        {
            lostAnimalController.Delete(1);
            var result = lostAnimalController.Get(1);

            Assert.IsNull(result);
            Assert.AreEqual(0, lostAnimalController.GetAll().Count);
        }

        // FOUND ANIMALS

        [Test]
        public void AddFoundAnimal_AddsSuccessfully()
        {
            var foundAnimal = new FoundAnimal
            {
                Id = 2,
                Name = "Miko",
                Gender = Gender.Castrated,
                Color = "White",
                LocationId = 1,
                DateFound = new DateOnly(2012, 10, 12),
                Species = PetType.Rabbit,
                Age = 2,
                Breed = "-",
                Description = "-"
            };

            foundAnimalController.Add(foundAnimal);

            var added = context.FoundAnimals.FirstOrDefault(l => l.Name == "Miko");

            Assert.IsNotNull(added);
            Assert.AreEqual(added.Name, "Miko");
            Assert.AreEqual(added.LocationId, 1);
        }

        [Test]
        public void GetFoundAnimal_GetsSuccessfully()
        {
            var foundAnimal = foundAnimalController.Get(1);
            Assert.IsNotNull(foundAnimal);
            Assert.AreEqual(foundAnimal.Name, "Sharo");
        }

        [Test]
        public void GetNonxistingFoundAnimal_ReturnsNull()
        {
            var foundAnimal = foundAnimalController.Get(999);
            Assert.IsNull(foundAnimal);
        }

        [Test]
        public void GetAllFoundAnimals_ReturnsLocations()
        {
            var all = foundAnimalController.GetAll();
            Assert.AreEqual(1, all.Count);
        }

        [Test]
        public void UpdateExistingFoundAnimal_UpdatesSuccessfully()
        {
            FoundAnimal foundAnimal = foundAnimalController.Get(1);
            foundAnimal.Age = 7;
            foundAnimalController.Update(foundAnimal);

            var result = foundAnimalController.Get(1);
            Assert.AreEqual(result.Age, 7);
        }

        [Test]
        public void RemoveNonexistingFoundAnimal_DoesNothing()
        {
            foundAnimalController.Delete(999);
            var result = foundAnimalController.GetAll();

            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void RemoveExistingFoundAnimal_RemovesSuccessfully()
        {
            foundAnimalController.Delete(1);
            var result = foundAnimalController.Get(1);

            Assert.IsNull(result);
            Assert.AreEqual(0, foundAnimalController.GetAll().Count);
        }
    }
}