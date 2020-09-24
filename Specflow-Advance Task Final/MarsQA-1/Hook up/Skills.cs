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
    public class Skills
    {
        [Given(@"I click on SKILLS data tab")]
        public void GivenIClickOnSKILLSDataTab()
        {
            SkillPage create = new SkillPage();
            create.Skilltab();
        }
        
        [When(@"I press ADD NEW button and then I enter Add Skills and Level and press Add")]
        public void WhenIPressADDNEWButtonAndThenIEnterAddSkillsAndLevelAndPressAdd()
        {
            SkillPage create = new SkillPage();
            create.AddNewskill();
        }
        [Then(@"I should able to validate added NEW SKILLS record Successfully")]
        public void ThenIShouldAbleToValidateAddedNEWSKILLSRecordSuccessfully()
        {
            SkillPage create = new SkillPage();
            create.ValidateAddedSkill();
        }

       

        [When(@"I press Update pen and Update The  SKILLS  and LEVEL and Press the UPDATE button")]
        public void WhenIPressUpdatePenAndUpdateTheSKILLSAndLEVELAndPressTheUPDATEButton()
        {
            SkillPage create = new SkillPage();
            create.UpdateNewSkill();
        }
        [Then(@"I should able to validate new UPDATED SKILLS  record Successfully")]
        public void ThenIShouldAbleToValidateNewUPDATEDSKILLSRecordSuccessfully()
        {
            SkillPage create = new SkillPage();
            create.ValidateUpdateSkill();
        }


        [When(@"I press CROSS delete sign for Skills")]
        public void WhenIPressCROSSDeleteSignForSkills()
        {
            SkillPage create = new SkillPage();
            create.DeleteSkill();
        }
        [Then(@"I should not be able to see the DELETED SKILLS and should receive a Pop up message")]
        public void ThenIShouldNotBeAbleToSeeTheDELETEDSKILLSAndShouldReceiveAPopUpMessage()
        {
            SkillPage create = new SkillPage();
            create.ValidateDelSkill();
        }

    }
}
