using System;
using TechTalk.SpecFlow;

namespace Specs
{
    [Binding]
    public class UserRegistrationSteps
    {
        [When(@"I attempt to register with following details")]
        public void WhenIAttemptToRegisterWithFollowingDetails(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to log in to the website")]
        public void ThenIShouldBeAbleToLogInToTheWebsite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should receive a welcome email")]
        public void ThenIShouldReceiveAWelcomeEmail()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
