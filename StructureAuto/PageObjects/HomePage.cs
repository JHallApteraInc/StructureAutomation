using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace StructureAuto.PageObjects
{
    internal class HomePage : BasePage
    {
        public HomePage(IWebDriver Driver) : base(Driver)
        {

        }
        internal void VisitHomepage()
        {
            Visit("/");
        }
        internal void EnterLoginCredentials()
        {
            By usernameField = By.Name("email");
            By passwordField = By.Name("password");            
            string username = "xxUserNamexx";
            string password = "xxPasswordxx";
            WaitUntilDisplayed(usernameField, WAIT_SECONDS);
            Type(username, Find(usernameField));
            Type(password, Find(passwordField));            
        }
        internal void ClickLogin()
        {
            By signInButton = By.CssSelector(".submit");
            Click(signInButton);
        }
        internal void VerifyLogin()
        {
            By profileImg = By.CssSelector(".media-object");
            WaitUntilDisplayed(profileImg, WAIT_SECONDS);
            var element = Find(profileImg);
            Assert.IsTrue(element.Displayed);
        }
    }
}
