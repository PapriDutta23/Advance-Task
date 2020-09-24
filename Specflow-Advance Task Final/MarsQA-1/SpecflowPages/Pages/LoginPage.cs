﻿using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;


namespace MarsQA_1.Pages
{
    public class LoginPage
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        public  void website()
        {
            Driver.NavigateUrl();
           
        }

        public  void logindetails()
        {
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2, "username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));

        }

        public  void loginbutton()
        {
            LoginBtn.Click();
        }

            
    }
}