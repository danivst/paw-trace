using DataLayer;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer
{
    public class FoundAnimalController : IController<FoundAnimal>
    {
        private ProjectContext context;

        public FoundAnimalController(ProjectContext context)
        {
            this.context = context;
        }

        public FoundAnimalController()
        {
            context = new ProjectContext();
        }

        public List<FoundAnimal> GetAll()
        {
            return context.FoundAnimals.ToList();
        }

        public FoundAnimal Get(int id)
        {
            return context.FoundAnimals.FirstOrDefault(l => l.Id == id);
        }

        public void Add(FoundAnimal foundAnimal)
        {
            var oldFoundAnimal = Get(foundAnimal.Id);
            if (oldFoundAnimal == null)
            {
                context.FoundAnimals.Add(foundAnimal);
                context.SaveChanges();
            }
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
