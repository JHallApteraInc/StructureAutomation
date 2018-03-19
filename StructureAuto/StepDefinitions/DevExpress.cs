using OpenQA.Selenium;
using StructureAuto.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace StructureAuto.StepDefinitions
{
    [Binding]
    class DevExpress : BaseSteps
    {
        private readonly ScenarioContext scenarioContext;
        public DevExpress(ScenarioContext scenarioContext)
        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario("CustomizeReport")]
        public void BeforeCustomizeReportScenario()
        {
            LoadConfigValues();
            CheckBrowser();
            scenarioContext["Driver"] = Driver;
        }

        [AfterScenario("CustomizeReport")]
        public void AfterCustomizeReportScenario()
        {
            Teardown();
        }

        [Given(@"I have logged in")]
        public void GivenIHaveLoggedIn()
        {
            Given("I am on the login page for Structure");
            Given("I have entered my username and password");
            When("I press sign in");
            Then("I should login and be redirected to the main page");
            Driver = (IWebDriver)scenarioContext["Driver"];
        }

        [Given(@"I am on the Reports page")]
        public void GivenIAmOnTheReportsPage()
        {
            ReportPage reportPage = new ReportPage(Driver);
            reportPage.VisitReportPage();
        }

        [When(@"I attempt to customize a report")]
        public void WhenIAttemptToCustomizeAReport()
        {
            ReportPage reportPage = new ReportPage(Driver);
            reportPage.ClickCustomize();
        }

        [Then(@"the result is that I do not see an awkward error")]
        public void ThenTheResultIsThatIDoNotSeeAnAwkwardError()
        {
            ReportPage reportPage = new ReportPage(Driver);
            reportPage.SaveChanges();            
        }
        
    }
}
