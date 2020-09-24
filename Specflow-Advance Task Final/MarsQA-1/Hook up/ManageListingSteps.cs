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
    public class ManageListingSteps
    {
        [Given(@"I Click on the   MANAGE LISTING tab on my PROFILE page")]
        public void GivenIClickOnTheMANAGELISTINGTabOnMyPROFILEPage()
        {
            ManageListingPage MngListing = new ManageListingPage();
            MngListing.Click_Manage_Listing();
        }
        
        [Given(@"I click on the PEN like Update/Edit button")]
        public void GivenIClickOnThePENLikeUpdateEditButton()
        {
            ManageListingPage MngListing = new ManageListingPage();
            MngListing.Edit_manage_Listing();
        }
        
                
        [When(@"Add New SHARE SKILL/New SERVICES")]
        public void WhenAddNewSHARESKILLNewSERVICES()
        {
            ManageListingPage MngListing = new ManageListingPage();
            MngListing.Add_New_Manage_Listing();
        }
        
        [Then(@"I should be able to view the Updated/Edited New services on MANAGE LISTING page")]
        public void ThenIShouldBeAbleToViewTheUpdatedEditedNewServicesOnMANAGELISTINGPage()
        {
            ManageListingPage MngListing = new ManageListingPage();
            MngListing.Validate_ShareSkill_NewRecord();
        }


        [Given(@"I click on the CROSS like DELETE button")]
        public void GivenIClickOnTheCROSSLikeDELETEButton()
        {
            ManageListingPage MngListing = new ManageListingPage();
            MngListing.Delete_Record();
        }

        [Then(@"I should be able get the Confirmation Message of deleting the Added Skill")]
        public void ThenIShouldBeAbleGetTheConfirmationMessageOfDeletingTheAddedSkill()
        {
            ManageListingPage MngListing = new ManageListingPage();
            MngListing.Validate_Delete();
        }
    }
}
