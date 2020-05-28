using NUnit.Framework;
using Data.Model;
using Business;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{

    public class Tests
    {
        #region sets the (data for the) Arrange part of the tests

        MovieBusiness movieBusiness = new MovieBusiness();
        StudioBusiness studioBusiness = new StudioBusiness();
       
        // sets the data that will be used in the tests
        private Studio studio = new Studio
        {
            Name = "asdf"
        };

        private Movie movie = new Movie
        {
            Title = "asdf",
            Year = 2002,
            Image = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 90 },
            Genre = "Action",
            Director = "fghj",
            Rating = "PG-13"

        };
        #endregion

        [OneTimeTearDown] 
        // a method that will be called after all tests are run
        // clears the aftermath of the tests from the database
        public void OneTimeTearDown()
        {
            List<int> movieIds = new List<int>();
            foreach (var m in movieBusiness.GetAll())
            {
                if (m.Title == movie.Title)
                {
                    movieIds.Add(m.Id);
                }
            }

            foreach (var id in movieIds)
            {
                movieBusiness.Delete(id);
            }

            List<int> studioIds = new List<int>();
            foreach (var s in studioBusiness.GetAll())
            {
                if (s.Name == studio.Name || (s.Name == "asdf"))
                {
                    studioIds.Add(s.Id);
                }
            }

            foreach (var id in studioIds)
            {
                studioBusiness.Delete(id);
            }
        }

        [Test]
        public void Should_Add_New_Studio_With_Id_Greater_Than_Zero()
        { 
            // Act
            studioBusiness.Add(studio);
            List<Studio> studios = studioBusiness.GetAll();
            int studioId = studios.Where(a => a.Name == studio.Name).ToList()[0].Id;

            // Assert
            Assert.IsTrue(studioId > 0);
        }

        [Test]
        public void Should_Add_New_Movie_With_Id_Greater_Than_Zero()
        {
           
            studioBusiness.Add(studio);
            movie.StudioMId = studioBusiness.GetAll().Where(a => a.Name == studio.Name).ToList()[0].Id;
            // Act
            movieBusiness.Add(movie);
            List<Movie> movies = movieBusiness.GetAll();
            int movieId = movies.Where(a => a.Title == movie.Title).ToList()[0].Id;
            var id = movie.Id;
            // Assert
            Assert.IsTrue(id > 0);

        }

        [Test]
        public void GetMovieById_Returns_OkResult()
        {
            studioBusiness.Add(studio);
            movie.StudioMId = studioBusiness.GetAll().Where(a => a.Name == studio.Name).ToList()[0].Id;
            int movieId = movieBusiness.GetAll().Where(a => a.Title == movie.Title).ToList()[0].Id;
            // Act
            Movie searchedMovie = movieBusiness.Get(movieId);
            // Assert
            Assert.AreEqual(movie.Title, searchedMovie.Title);
        }

        [Test]
        public void GetStudioById_Returns_OkResult()
        {
            int studioId = studioBusiness.GetAll().Where(a => a.Name == studio.Name).ToList()[0].Id;
            // Act
            Studio searchedStudio = studioBusiness.Get(studioId);
            // Assert
            Assert.AreEqual(studio.Name, searchedStudio.Name);
        }

        [Test]
        public void GetAllMovies_Returns_OkResult()
        {
            studioBusiness.Add(studio);
            movie.StudioMId = studioBusiness.GetAll().Where(a => a.Name == studio.Name).ToList()[0].Id;
            List<Movie> listOfMovies = new List<Movie> { movie, movie };
            int countBeforeAdd = movieBusiness.GetAll().Count;
            foreach (var item in listOfMovies)
            {
                movieBusiness.Add(item);
            }

            // Act
            List<Movie> listOfMoviesInDB = movieBusiness.GetAll();
            // Assert
            Assert.AreEqual(countBeforeAdd +2, listOfMoviesInDB.Count);
        }

        [Test]
        public void GetAllStudios_Return_OkResult()
        {
            List<Studio> listOfStudios = new List<Studio> {studio, studio };
            int countBeforeAdd = studioBusiness.GetAll().Count;
            foreach (var item in listOfStudios)
            {
                studioBusiness.Add(item);
            }
            // Act
            List<Studio> listOfStudiosInDB = studioBusiness.GetAll();
            // Assert
            Assert.AreEqual(countBeforeAdd +2, listOfStudiosInDB.Count);
        }

        [Test]
        public void UpdateMovie_ValidData_Return_OkResult()
        {
            studioBusiness.Add(studio);
            movie.StudioMId = studioBusiness.GetAll().Where(a => a.Name == studio.Name).ToList()[0].Id;
            int movieId = movieBusiness.GetAll().Where(a => a.Title == movie.Title).ToList()[0].Id;
            movie = movieBusiness.Get(movieId);
            movie.Title = "hbjknl";
            // Act
            movieBusiness.Update(movie);
            Movie updatedMovie = movieBusiness.Get(movieId);
            // Assert
            Assert.AreEqual(movie.Title, updatedMovie.Title);
        }

        [Test]
        public void UpdateStudio_ValidData_Return_OkResult()
        {
            int studioId = studioBusiness.GetAll().Where(a => a.Name == studio.Name).ToList()[0].Id;
            studio = studioBusiness.Get(studioId);
            studio.Name = "hjk";
            // Act
            studioBusiness.Update(studio);
            Studio updatedStudio = studioBusiness.Get(studioId);
            // Assert
            Assert.AreEqual(studio.Name, updatedStudio.Name);
        }

        [Test]
        public void DeleteMovie_Return_OkResult()
        {
           
            studioBusiness.Add(studio);
            movie.StudioMId = studioBusiness.GetAll().Where(a => a.Name == studio.Name).ToList()[0].Id;
             movieBusiness.Add(movie);
            int movieId = movieBusiness.GetAll().Where(a => a.Title == movie.Title).ToList()[0].Id;
            int moviesCountBeforeDelete = movieBusiness.GetAll().Count;
            // Act
            movieBusiness.Delete(movieId);
            int moviesCountAfterDelete = movieBusiness.GetAll().Count;
            // Assert
            Assert.AreEqual(moviesCountBeforeDelete - 1, moviesCountAfterDelete);
        }

        [Test]
        public void DeleteStudio_Return_OkResult()
        {
            int studioId = studioBusiness.GetAll().Where(a => a.Name == studio.Name).ToList()[0].Id;
            int studiosCountBeforeDelete = studioBusiness.GetAll().Count;
            // Act
            studioBusiness.Delete(studioId);
            int studiosCountAfterDelete = studioBusiness.GetAll().Count;
            // Assert
            Assert.AreEqual(studiosCountBeforeDelete - 1, studiosCountAfterDelete);
        }        
    }
}