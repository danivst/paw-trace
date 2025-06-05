using DataLayer;
using DataLayer.Models;

namespace BusinessLayer
{
    public class LostAnimalController : IController<LostAnimal>
    {
        private ProjectContext context = new ProjectContext();

        public List<LostAnimal> GetAll()
        {
            return context.LostAnimals.ToList();
        }

        public LostAnimal Get(int id)
        {
            return context.LostAnimals.Find(id);
        }

        public void Add(LostAnimal lostAnimal)
        {
            context.LostAnimals.Add(lostAnimal);
            context.SaveChanges();
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
