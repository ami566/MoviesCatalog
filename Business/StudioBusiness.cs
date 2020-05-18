using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Business
{
    public class StudioBusiness
    {
        private MovieStudioContext studioContext;

        public List<Studio> GetAll()
        {
            using (studioContext = new MovieStudioContext())
            {
                return studioContext.Studios.ToList();
            }

        }

        public Studio Get(int id)
        {
            using (studioContext = new MovieStudioContext())
            {
                return studioContext.Studios.Find(id);
            }
        }

        public void Add(Studio studio)
        {
            using (studioContext = new MovieStudioContext())
            {
                studioContext.Studios.Add(studio);
                studioContext.SaveChanges();
            }
        }

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
