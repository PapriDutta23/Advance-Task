using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
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
    public class ProfilePage
    {
        //Identifying The "LOCATION" Globe Sign
        IWebElement Location => Driver.driver.FindElement(By.XPath("//i[contains(@class,'large globe icon')]"));
        //Identifying the "AVAILABILITY " update symbol
        IWebElement AvailabilityUpdate => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[1]"));

        //Identifying the availability dropdown
        IWebElement AvailabilityDropdown => Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyType')]"));

        //Identifying the  hours update symbol
        IWebElement HoursUpdate => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[2]"));

        //Identifying the  availability hours pen like button
        IWebElement HoursDropdown => Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyHour')]"));

        //Identifying the Earn Target update button
        IWebElement EarnTargetUpdate => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[3]"));

        //Identifying the Earn Target pen like button
        IWebElement EarnTargetDropdown => Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyTarget')]"));

        //Identifying "HI Papri" button
        IWebElement Hi_Name => Driver.driver.FindElement(By.XPath("//span[contains(@tabindex,'0')]"));

        //Identifying "CHANGE PASSWORD" from Dropdown box
        IWebElement Change_Pswrd => Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Change Password')]"));

        //Identifying "CURRENT PASSWORD" 
        IWebElement Crnt_Pswrd => Driver.driver.FindElement(By.XPath("//input[@placeholder='Current Password']"));

        //Identifying "NEW PASSWORD" 
        IWebElement Nw_Pswrd => Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'New Password')]"));

        //Identifying "NEW PASSWORD" 
        IWebElement Cnfrm_Pswrd => Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Confirm Password')]"));

        //Identifying "CHANGE PASSWORD SAVE" 
        IWebElement Chng_Pswrd_Sv => Driver.driver.FindElement(By.XPath("//button[@type='button'][contains(.,'Save')]"));

        //Identify the Pen sign in Desccription 
        IWebElement DscrptnPen => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));

        //Identifying The Text box in Description
        IWebElement DscrptnTxtBx => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));

        //Identify SAVE button
        IWebElement save => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));

        


        public void AvailabilityButton()
        {
            //Clicking the availabilityy update sign
            AvailabilityUpdate.Click();
        }
        public void AddAvailability()
        {
            //Clicking the availability dropdown and then choosing value by Text
            AvailabilityDropdown.Click();
            AvailabilityDropdown.SendKeys("Full Time");
            Driver.WaitForElement(Driver.driver, By.XPath("//select[contains(@name,'availabiltyType')]"), 3000);
            AvailabilityDropdown.Click();
            //SuccessAlert();

        }
        public void HoursButton()
        {
            //Clicking the hour update sign
            HoursUpdate.Click();
        }
        public void AddHours()
        {
            //Clicking the Hours dropdown 
            HoursDropdown.Click();
            HoursDropdown.SendKeys("As needed");
            HoursDropdown.Click();
            // SuccessAlert();

        }
         public void EarnTargetButton()
        {
            //Clicking the Earn Target update button
            EarnTargetUpdate.Click();
        }
        public void AddEarnTarget()
        {
                    

            //Clicking the Earn Target pen like button
            EarnTargetDropdown.Click();
            EarnTargetDropdown.SendKeys("More than $1000 per month");
            EarnTargetDropdown.Click();


        }
        public void SuccessAlert()
        {
            Driver.WaitForElement(Driver.driver, By.XPath(" //div[@class='ns-box-inner'][contains(.,'Availability updated')]"), 3000);
            IWebElement ValueAlert = Driver.driver.FindElement(By.XPath(" //div[@class='ns-box-inner'][contains(.,'Availability updated')]"));
            //Get the Text of the "Updated Alert message"
            string Value_Alert_Text = ValueAlert.Text;
            Assert.AreEqual(ValueAlert.Text, "Availability updated");
        }

       
        public void PasswordButton()
        {
            //wait 
            Driver.WaitForElement(Driver.driver, By.XPath("//span[contains(@tabindex,'0')]"), 2000);

            //Click on "Hi Papri" button
            ConstantHelpers.Click_Operation(Hi_Name);

            //Wait for Element
            Driver.WaitForElement(Driver.driver, By.XPath("//a[@class='item'][contains(.,'Change Password')]"), 2000);

            //Click and SELECT "CHANGE PASSWORD" option
            ConstantHelpers.Click_Operation(Change_Pswrd);
        }
        public void Password_Change()
        {
            

            //Click "CURRENT PASSWORD" Field
            ConstantHelpers.Click_Operation(Crnt_Pswrd);

            //Sending Values to "CURRENT PASSWORD" Field
            ConstantHelpers.EnterText(Crnt_Pswrd, "123456");

            //Sending Values to "NEW PASSWORD" Field
            ConstantHelpers.EnterText(Nw_Pswrd, "234567");

            //Sending Values to "CONFIRM PASSWORD" Field
            ConstantHelpers.EnterText(Cnfrm_Pswrd, "234567");

            //Wait for Element
            Driver.WaitForElement(Driver.driver, By.XPath("//button[@type='button'][contains(.,'Save')]"), 2000);

            //Click "CHANGE PASSWORD SAVE" Click
            ConstantHelpers.Click_Operation(Chng_Pswrd_Sv);
        }


        public void DescriptionButton()
        {
            //Click on Pen sign of Description
            DscrptnPen.Click();
        }
        public void AddDescription()
        {
           
            //Click on Description Text Box
            DscrptnTxtBx.Click();

            //Sending dataTo description
            DscrptnTxtBx.SendKeys("Profile Description");

            //Click on Save
            save.Click();
        }
    }
}









        



    







