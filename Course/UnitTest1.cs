using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Course
{
  
    public class UnitTest1
    {
        [SetUp]
        public void TestMethod1()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://courses.letskodeit.com/practice");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Test]
        public void radiobutton()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.FindElement(By.XPath("//input[@id='bmwradio']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='benzradio']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(" //input[@id='hondaradio']")).Click();
            Thread.Sleep(2000);
        }
        [Test]
        public void select_class()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.FindElement(By.XPath(" //select[@id='carselect'] ")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(" //select[@id='carselect'] // option[@value='benz']")).Click();
            Thread.Sleep(2000);
        }
        [Test]
        public void MultipleSelect()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.FindElement(By.XPath(" //select[@id='multiple-select-example'] // option[@value='apple']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(" //select[@id='multiple-select-example'] // option[@value='orange']")).Click();
            Thread.Sleep(2000);
        }
        [Test]
        public void CheckBox()
        {


            IWebDriver Driver = new ChromeDriver();
            Driver.FindElement(By.XPath("//input[@id='bmwcheck']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='benzcheck']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='hondacheck']")).Click();
            Thread.Sleep(2000);
        }
        [Test]
        public void Switch_Tab()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.FindElement(By.XPath("//a[@id='opentab']")).Click();
            Thread.Sleep(2000);
            string x = Driver.WindowHandles[1];
            string y = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(x);
            Thread.Sleep(2000);
            Driver.Close();

            Thread.Sleep(2000);
            Driver.SwitchTo().Window(y);
            Thread.Sleep(2000);
        }
        [Test]
        public void Switch_Window()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.FindElement(By.XPath("//button[@id='openwindow']")).Click();
            Thread.Sleep(2000);

            string a = Driver.WindowHandles[1];
            string b = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(a);
            Thread.Sleep(2000);
            Driver.Close();

            Thread.Sleep(2000);
            Driver.SwitchTo().Window(b);
            Thread.Sleep(2000);

        }

        [Test]
        public void Switch_To_Alert()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Pappu");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='alertbtn']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='confirmbtn']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }
        [Test]
        public void Web_Table()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.FindElement(By.XPath("//table[@id='product']")).Click();
            Thread.Sleep(2000);
        }
        [Test]
        public void Mouse_Hover()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='mousehover']")).Click();
            //Driver.FindElement(By.XPath("//a[@href='#top']")).Click();
            Thread.Sleep(2000);
            
              

                js.ExecuteScript("window.scrollBy(0,500)");
            IWebElement top = Driver.FindElement(By.XPath("//button[@id='mousehover']"));
                top.Click();
                Thread.Sleep(2000);
                Actions act = new Actions(Driver);

            act.MoveToElement(Driver.FindElement(By.XPath("//button[@id='mousehover']")))
                    .KeyDown(Keys.Down)
                    .Click()
                .Perform();
                Thread.Sleep(2000);
                js.ExecuteScript("window.scrollBy(0,500)");
            Driver.FindElement(By.XPath("//button[@id='mousehover']"))
                   .Click();
                Thread.Sleep(2000);
                Actions action = new Actions(Driver);
                action.MoveToElement(Driver.FindElement(By.XPath("//button[@id='mousehover']")))

                    .KeyDown(Keys.Down)
                    .KeyDown(Keys.Down)
                    .Click()
                    .Perform();
            Thread.Sleep(2000);


            }
        [TearDown]
        public void close()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Close();
            Driver.Quit();
        }

    }
}
