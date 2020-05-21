using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    // contains methods for the CRUD operations 
    public class MovieBusiness
    {
        private MovieStudioContext movieContext;

        // gets all items from the table "Movies" table in the database
        public List<Movie> GetAll()
        {
            using (movieContext = new MovieStudioContext())
            {
                return movieContext.Movies.ToList();
            }
        }

        // gets the item with a specific id from the table "Movies" table in the database
        public Movie Get(int id)
        {
            using (movieContext = new MovieStudioContext())
            {
                return movieContext.Movies.Find(id);
            }
        }

        // adds new item in the "Movies" table in the database
        public void Add(Movie movie)
        {
            using (movieContext = new MovieStudioContext())
            {
                movieContext.Movies.Add(movie);
                movieContext.SaveChanges();
            }
        }

        // updates an item from the database's table "Movies" by given object from the class Movie
        // if item with the object's id exists
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

        // deletes item from the database's table "Movies" by given id
        // if item with thethe given id exists
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
