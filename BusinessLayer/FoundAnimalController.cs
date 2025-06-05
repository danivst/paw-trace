using DataLayer;
using DataLayer.Models;

namespace BusinessLayer
{
    public class FoundAnimalController : IController<FoundAnimal>
    {
        private ProjectContext context = new ProjectContext();

        public List<FoundAnimal> GetAll()
        {
            return context.FoundAnimals.ToList();
        }

        public FoundAnimal Get(int id)
        {
            return context.FoundAnimals.Find(id);
        }

        public void Add(FoundAnimal foundAnimal)
        {
            context.FoundAnimals.Add(foundAnimal);
            context.SaveChanges();
        }

        public void Update(FoundAnimal newFoundAnimal)
        {
            FoundAnimal foundAnimal = Get(newFoundAnimal.Id);
            if (foundAnimal != null)
            {
                context.Entry(foundAnimal).CurrentValues.SetValues(newFoundAnimal);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            FoundAnimal foundAnimal = Get(id);
            if (foundAnimal != null)
            {
                context.FoundAnimals.Remove(foundAnimal);
                context.SaveChanges();
            }
        }
    }
}
