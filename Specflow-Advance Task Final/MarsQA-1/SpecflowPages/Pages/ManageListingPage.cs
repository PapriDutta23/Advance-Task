using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class ManageListingPage
    {

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='remove icon'])[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        //Click on Yes 
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Yes')]")]
        private IWebElement Yes { get; set; }

        //Click on No 
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'No')]")]
        private IWebElement No { get; set; }

        public void Validate_ShareSkill_NewRecord()
        {
            Thread.Sleep(2000);
            //Click on Manage Listing button
            Click_Action(manageListingsLink);

            //Iterating through the table on First Page
            try
            {
                for (int a = 1; a <= 5; a++)
                {
                    for (int i = 2; i <= 18; i = i + 4)
                    {
                        Thread.Sleep(2000);
                        //Get the Text of the "Category"
                        var Category = Driver.driver.FindElement(By.XPath("(//td[contains(@class,'one wide')])[+ i +]")).Text;
                        //Assert the Category
                        Assert.Equals(Category, ExcelLibHelper.ReadData(2, "Category"));

                        for (int j = 1; j <= 9; j = j + 2)
                        {
                            //Get The Text of the "Title"
                            Thread.Sleep(2000);
                            var Title = Driver.driver.FindElement(By.XPath("(//td[@class='four wide'])[+ j +]")).Text;
                            //Assert the Titel
                            Assert.Equals(Title, ExcelLibHelper.ReadData(2, "Title"));

                            for (int k = 2; k <= 10; k = k + 2)
                            {
                                Thread.Sleep(2000);
                                //Get The Text of "Description"
                                var Description = Driver.driver.FindElement(By.XPath("(//td[contains(@class,'four wide')])[+ k +]")).Text;
                                Assert.Equals(Description, ExcelLibHelper.ReadData(2, "Description"));
                                break;
                                //Assert the Description
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test case is Failed");
            }

        }
        //Edit manage listing

         public void Click_Manage_Listing()
        {
            //Click on Manage Listing button
            Click_Action(manageListingsLink);
        }

        public void Edit_manage_Listing()
        {

             //click the edit button
            Click_Action(edit);
         

        }


        public void Add_New_Manage_Listing()
        {
            //creating an instance of Share Skill page
            ShareSkillPage NewEntry = new ShareSkillPage();

            //adition of New Share Skill
            NewEntry.ShareSkillTab();
            NewEntry.ShareSkillAdd();
            NewEntry.ShareSkillSave();
        }


        public void Delete_Record()
        {

            //Click the Delete Button
            Click_Action(delete);

            //Click on Yes Button
            Click_Action(Yes);
 
        }

        public void Validate_Delete()
        {
            Driver.WaitForElement(Driver.driver, By.XPath("//div[contains(@class,'ns-box-inner')]"), 1000);

            //Get the Pop up message for confirmation of Delete
            var message = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;

            //Assertition of Pop Up message
            Assert.That(message, Is.EqualTo("Software Tester has been deleted"));
        }



        //Custom Method for Click action
        public void Click_Action(IWebElement element)
        {
            element.Click();
        }


    }
}









        



    







