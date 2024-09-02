using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Generic_Utility.PageRepo
{
    internal class Account_Created
    {
        [FindsBy(How =How.XPath,Using = "//b[text()='Account Created!']")]
        private IWebElement accountCreatedtext;

        [FindsBy(How =How.XPath,Using = "//a[text()='Continue']")]
        private IWebElement continueBTN;

        [FindsBy(How =How.XPath,Using = "//b[text()='Account Deleted!']")]
        private IWebElement accountdeletedtext;

        public Account_Created(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public IWebElement getAccountCreatedtext() { return accountCreatedtext; }
        public IWebElement getContinueBTN() { return continueBTN; }
        public IWebElement getAccountdeletedtext() { return accountdeletedtext; }
    }
}
