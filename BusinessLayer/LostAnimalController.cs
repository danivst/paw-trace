using DataLayer;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer
{
    public class LostAnimalController : IController<LostAnimal>
    {
        private ProjectContext context;

        public LostAnimalController(ProjectContext context)
        {
            this.context = context;
        }

        public LostAnimalController()
        {
            context = new ProjectContext();
        }

        public List<LostAnimal> GetAll()
        {
            return context.LostAnimals.ToList();
        }

        public LostAnimal Get(int id)
        {
            return context.LostAnimals.FirstOrDefault(l => l.Id == id);
        }

        public void Add(LostAnimal lostAnimal)
        {
            var oldLostAnimal = Get(lostAnimal.Id);
            if (oldLostAnimal == null)
            {
                context.LostAnimals.Add(lostAnimal);
                context.SaveChanges();
            } 
        }

        public void Update(LostAnimal newLostAnimal)
        {
            LostAnimal lostAnimal = Get(newLostAnimal.Id);
            if (lostAnimal != null)
            {
                context.Entry(lostAnimal).CurrentValues.SetValues(newLostAnimal);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            LostAnimal lostAnimal = Get(id);
            if (lostAnimal != null)
            {
                context.LostAnimals.Remove(lostAnimal);
                context.SaveChanges();
            }
        }
    }
}
