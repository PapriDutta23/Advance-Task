using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using MarsQA_1.SpecflowPages.Pages;


namespace MarsQA_1.Hook_up
{
    [Binding]
    public class AddProfileDetailsSteps
    {
        [Given(@"I click on Availabilty button")]
        public void GivenIClickOnAvailabiltyButton()
        {
            ProfilePage Create = new ProfilePage();
            Create.AvailabilityButton();
        }
        [When(@"I add availability")]
        public void WhenIAddAvailability()
        {
            ProfilePage Create = new ProfilePage();
            Create.AddAvailability();
        }

        [Given(@"I click on earn target button")]
        public void GivenIClickOnEarnTargetButton()
        {
            ProfilePage Create = new ProfilePage();
            Create.EarnTargetButton();
        }
        [When(@"I add earn target")]
        public void WhenIAddEarnTarget()
        {
            ProfilePage Create = new ProfilePage();
            Create.AddEarnTarget();
        }

        [Given(@"I click on Add hours button")]
        public void GivenIClickOnAddHoursButton()
        {
            ProfilePage Create = new ProfilePage();
            Create.HoursButton();
        }
        [When(@"I add Hours")]
        public void WhenIAddHours()
        {
            ProfilePage Create = new ProfilePage();
            Create.AddHours();
        }

        [Then(@"I should be able to read pop up")]
        public void ThenIShouldBeAbleToReadPopUp()
        {
            ProfilePage Create = new ProfilePage();
            Create.SuccessAlert();
        }

        //Password Change
        [Given(@"Click on Change Password button")]
        public void GivenClickOnChangePasswordButton()
        {
            ProfilePage Create = new ProfilePage();
            Create.PasswordButton();
        }
        [When(@"I  provide all  the details")]
        public void WhenIProvideAllTheDetails()
        {
            ProfilePage Create = new ProfilePage();
            Create.Password_Change();
        }
        [Then(@"I should be able to see change password")]
        public void ThenIShouldBeAbleToSeeChangePassword()
        {
            ProfilePage Create = new ProfilePage();
            Create.SuccessAlert();
        }

        //Description Change
        [Given(@"I click on description")]
        public void GivenIClickOnDescription()
        {
            ProfilePage Create = new ProfilePage();
            Create.DescriptionButton();
        }
        [When(@"I have entered description using characters and click on save button")]
        public void WhenIHaveEnteredDescriptionUsingCharactersAndClickOnSaveButton(int p0)
        {
            ProfilePage Create = new ProfilePage();
            Create.AddDescription();
        }





    }
}
