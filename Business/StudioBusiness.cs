using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Business
{
    // contains methods for the CRUD operations 
    public class StudioBusiness
    {
        private MovieStudioContext studioContext;

        // gets all items from the table "Studios" table in the database
        public List<Studio> GetAll()
        {
            using (studioContext = new MovieStudioContext())
            {
                return studioContext.Studios.ToList();
            }

        }

        // gets the item with a specific id from the table "Studios" table in the database
        public Studio Get(int id)
        {
            using (studioContext = new MovieStudioContext())
            {
                return studioContext.Studios.Find(id);
            }
        }

        // adds new item in the "Studios" table in the database
        public void Add(Studio studio)
        {
            using (studioContext = new MovieStudioContext())
            {
                studioContext.Studios.Add(studio);
                studioContext.SaveChanges();
            }
        }

        // updates an item from the database's table "Studios" by given object from the class Studio
        // if item with the object's id exists
        public void Update(Studio studio)
        {
            using (studioContext = new MovieStudioContext())
            {
                var item = studioContext.Studios.Find(studio.Id);
                if (item != null)
                {
                    studioContext.Entry(item).CurrentValues.SetValues(studio);
                    studioContext.SaveChanges();
                }

            }
        }

        // deletes item from the database's table "Studios" by given id
        // if item with thethe given id exists
        public void Delete(int id)
        {
            using (studioContext = new MovieStudioContext())
            {
                var studio = studioContext.Studios.Find(id);
                if (studio != null)
                {
                    studioContext.Studios.Remove(studio);
                    studioContext.SaveChanges();
                }

            }
        }
    }
}
