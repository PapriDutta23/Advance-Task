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
    public class ShareSkill
    {
        [Given(@"I click on the SHARE SKILL tab")]
        public void GivenIClickOnTheSHARESKILLTab()
        {
            ShareSkillPage ShrSkill = new ShareSkillPage();
            ShrSkill.ShareSkillTab();
        }

        [When(@"I enter all the fields in the Share Skill according to my Skill level")]
        public void WhenIEnterAllTheFieldsInTheShareSkillAccordingToMySkillLevel()
        {
            ShareSkillPage ShrSkill = new ShareSkillPage();
            ShrSkill.ShareSkillAdd();
        }

        [When(@"I press the SAVE button")]
        public void WhenIPressTheSAVEButton()
        {
            ShareSkillPage ShrSkill = new ShareSkillPage();
            ShrSkill.ShareSkillSave();
        }

        [Then(@"I should be able to have a my newly added skill in Manage Listing Page")]
        public void ThenIShouldBeAbleToHaveAMyNewlyAddedSkillInManageListingPage()
        {
            ManageListingPage MngListing = new ManageListingPage();
            MngListing.Validate_ShareSkill_NewRecord();
        }


    }
}
