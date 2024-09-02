using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiten_s_Automation_Exercise.PageRepo
{
    internal class WelcomePage
    {
        [FindsBy(How=How.XPath, Using = "//a[text()=' Home']")]
        private IWebElement HomeLink;

        [FindsBy(How =How.XPath,Using = "//a[text()=' Products']")]
        private IWebElement ProductLink;

        [FindsBy(How=How.XPath,Using = "//a[text()=' Cart']")]
        private IWebElement CartLink;

        [FindsBy(How = How.XPath,Using ="//a[text()=' Signup / Login']")]
        private IWebElement LoginSignuplink;

        [FindsBy(How = How.XPath, Using = "//a[text()=' Test Cases']")]
        private IWebElement testCaseLink;

        [FindsBy(How = How.XPath,Using = "//a[text()=' API Testing']")]
        private IWebElement ApiTestLink;

        [FindsBy(How = How.XPath,Using = "//a[text()=' Video Tutorials']")]
        private IWebElement VideoTutorialLink;

        [FindsBy(How = How.XPath,Using = "//a[text()=' Contact us']")]
        private IWebElement ContactUsLink;

        public WelcomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }

        public IWebElement getHomeLink() {  return HomeLink; }
        public IWebElement getProductPage() { return ProductLink; }
        public IWebElement getCartLink() { return CartLink; }
        public IWebElement getLoginSignuplink() { return LoginSignuplink; }
        public IWebElement getTestCaseLink() { return testCaseLink; }
        public IWebElement getApiTestLink() { return ApiTestLink; }
        public IWebElement getVideoTutorialLink() { return VideoTutorialLink; }
        public IWebElement getContactUsLink() { return ContactUsLink; }



    }
}
