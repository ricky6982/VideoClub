using System;
using TechTalk.SpecFlow;
using VideoClub.Core;

namespace VideoClub.SpecFlowTest
{
    [Binding]
    public class ControlUserRegisterSteps
    {
        private User _user;

        [BeforeScenario()]
        public void Hook()
        {
            _user = new User();
        }

        [Given(@"I am not a member of a video club")]
        public void GivenIAmNotAMemberOfAVideoClub()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter ""(.*)"" as the name")]
        public void GivenIEnterMaxiAsTheName(string name)
        {
            _user.Name = name;
        }
        
        [Given(@"I enter ""(.*)"" as the lastname")]
        public void GivenIEnterToppAsTheLastname(string lastname)
        {
            _user.Lastname = lastname;
        }
        
        [Given(@"I am a member of a video club")]
        public void GivenIAmAMemberOfAVideoClub()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click Register Me")]
        public void WhenIClickRegisterMe()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a member number is given to me")]
        public void ThenAMemberNumberIsGivenToMe()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a message is shown telling me that I'm allready a member of the club")]
        public void ThenAMessageIsShownTellingMeThatIMAllreadyAMemberOfTheClub()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
