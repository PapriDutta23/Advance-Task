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
    public class SkillPage
    {
        //Identifying  the skills button
        IWebElement skillsBtn => Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Skills')]"));
        //Identifying Update Button
        IWebElement updateBtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[4]/tr/td/div/span/input[1]"));

        public void Skilltab()
        {
            //Turn on wait for "SKILLS" Button  and then Click
            Driver.TurnOnWait();
            ConstantHelpers.Click_Operation(skillsBtn);
        }

        public void AddNewskill()
        {
                        //Identifying add new button and then click
            IWebElement addnewskills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            ConstantHelpers.Click_Operation(addnewskills);

            // Identifying add skills text button and then click, sending value
            IWebElement addskillstxt = Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));
            ConstantHelpers.Click_Operation(addskillstxt);
            ConstantHelpers.EnterText(addskillstxt, "Business Analyst");

            //Identifying the skills level dropdown and then click ,  , sending value
            IWebElement skillslevel = Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui fluid dropdown')]"));
            ConstantHelpers.Click_Operation(skillslevel);
            ConstantHelpers.Drop_Down_Select_By_Text(skillslevel, "Expert");


            //Identifying the add new button and then click
            IWebElement skilladd = Driver.driver.FindElement(By.XPath("(//input[contains(@value,'Add')])"));
            ConstantHelpers.Click_Operation(skilladd);
        }
        public void UpdateNewSkill()
        {
            //Identifying the SECOND DATA TAB SKILLS section and the click
            ConstantHelpers.Click_Operation(skillsBtn);
            try
            {
                //Identifying pen like update sign icon from "Skills" Table  and then click
                for (int i = 1; i <= 4; i++)
                {


                    //Get the Text Of The "Language"
                    //  string SkillsTxt = Driver.driver.FindElement(By.XPath("//*[@data-tab ='second']/div/div/div/table/tbody[" + i + "]]/tr/td[1]")).Text;
                    string SkillsTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    //Get the Text of the "Level" of language                                                                                                                 
                    string SkillLvlTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                    if (SkillsTxt == "Business Analyst" && SkillLvlTxt == "Expert")
                    {
                        IWebElement SkillsUpdatePen = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i"));
                        

                        //Click on Update Pen Icon
                        ConstantHelpers.Click_Operation(SkillsUpdatePen);

                        //Get The Skills Text Text Box
                        IWebElement SkillsTxtBx = Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));

                        //Click Language Text Box
                        ConstantHelpers.Click_Operation(SkillsTxtBx);

                        //Clear the Text Box
                        SkillsTxtBx.Clear();

                        //Send data To "Language Text Box"
                        
                        SkillsTxtBx.SendKeys("Scientist");

                        //Get The level DropDown Box and Click
                        IWebElement SkillLvlDrpdwn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select"));
                        SkillLvlDrpdwn.Click();

                        //Select level value from Dropdown Box
                        ConstantHelpers.Drop_Down_Select_By_Text(SkillLvlDrpdwn, "Intermediate");

                        //Identifying Update Button
                        IWebElement UpdateBtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]"));

                        //Click Update
                        UpdateBtn.Click();

                        break;
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void DeleteSkill()
        {
            //Identifying the SECOND DATA TAB SKILLS section and the click
            ConstantHelpers.Click_Operation(skillsBtn);

            try
            {

                for (int i = 1; i <= 4; i++)
                {
                    //Get The Text of The Skill
                    var SkillTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    if (SkillTxt == "Scientist")
                    {
                        //Identify The CROSS sign to delete
                        IWebElement CrsSign = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[ " + i + "]/tr/td[3]/span[2]/i"));

                        //Click Crss Sgn
                        CrsSign.Click();
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }







        }

        public void ValidateAddedSkill()
        {
            //Identifying theSkill tab section and the click
            ConstantHelpers.Click_Operation(skillsBtn);


            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Skill"
                var SkillTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "Level" of skill                                                                                                              
                var LvlTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (SkillTxt == "Business Analyst" && LvlTxt == "Expert")
                    {
                        Console.WriteLine("Added Skill has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public void ValidateUpdateSkill()
        {
            //Identifying theSkill tab section and the click
            ConstantHelpers.Click_Operation(skillsBtn);


            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Skill"
                var SkillTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "Level" of skill                                                                                                              
                var LvlTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (SkillTxt == "Scientist" && LvlTxt == "Intermediate")
                    {
                        Console.WriteLine("Updated Skill has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }


        public void ValidateDelSkill()
        {
            //Identifying theSkill tab section and the click
            ConstantHelpers.Click_Operation(skillsBtn);


            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Skill"
                var SkillTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "Level" of skill                                                                                                              
                var LvlTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (SkillTxt != "Scientist" && LvlTxt != "Intermediate")
                    {
                        Console.WriteLine("Deleted Skill has been Validated");
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









        



    







