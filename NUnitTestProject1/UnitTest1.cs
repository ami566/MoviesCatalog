using Business;
using Data.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1
{
    public class Tests
    {
        MovieBusiness movieBusiness = new MovieBusiness();
        StudioBusiness studioBusiness = new StudioBusiness();
       
         public Studio studio = new Studio
                {
                    Name = "Sony"
                };
      
        public Movie movie = new Movie
        {
            Title = "Batman",
            Year = 2008,
            Image = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 90 },
            Genre = "Action",
            Director = "Christopher Nolan",
            Rating = "PG-13",
            StudioMId = studio.Id
        };
        
       

[SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddStudioStudioIdGreaterThanZero()
        {
            Studio studio = new Studio
            {
                Name = "Sony"
            };
            List<Studio> studios = studioBusiness.GetAll();
            studioBusiness.Add(studio);
            int studioId = studios.Where(a => a.Name == studio.Name).SingleOrDefault().Id;
            Assert.IsTrue(studioId > 0);
        }
    }
}