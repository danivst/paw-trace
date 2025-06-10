using DataLayer;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class LocationController : IController<Location>
	{
		private ProjectContext context;

        public LocationController(ProjectContext context)
        {
            this.context = context;
        }

        public LocationController()
        {
            context = new ProjectContext();
        }

        public List<Location> GetAll()
		{
			return context.Locations.ToList();
		}

		public Location Get(int id)
		{
			return context.Locations.FirstOrDefault(l => l.Id == id);
		}

		public void Add(Location location)
		{
            if (location.Id != 0)
            {
                return;
            }

            location.City = location.City.ToUpper();
            location.Country = location.Country.ToUpper();

            bool exists = context.Locations.Any(l => l.City.ToUpper() == location.City && l.Country.ToUpper() == location.Country);

            if (!exists)
            {
                context.Locations.Add(location);
                context.SaveChanges();
            }
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

        public Location GetOrAdd(string city, string country)
        {
            city = city.ToUpper();
            country = country.ToUpper();

            var existing = context.Locations.FirstOrDefault(l => l.City.ToUpper() == city && l.Country.ToUpper() == country);

            if (existing != null)
                return existing;

            var newLocation = new Location(city, country);

            context.Locations.Add(newLocation);
            context.SaveChanges();

            return newLocation;
        }
    }
}
