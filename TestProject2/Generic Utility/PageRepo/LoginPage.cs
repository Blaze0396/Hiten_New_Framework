using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiten_s_Automation_Exercise.PageRepo
{
    internal class LoginPage
    {
        [FindsBy(How =How.XPath,Using = "//form[@action='/signup']//input[@name='email']")]
        private IWebElement SignUpemailtxt;

        [FindsBy(How =How.XPath,Using = "//form[@action='/login']//input[@name='email']")]
        private IWebElement LoginEmailtxt;

        [FindsBy(How =How.Name, Using = "password")]
        private IWebElement passwordtxt;

        [FindsBy(How =How.XPath,Using = "//button[text()='Login']")]
        private IWebElement Loginbtn;

        [FindsBy(How =How.Name,Using = "name")]
        private IWebElement nametxt;

        [FindsBy(How =How.XPath,Using = "//h2[text()='Login to your account']")]
        private IWebElement Logintext;

        [FindsBy(How =How.XPath,Using = "//h2[text()='New User Signup!']")]
        private IWebElement Signuptext;

        [FindsBy(How = How.XPath,Using = "//button[text()='Signup']")]
        private IWebElement SignUpBtn;

        

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public IWebElement getSignUpEmailtxt() { return SignUpemailtxt;}
        public IWebElement getLoginEmailtxt() { return LoginEmailtxt;}
        public IWebElement getPasswordtxt() { return passwordtxt; }
        public IWebElement getLoginbtn() { return Loginbtn; }
        public IWebElement getNametxt() { return nametxt; }
        public IWebElement getLogintext() { return Logintext; }
        public IWebElement getSignuptext() { return Signuptext; }

        public IWebElement getSignupbtn() { return SignUpBtn; }
        
        




    }
}
