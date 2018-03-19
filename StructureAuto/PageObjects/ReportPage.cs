using System;
using OpenQA.Selenium;

namespace StructureAuto.PageObjects
{
    internal class ReportPage : BasePage
    {
        public ReportPage(IWebDriver Driver) : base(Driver)
        {

        }
        internal void VisitReportPage()
        {
            Visit("/reporting/designer.aspx?id=1056");
        }

        internal void ClickCustomize()
        {
           
            By fieldButton = By.XPath("//*[@id='ReportDesigner']/div/div/div[1]/div[7]/div[1]/div/div[3]/div[1]/div/input");
            WaitUntilDisplayed(fieldButton, WAIT_SECONDS);
            Click(fieldButton);
            Driver.FindElement(fieldButton).SendKeys(Keys.ArrowDown);
            Driver.FindElement(fieldButton).SendKeys(Keys.ArrowDown);
            Driver.FindElement(fieldButton).SendKeys(Keys.ArrowDown);
            Driver.FindElement(fieldButton).SendKeys(Keys.Enter);

            string reportTitle = DateTime.Today.ToString("");
            By timeDetailField = By.XPath("//*[@id='ReportDesigner']/div/div/div[1]/div[7]/div[1]/div/div[4]/div[1]/div/div[2]/div[1]/div/div[2]/div[9]/div/div[5]/div/div/div/div[2]/div[2]/div/input");
            WaitUntilDisplayed(timeDetailField, WAIT_SECONDS);
            Click(timeDetailField);
            Driver.FindElement(timeDetailField).Clear();
            Type(reportTitle, Find(timeDetailField));

        }

        internal void SaveChanges()
        {
            By customizeLink = By.CssSelector(".dxrd-menu-button-image");
            WaitUntilClickable(customizeLink, WAIT_SECONDS);
            Click(customizeLink);

            By saveButton = By.CssSelector(".dxrd-image-save");
            WaitUntilDisplayed(saveButton, WAIT_SECONDS);
            Click(saveButton);
        }

    }
}
