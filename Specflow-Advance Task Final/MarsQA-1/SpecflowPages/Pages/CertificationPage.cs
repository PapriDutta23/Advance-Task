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
    public class CertificationPage
    {

        //Identify Certification Tab
        IWebElement CertificationBtn => Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'fourth')]"));

        //Identify "Add New" Button
        IWebElement AddNew => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));

        //Identify The Certificate Text Box
        IWebElement CertificateTxtBx => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));

        //Identify  Certificate From Txt Box
        IWebElement CrtfctFrm => Driver.driver.FindElement(By.XPath("//input[contains(@name,'certificationFrom')]"));

        //Identify The Year Dropdown
        IWebElement Year => Driver.driver.FindElement(By.XPath("//select[contains(@name,'certificationYear')]"));

        //Identify Add Button
        IWebElement add => Driver.driver.FindElement(By.XPath("//input[contains(@value,'Add')]"));

        public void CeritificateationTab()
        {
            //Click on Certification Button
            CertificationBtn.Click();
        }

        public void AddNewCertification()
        {
           

            //Click on Add New Button
            AddNew.Click();

            //Click on Certificate
            CertificateTxtBx.Click();

            //Sending data to certificate
            CertificateTxtBx.SendKeys( "Certificate 4");

            //Click on Certificate From Txt Box
            CrtfctFrm.Click();

            //Sending data to certificate From text box
            CrtfctFrm.SendKeys("TAFE");

            //Click on Year Dropdown 
            Year.Click();

            //Sending value to Year dropdown
            Driver.TurnOnWait();
            Year.SendKeys("2016");

            //Click on Add 
            Driver.TurnOnWait();
            add.Click();
        }
        public void UpdateCertification()

        {
            //Click on Certification Button
            CertificationBtn.Click();
            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    //Get the Text of Certificate
                    var CrtfctTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    //Get the Text of Certificate From 
                    var CrtfctFrmTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                    //Get The Year
                    var YearBxTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[3]")).Text;

                    if (CrtfctTxt == "Certificate 4" && CrtfctFrmTxt == "TAFE" && YearBxTxt == "2018")
                    {

                        //Identify Certification Update Pen
                        IWebElement CertUpdatePen = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]"));
                        Driver.TurnOnWait();

                        //Click on Update Pen Icon
                        ConstantHelpers.Click_Operation(CertUpdatePen);

                        //Click Cert Text Box
                        IWebElement CertupdateTxtBx = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[1]/input"));
                        ConstantHelpers.Click_Operation(CertupdateTxtBx);

                        //Clear the Text Box
                        CertupdateTxtBx.Clear();

                        //Send data To "Cert Text Box"
                        Driver.TurnOnWait();
                        CertupdateTxtBx.SendKeys("Test Analyst");

                        //Click From Text Box
                        IWebElement FromupdateTxtBx = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[2]/input"));
                        ConstantHelpers.Click_Operation(FromupdateTxtBx);

                        //Clear the Text Box
                        FromupdateTxtBx.Clear();

                        //Send data To "Cert Text Box"
                        Driver.TurnOnWait();
                        FromupdateTxtBx.SendKeys("MVPStudio");


                        //Select year value from Dropdown Box
                        Driver.TurnOnWait();
                        IWebElement CertYearDrpdwn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[3]/select"));
                        ConstantHelpers.Drop_Down_Select_By_Text(CertYearDrpdwn, "2012");

                        //Click Update
                        IWebElement Certupdate = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]"));
                        ConstantHelpers.Click_Operation(Certupdate);
                        break;
                    }
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void DeleteCertification()
        {
            // Click on Certification Button
            CertificationBtn.Click();
            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    //Get the Text of Certificate
                    var CrtfctTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    //Get the Text of Certificate From 
                    var CrtfctFrmTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                    //Get The Year
                    var YearBxTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[3]")).Text;

                    if (CrtfctTxt == "Certificate 4" && CrtfctFrmTxt == "TAFE" && YearBxTxt == "2018")
                    {
                        //Identify Certification Update Pen
                        IWebElement CertUpdatePen = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[4]/span[2]"));
                        Driver.TurnOnWait();

                        //Click on Delete Pen Icon
                        ConstantHelpers.Click_Operation(CertUpdatePen);
                        break;
                    }
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ValidateAddCertification()
        {
            //Click on Certification Button
            CertificationBtn.Click();

            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Certificate"
                var CertTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "From"                                                                                                                  
                var FromTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (CertTxt == "Certificate 4" && FromTxt == "TAFE")
                    {
                        Console.WriteLine("Added Certificate has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

        public void ValidateUpdatedCertification()
        {
            //Click on Certification Button
            CertificationBtn.Click();

            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Certificate"
                var CertTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "From"                                                                                                                  
                var FromTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (CertTxt == "Test Analyst" && FromTxt == "MCPStudio")
                    {
                        Console.WriteLine("Udpated Certificate has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

        public void ValidateDelCertification()
        {
            //Click on Certification Button
            CertificationBtn.Click();

            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Certificate"
                var CertTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "From"                                                                                                                  
                var FromTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (CertTxt != "Certificate 4" && FromTxt != "TAFE")
                    {
                        Console.WriteLine("Deleted Certificate has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

    }
}









        



    







