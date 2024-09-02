using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Generic_Utility.PageRepo
{
    internal class HomePage
    {
        [FindsBy(How =How.XPath,Using = "//a[text()=' Logged in as ']")]
        private IWebElement logedintext;

        [FindsBy(How =How.XPath,Using = "//a[text()=' Delete Account']")]
        private IWebElement deleteAccountLink;

        [FindsBy(How =How.XPath,Using = "//a[text()=' Logged in as ']")]
        private IWebElement loggedInAsText;

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }

        public IWebElement getLoggedintxt() { return logedintext;}
        public IWebElement getDeleteAccounttext() { return deleteAccountLink; }
        public IWebElement getLoggedInAsText() { return loggedInAsText;}
    }
}
