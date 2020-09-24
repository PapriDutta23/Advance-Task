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
    public class Education
    {
        [Given(@"I click on EDUCATION data tab")]
        public void GivenIClickOnEDUCATIONDataTab()
        {

            EducationPage Create = new EducationPage();
            Create.EdctnTab();
                   
        }
        
       
        [When(@"I press ADD NEW button and then I enter College/University Name ,Country of University, Title  , Degree \. Year of Graduation and press Add")]
        public void WhenIPressADDNEWButtonAndThenIEnterCollegeUniversityNameCountryOfUniversityTitleDegree_YearOfGraduationAndPressAdd()
        {
            EducationPage Create = new EducationPage();
            Create.AddNewEdctn();
        }

        [Then(@"I should able to validate added NEW EDUCATION record Successfully")]
        public void ThenIShouldAbleToValidateAddedNEWEDUCATIONRecordSuccessfully()
        {
            EducationPage Create = new EducationPage();
            Create.ValidateAddEducation();

        }


        [When(@"I press Update pen and Update The College/University Name ,Country of University, Title  , Degree \. Year of Graduation with new data and press UPDATE button")]
        public void WhenIPressUpdatePenAndUpdateTheCollegeUniversityNameCountryOfUniversityTitleDegree_YearOfGraduationWithNewDataAndPressUPDATEButton()
        {
            EducationPage Create = new EducationPage();
            Create.UpdateEducation();

        }
             
        [Then(@"I should able to validate UPDATED EDUCATION Successfully")]
        public void ThenIShouldAbleToValidateUPDATEDEDUCATIONSuccessfully()
        {
            EducationPage Create = new EducationPage();
            Create.ValidateUpdateEducation();

        }

        [When(@"I press CROSS delete sign for education")]
        public void WhenIPressCROSSDeleteSignForEducation()
        {
            EducationPage Create = new EducationPage();
            Create.ValidateDelEducation();
        }


        [Then(@"I should not be able to see the DELETED EDUCATION and should receive a Pop up message")]
        public void ThenIShouldNotBeAbleToSeeTheDELETEDEDUCATIONAndShouldReceiveAPopUpMessage()
        {
            EducationPage Create = new EducationPage();
            Create.DeleteEducation();

        }
    }
}
