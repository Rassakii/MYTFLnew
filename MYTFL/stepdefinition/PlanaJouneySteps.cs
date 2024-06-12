using MYTFL.PageOBject;
using MYTFL.setup;
using System;
using TechTalk.SpecFlow;

namespace MYTFL.stepdefinition
{
    [Binding]
   
    public class PlanaJouneySteps
    {
        Base _base;
        Homepage _homepage;
        JouneyPage _journeypage;

        public PlanaJouneySteps( Homepage homepage,
              JouneyPage journeypage,Base basee)
        {
            
            _homepage = homepage;
            _journeypage = journeypage;
            _base = basee;

        }
        [Given(@"Tfl homepage has been open")]
        public void GivenTflHomepageHasBeenOpen()
        {
            _base.StartBrowser();
        }
        
        [Given(@"accepts cookies")]
        public void GivenAcceptsCookies()
        {
            
        }
        
        [When(@"a user inputs the from box with ""(.*)""")]
        public void WhenAUserInputsTheFromBoxWith(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a user wait until the location pops up")]
        public void WhenAUserWaitUntilTheLocationPopsUp()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user clicks on kent")]
        public void WhenTheUserClicksOnKent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user inputs ""(.*)"" in the to box")]
        public void WhenTheUserInputsInTheToBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user waits until woolwich road pops up")]
        public void WhenTheUserWaitsUntilWoolwichRoadPopsUp()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user clicks on woolwich road")]
        public void WhenTheUserClicksOnWoolwichRoad()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user clicks on time change")]
        public void WhenTheUserClicksOnTimeChange()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user selects day drop down")]
        public void WhenTheUserSelectsDayDropDown()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user  clicks ""(.*)""")]
        public void WhenUserClickss(string day)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user  select timedropdown")]
        public void WhenUserSelectTimedropdown()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user clicks ""(.*)""")]
        public void WhenUserClicks(string time)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"usr clicks on plan my journey")]
        public void WhenUsrClicksOnPlanMyJourney()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Journey is planned based on transport means")]
        public void ThenTheJourneyIsPlannedBasedOnTransportMeans()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
