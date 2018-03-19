using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using StructureAuto.PageObjects;
using OpenQA.Selenium;

namespace StructureAuto.StepDefinitions
{
    [Binding]
    class LoginSteps : BaseSteps
    {
        private readonly ScenarioContext scenarioContext;
        public LoginSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario("Login")]
        public void BeforeLoginScenario()
        {
            LoadConfigValues();
            CheckBrowser();
            scenarioContext["Driver"] = Driver;
        }

        [AfterScenario("Login")]
        public void AfterLoginScenario()
        {
            Teardown();
        }

        [Given(@"I am on the login page for Structure")]
        public void GivenIAmOnTheLoginPageForStructure()
        {
            Driver = (IWebDriver)scenarioContext["Driver"];
            HomePage homePage = new HomePage(Driver);
            homePage.VisitHomepage();
        }

        [Given(@"I have entered my username and password")]
        public void GivenIHaveEnteredMyUsernameAndPassword()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.EnterLoginCredentials();
        }

        [When(@"I press sign in")]
        public void WhenIPressSignIn()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.ClickLogin();
        }

        [Then(@"I should login and be redirected to the main page")]
        public void ThenIShouldLoginAndBeRedirectedToTheMainPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.VerifyLogin();
        }
    }
}

