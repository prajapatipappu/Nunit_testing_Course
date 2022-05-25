using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using LIB;
using System.Threading;

namespace Course
{
  
    public class UnitTest1 :Class1
    {
        [SetUp]
        public void intiliaze()
        {
            
            
        
            chrome("https://courses.letskodeit.com/practice");
            
            sleep(2000);
        }

        [Test]
        public void radiobutton()
        {
            
           xpath("//input[@id='bmwradio']").Click();
            sleep(2000);
            xpath("//input[@id='benzradio']").Click();
            sleep(2000);
           xpath(" //input[@id='hondaradio']").Click();
            sleep(2000);
        }
        [Test]
        public void select_class()
        {
            
            xpath(" //select[@id='carselect'] ").Click();
            sleep(2000);
            xpath(" //select[@id='carselect'] // option[@value='benz']").Click();
            sleep(2000);
        }
        [Test]
        public void MultipleSelect()
        {
           
            xpath(" //select[@id='multiple-select-example'] // option[@value='apple']").Click();
            sleep(2000);
            xpath(" //select[@id='multiple-select-example'] // option[@value='orange']").Click();
            sleep(2000);
        }
        [Test]
        public void CheckBox()
        {


            
            xpath("//input[@id='bmwcheck']").Click();
            sleep(2000);
            xpath("//input[@id='benzcheck']").Click();
            sleep(2000);
           xpath("//input[@id='hondacheck']").Click();
            sleep(2000);
        }
        [Test]
        public void Switch_Tab()
        {
            
            xpath("//a[@id='opentab']").Click();
            sleep(2000);
            string x = Driver.WindowHandles[1];
            string y = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(x);
            sleep(2000);
            Driver.Close();

            sleep(2000);
            Driver.SwitchTo().Window(y);
            sleep(2000);
        }
        [Test]
        public void Switch_Window()
        {
            
           xpath("//button[@id='openwindow']").Click();
            sleep(2000);

            string a = Driver.WindowHandles[1];
            string b = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(a);
            sleep(2000);
            Driver.Close();

            sleep(2000);
            Driver.SwitchTo().Window(b);
            sleep(2000);

        }

        [Test]
        public void Switch_To_Alert()
        {
            
            xpath("//input[@id='name']").SendKeys("Pappu");
            sleep(2000);
            xpath("//input[@id='alertbtn']").Click();
            sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            sleep(2000);
            xpath("//input[@id='confirmbtn']").Click();
            sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            sleep(2000);
        }
        [Test]
        public void Web_Table()
        {
            
           xpath("//table[@id='product']").Click();
            sleep(2000);
        }
        [Test]
        public void Mouse_Hover()
        {
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            sleep(2000);
            xpath("//button[@id='mousehover']").Click();
            //Driver.FindElement(By.XPath("//a[@href='#top']")).Click();
            sleep(2000);
            
              

                js.ExecuteScript("window.scrollBy(0,500)");
            IWebElement top = xpath("//button[@id='mousehover']");
                top.Click();
                sleep(2000);
                Actions act = new Actions(Driver);

            act.MoveToElement(xpath("//button[@id='mousehover']"))
                    .KeyDown(Keys.Down)
                    .Click()
                .Perform();
                sleep(2000);
                js.ExecuteScript("window.scrollBy(0,500)");
            xpath("//button[@id='mousehover']")
                   .Click();
                sleep(2000);
                Actions action = new Actions(Driver);
                action.MoveToElement(xpath("//button[@id='mousehover']"))

                    .KeyDown(Keys.Down)
                    .KeyDown(Keys.Down)
                    .Click()
                    .Perform();
            sleep(2000);


            }
        [TearDown]
        public void close()
        {

            exit();
        }

    }
}
