using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;


namespace seleniumTest
{
    [TestFixture]
    public class login
    {
        [Test]
        public void browseGoogleSite()
        {

            IWebDriver _driver = new ChromeDriver();
            //IWebDriver _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://www.google.ca");
            //lst-ib
            //btnG


              IWebElement text =   _driver.FindElement(By.Id("lst-ib"));//.SendKeys("serach for test");
              text.SendKeys("test for QA");

              IWebElement sub = _driver.FindElement(By.Name("btnG"));
             // text.Submit();
              sub.Click();
        }

       
        

    }
}
