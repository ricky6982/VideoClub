using System;
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

        [BeforeScenario()]
        public void Hook()
        {
            _videoClub = new Club();
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
