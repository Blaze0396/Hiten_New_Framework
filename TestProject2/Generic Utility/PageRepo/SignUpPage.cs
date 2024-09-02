using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiten_s_Automation_Exercise.PageRepo
{
    internal class SignUpPage
    {
        [FindsBy(How = How.XPath, Using = "//b[text()='Enter Account Information']")]
        private IWebElement EnterAccInfoText;

        [FindsBy(How =How.Id,Using = "id_gender1")]
        private IWebElement MaleTitle;

        [FindsBy(How =How.Id,Using = "name")]
        private IWebElement Nametxt;

        [FindsBy(How =How.Id,Using = "email")]
        private IWebElement Emailtxt;

        [FindsBy(How =How.Id,Using = "password")]
        private IWebElement Passwordtxt;

        [FindsBy(How =How.Id,Using = "days")]
        private IWebElement DOB_Days;

        [FindsBy(How =How.Id,Using = "months")]
        private IWebElement DOB_Months;

        [FindsBy(How =How.Id,Using = "years")]
        private IWebElement DOB_Years;

        [FindsBy(How =How.Id,Using = "newsletter")]
        private IWebElement newsLetterCheckBox;

        [FindsBy(How =How.Id,Using = "optin")]
        private IWebElement receiveSpecialOfferCheckbox;

        [FindsBy(How =How.Id,Using = "first_name")]
        private IWebElement firstNametxt;

        [FindsBy(How =How.Id,Using = "last_name")]
        private IWebElement lastNametxt;

        [FindsBy(How =How.Id,Using = "company")]
        private IWebElement companytxt;

        [FindsBy(How =How.Id,Using = "address1")]
        private IWebElement addresstxt;

        [FindsBy(How =How.Id,Using = "country")]
        private IWebElement countryselect;

        [FindsBy(How =How.Id,Using = "state")]
        private IWebElement statetxt;

        [FindsBy(How =How.Id,Using = "city")]
        private IWebElement citytxt;

        [FindsBy(How =How.Id,Using = "zipcode")]
        private IWebElement zipCodetxt;

        [FindsBy(How =How.Id,Using = "mobile_number")]
        private IWebElement mobileNotxt;

        [FindsBy(How = How.XPath, Using = "//button[text()='Create Account']")]
        private IWebElement createAcBTN;



        public SignUpPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public IWebElement getEnterAccInfoText() {return EnterAccInfoText;}
        public IWebElement getMaleTitle() { return MaleTitle; }  
        public IWebElement getNametxt() { return Nametxt;}
        public IWebElement getEmailtxt() { return Emailtxt;}
        public IWebElement getPasswordtxt() { return Passwordtxt;}
        public IWebElement getDOB_Days() { return DOB_Days;}
        public IWebElement getDOB_Months() { return DOB_Months;}
        public IWebElement getDOB_Years() { return DOB_Years;}
        public IWebElement getNewsLetterCheckBox() { return newsLetterCheckBox;}
        public IWebElement getreceiveSpecialOfferCheckbox() {return receiveSpecialOfferCheckbox;}
        public IWebElement getfirstNametxt() { return firstNametxt;}
        public IWebElement getlastNametxt() {return lastNametxt;}
        public IWebElement getcompanytxt() { return companytxt; }
        public IWebElement getaddresstxt() { return addresstxt; }
        public IWebElement getstatetxt() { return statetxt; }
        public IWebElement getcitytxt() { return citytxt; }
        public IWebElement getzipCodetxt() { return zipCodetxt; }
        public IWebElement getmobileNotxt() { return mobileNotxt; }
        public IWebElement getcreateAcBTN() { return createAcBTN; }
        public IWebElement getCountrySelect() { return countryselect; }







    }
}
