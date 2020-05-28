using NUnit.Framework;
using Data.Model;
using Business;

using System.Collections.Generic;
using Data;
using System;
using System.Linq;

namespace NUnitTests
{
    public class Tests
    {
        //Mock<MovieBusiness> movieBusiness = new Mock<MovieBusiness>();
        //  Mock<ICustomerView> mockView = new Mock<ICustomerView>();

        MovieBusiness movieBusiness = new MovieBusiness();
        StudioBusiness studioBusiness = new StudioBusiness();

        //public Movie movie
        //{
        //    get
        //    {
        //        return this.movie;
        //    }
        //    set
        //    {
        //        movie = new Movie
        //        {
        //            Title = "Batman",
        //            Year = 2008,
        //            Image = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 90 },
        //            Genre = "Action",
        //            Director = "Christopher Nolan",
        //            Rating = "PG-13",
        //            StudioMId = studio.Id
        //        };
        //    }
        //}
        //public Studio studio
        //{
        //    get
        //    {
        //        return this.studio;
        //    }
        //    set
        //    {
        //    }
        //}

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddStudioStudioIdGreaterThanZero()
        {
            Studio studio = new Studio
                  {
                      Name = "Warner Bros"
                  };
            List<Studio> studios = studioBusiness.GetAll();
            studioBusiness.Add(studio);
            int studioId = studios.Where(a => a.Name == studio.Name).Single().Id;
            Assert.IsTrue(studioId > 0);

        }


        [Test]
        public void AddMovieMovieIdGreaterThanZero()
        {
            
            movieBusiness.Add(movie);
            var id = movie.Id;
            Assert.IsTrue(id > 0);
        }

        [Test]
        public void AddMovieSameMovieTitles()
        {
            //movieBusiness.Add(movie);
            movie = movieBusiness.Get(movie.Id);
            Assert.AreEqual("Batman", movie.Title);
        }


        [Test]
        public void GetMovie()
        {
            int movieId = movie.Id;
            Movie searchedMovie = movieBusiness.Get(movieId);
            Assert.AreEqual(movie.Title, searchedMovie.Title);
        }

        [Test]
        public void GetStudio()
        {
            int studioId = studio.Id;
            Studio searchedStudio = studioBusiness.Get(studioId);
            Assert.AreEqual("Marvel", searchedStudio.Name);
        }

        [Test]
        public void GetAllMovies()
        {
            List<Movie> listOfMovies = new List<Movie> { movie, movie };

            foreach (var item in listOfMovies)
            {
                movieBusiness.Add(item);
            }

            List<Movie> listOfMoviesInDB = movieBusiness.GetAll();

            Assert.AreEqual(listOfMovies.Count + 1, listOfMoviesInDB.Count);
        }

        [Test]
        public void GetAllStudios()
        {
            List<Studio> listOfStudios = new List<Studio> { new Studio(), new Studio() };

            foreach (var item in listOfStudios)
            {
                studioBusiness.Add(item);
            }

            List<Studio> listOfStudiosInDB = studioBusiness.GetAll();

            Assert.AreEqual(listOfStudios.Count + 1, listOfStudiosInDB.Count);
        }

        [Test]
        public void UpdateMovie()
        {
            // movie.Title = "Titanic";
            movie = movieBusiness.Get(movie.Id);
            movie.Title = "Titanic";
            movieBusiness.Update(movie);
            Movie updatedMovie = movieBusiness.Get(movie.Id);
            Assert.AreEqual(movie.Title, updatedMovie.Title);
        }

        [Test]
        public void UpdateStudio()
        {
            // studio.Name = "Marvel";
            studio = studioBusiness.Get(studio.Id);
            studio.Name = "Marvel";
            studioBusiness.Update(studio);
            Studio updatedStudio = studioBusiness.Get(studio.Id);
            Assert.AreEqual(studio.Name, updatedStudio.Name);
        }

        [Test]
        public void DeleteMovie()
        {
            int moviesCountBeforeDelete = movieBusiness.GetAll().Count;
            movieBusiness.Delete(movie.Id);
            int moviesCountAfterDelete = movieBusiness.GetAll().Count;
            Assert.AreEqual(moviesCountBeforeDelete - 1, moviesCountAfterDelete);
        }

        [Test, ]
        public void DeleteStudio()
        {
            int studiosCountBeforeDelete = studioBusiness.GetAll().Count;
            studioBusiness.Delete(studio.Id);
            int studiosCountAfterDelete = studioBusiness.GetAll().Count;
            Assert.AreEqual(studiosCountBeforeDelete - 1, studiosCountAfterDelete);
        }
    }
}