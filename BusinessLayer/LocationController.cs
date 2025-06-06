using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LocationController : IController<Location>
    {
        private ProjectContext context = new ProjectContext();

        public List<Location> GetAll()
        {
            return context.Locations.ToList();
        }

        public Location Get(int id)
        {
            return context.Locations.Find(id);
        }

        public void Add(Location location)
        {
            context.Locations.Add(location);
            context.SaveChanges();
        }

        public void Update(Location newLocation)
        {
            Location location = Get(newLocation.Id);
            if (location != null)
            {
                context.Entry(location).CurrentValues.SetValues(newLocation);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Location location = Get(id);
            if (location != null)
            {
                context.Locations.Remove(location);
                context.SaveChanges();
            }
        }
    }
}
