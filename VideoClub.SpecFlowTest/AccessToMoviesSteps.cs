using System;
using TechTalk.SpecFlow;

namespace VideoClub.SpecFlowTest
{
    [Binding]
    public class AccessToMoviesSteps
    {
        [Given(@"I am a member of the video club")]
        public void GivenIAmAMemberOfTheVideoClub()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my member number")]
        public void WhenIEnterMyMemberNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select the movies catalogs")]
        public void WhenISelectTheMoviesCatalogs()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select a categories")]
        public void WhenISelectACategories()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the name of a director")]
        public void WhenIEnterTheNameOfADirector()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am granted access to the system")]
        public void ThenIAmGrantedAccessToTheSystem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can access all movies paged by (.*) movies at a time")]
        public void ThenICanAccessAllMoviesPagedByMoviesAtATime(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can see all movies from that category paged by (.*) items at a time")]
        public void ThenICanSeeAllMoviesFromThatCategoryPagedByItemsAtATime(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can see all movies made by the director paged by (.*) items at a time")]
        public void ThenICanSeeAllMoviesMadeByTheDirectorPagedByItemsAtATime(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
