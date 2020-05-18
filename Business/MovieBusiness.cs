using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MovieBusiness
    {
        private MovieStudioContext movieContext;

        public List<Movie> GetAll()
        {
            using (movieContext = new MovieStudioContext())
            {
                return movieContext.Movies.ToList();
            }
        }

        public Movie Get(int id)
        {
            using (movieContext = new MovieStudioContext())
            {
                return movieContext.Movies.Find(id);
            }
        }

        public void Add(Movie movie)
        {
            using (movieContext = new MovieStudioContext())
            {
                movieContext.Movies.Add(movie);
                movieContext.SaveChanges();
            }
        }

        public void Update(Movie movie)
        {
            using (movieContext = new MovieStudioContext())
            {
                var item = movieContext.Movies.Find(movie.Id);
                if (item != null)
                {
                    movieContext.Entry(item).CurrentValues.SetValues(movie);
                    movieContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (movieContext = new MovieStudioContext())
            {
                var movie = movieContext.Movies.Find(id);
                if (movie != null)
                {
                    movieContext.Movies.Remove(movie);
                    movieContext.SaveChanges();
                }

            }
        }
    }
}
