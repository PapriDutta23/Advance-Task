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
    public class Certification
    {
        [Given(@"I click on CERTIFICATION data tab")]
        public void GivenIClickOnCERTIFICATIONDataTab()
        {
            CertificationPage Create = new CertificationPage();
            Create.CeritificateationTab();
        }
        
        [When(@"I press ADD NEW button and then I enter Certificate ,Certificate From,  Year  and press Add")]
        public void WhenIPressADDNEWButtonAndThenIEnterCertificateCertificateFromYearAndPressAdd()
        {
            CertificationPage Create = new CertificationPage();
            Create.AddNewCertification();
        }
        [Then(@"I should able to validate added NEW CERTIFICATION record Successfully")]
        public void ThenIShouldAbleToValidateAddedNEWCERTIFICATIONRecordSuccessfully()
        {
            CertificationPage Create = new CertificationPage();
            Create.ValidateAddCertification();
        }

        [When(@"I press Update pen and Update The Certificate ,Certificate From,  Year  and press the UPDATE button")]
        public void WhenIPressUpdatePenAndUpdateTheCertificateCertificateFromYearAndPressTheUPDATEButton()
        {
            CertificationPage Create = new CertificationPage();
            Create.UpdateCertification();
        }
        [Then(@"I should able to validate UPDATED CERTIFICATION Successfully")]
        
        public void ThenIShouldAbleToValidateUPDATEDCERTIFICATIONSuccessfully()
        {
            CertificationPage Create = new CertificationPage();
            Create.ValidateUpdatedCertification();
        }
        [When(@"I press CROSS delete sign for Certification")]
        public void WhenIPressCROSSDeleteSignForCertification()
        {
            CertificationPage Create = new CertificationPage();
            Create.DeleteCertification();
        }
        [Then(@"I should not be able to see the DELETED CERTIFICATION and should receive a Pop up message")]
        public void ThenIShouldNotBeAbleToSeeTheDELETEDCERTIFICATIONAndShouldReceiveAPopUpMessage()
        {
            CertificationPage Create = new CertificationPage();
            Create.ValidateDelCertification();
        }
    }
}
