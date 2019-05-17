using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using NUnit.Framework;

namespace Test1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        public IWebDriver driver;
        [Given(@"Launch a browser and Enter URL")]
        [Test, Order(1)]
        public void GivenLaunchABrowserAndEnterURL()
        {
            driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://beta.loanspq.com/login.aspx?enc2=36aNbmudSLCCMdjJoYQn6iT9nG7GRjqBbkIAMYcy9aM");
        }

        [When(@"Enter Username")]
        [Test, Order(2)]
        public void WhenEnterUsername()
        {
            driver.FindElement(By.Id("ctl00_bc_LoginMain_txtLogin")).SendKeys("ALOKA_QA_BH");
            driver.FindElement(By.Id("ctl00_bc_LoginMain_btnLogin")).Click();
            driver.FindElement(By.Id("ctl00_bc_MFLPasswordPrompt_Password")).SendKeys("password@2");
            driver.FindElement(By.Id("ctl00_bc_MFLPasswordPrompt_btnSignIn")).Click();
        }
        
        [Then(@"Login page should display")]
        [Test]
        public void ThenLoginPageShouldDisplay()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //driver.Quit();
        }
    }
}
