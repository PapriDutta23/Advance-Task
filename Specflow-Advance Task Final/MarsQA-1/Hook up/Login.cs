using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.Pages;

namespace MarsQA_1.Feature
{
    [Binding]
    class Login
    {
        [Given(@"I naviagte to the Skill Swap Website")]
        public void GivenINaviagteToTheSkillSwapWebsite()
        {
            LoginPage create = new LoginPage();
            create.website();

        }

        [Given(@"I have entered valid Username and password")]
        public void GivenIHaveEnteredValidUsernameAndPassword()
        {
            LoginPage create = new LoginPage();
            create.logindetails();
        }

        [When(@"I press login Button")]
        public void WhenIPressLoginButton()
        {
            LoginPage create = new LoginPage();
            create.loginbutton();
        }

        [Then(@"I should be navigated to My Profile page and can see my Name")]
        public void ThenIShouldBeNavigatedToMyProfilePageAndCanSeeMyName()
        {
           // ScenarioContext.Current.Pending();
        }


    }
}
