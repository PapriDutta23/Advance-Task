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
    public class Language

    {
        [Given(@"I click on LANGUAGE data tab")]
        public void GivenIClickOnLANGUAGEDataTab()
        {
            LanguagePage create = new LanguagePage();
            create.languagetab();
        }

        [When(@"I press ADD NEW button and then I enter Add Language and Level and press Add")]
        public void WhenIPressADDNEWButtonAndThenIEnterAddLanguageAndLevelAndPressAdd()
        {
            LanguagePage create = new LanguagePage();
            create.addlanguage();
        }

        [Then(@"I should able to validate added NEW LANGUAGE record Successfully")]
        public void ThenIShouldAbleToValidateAddedNEWLANGUAGERecordSuccessfully()
        {
            LanguagePage create = new LanguagePage();
            create.ValidateAddLanguage();
        }

       

        [When(@"I press Update pen and Update The  Language and Level and press the UPDTAE button")]
        public void WhenIPressUpdatePenAndUpdateTheLanguageAndLevelAndPressTheUPDTAEButton()
        {
            LanguagePage create = new LanguagePage();
            create.UpdateLanguage();
        }

        [Then(@"I should able to validate new UPDATED LANGUAGE record Successfully")]
        public void ThenIShouldAbleToValidateNewUPDATEDLANGUAGERecordSuccessfully()
        {
            LanguagePage create = new LanguagePage();
            create.Validate_Update_language();
        }

        [When(@"I press CROSS delete sign")]
        public void WhenIPressCROSSDeleteSign()
        {
            LanguagePage create = new LanguagePage();
            create.DeleteLanguage();
        }

        [Then(@"I should not be able to see the DELETED LANGUAGE and should receive a Pop up message")]
        public void ThenIShouldNotBeAbleToSeeTheDELETEDLANGUAGEAndShouldReceiveAPopUpMessage()
        {
            LanguagePage create = new LanguagePage();
            create.ValidateDelLanguage();
        }



    }
}
