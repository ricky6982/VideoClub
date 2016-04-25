using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using VideoClub.Core;
using VideoClub.Core.Enums;

namespace VideoClub.SpecFlowTest
{
    [Binding]
    public class AccessToMoviesSteps
    {
        private Club _videoClub;
        private User _usuario;
        private List<Pelicula> peliculasPorCategoria;
        private List<Pelicula> peliculasPorDirector;
        private object x;

        [BeforeScenario()]
        public void Hook()
        {
            _videoClub = new Club();
            var director1 = new Director("Steven Spielberg");
            var director2 = new Director("George Lucas");
            var pelicula1 = new Pelicula("Duro de Matar 4", "1995", CategoriaType.Accion, director2);
            var pelicula2 = new Pelicula("Volver al Futuro", "1985", CategoriaType.Comedia, director2);
            var pelicula3 = new Pelicula("Matrix", "2001", CategoriaType.Ficcion, director2);
            var pelicula4 = new Pelicula("Star Wars", "1995", CategoriaType.Ficcion, director1);
            _videoClub.Catalogo.Add(pelicula1);
            _videoClub.Catalogo.Add(pelicula2);
            _videoClub.Catalogo.Add(pelicula3);
            _videoClub.Catalogo.Add(pelicula4);
        }

        [Given(@"I am a member of the video club")]
        public void GivenIAmAMemberOfTheVideoClub()
        {
            _usuario = new User("Maxi", "Topp");
            _videoClub.AddMember(_usuario);
        }

        [When(@"I enter my member number")]
        public void WhenIEnterMyMemberNumber()
        {
            _videoClub.Users.Select(x => x.Number == _usuario.Number);
        }

        [When(@"I select the movies catalogs")]
        public void WhenISelectTheMoviesCatalogs()
        {
            var moviesSelected = _videoClub.Catalogo.Where(x => x.Categoria == CategoriaType.Ficcion);
            foreach (var movie in moviesSelected)
            {
                _usuario.SelectMovie(movie);
            }
        }

        [When(@"I select a categories")]
        public void WhenISelectACategories()
        {
            var peliculas = _videoClub.Catalogo.Where(x => x.Categoria == CategoriaType.Accion);
            foreach (var  pelicula in peliculas)
            {
                peliculasPorCategoria.Add(pelicula);
            }
        }

        [When(@"I enter the name of a director")]
        public void WhenIEnterTheNameOfADirector()
        {
            var peliculas = _videoClub.Catalogo.Where(x. => x.Director.Name == "George Lucas");
            foreach (var pelicula in peliculas)
            {
                peliculasPorCategoria.Add(pelicula);
            }
        }

        [Then(@"I can see all movies made by the director paged by (.*) items at a time")]
        public void ThenICanSeeAllMoviesMadeByTheDirectorPagedByItemsAtATime(int p0)
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"I can see all movies from that category paged by (.*) items at a time")]
        public void ThenICanSeeAllMoviesFromThatCategoryPagedByItemsAtATime(int itemsPerPage)
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"I can access all movies paged by (.*) movies at a time")]
        public void ThenICanAccessAllMoviesPagedByMoviesAtATime(int itemsPerPage)
        {
            Assert.IsTrue(_videoClub.Catalogo.Count < itemsPerPage);
        }

        [Then(@"I am granted access to the system")]
        public void ThenIAmGrantedAccessToTheSystem()
        {
            Assert.AreEqual((int)TypeUser.Member, _usuario.Type);
        }
    }
}
