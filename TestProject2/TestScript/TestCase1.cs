using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using DocumentFormat.OpenXml.Bibliography;
using Hiten_s_Automation_Exercise.GenericUtility.FileUtility;
using Hiten_s_Automation_Exercise.GenericUtility.WebDriverUtility;
using Hiten_s_Automation_Exercise.PageRepo;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject2.Generic_Utility.BaseUtility;
using TestProject2.Generic_Utility.PageRepo;


namespace Hiten_s_Automation_Exercise.TestScript
{
    internal class TestCase1:BaseClass
    {
        [Test]
        public void TC1()
        {
            //fetch data from Excel
            ExcelUtility eu = new ExcelUtility();
            string name = eu.GetDataFromExcel("Excer", 2, 1);
            string email = eu.GetDataFromExcel("Excer", 2, 2);
            string password = eu.GetDataFromExcel("Excer", 2, 3);
            string f_name = eu.GetDataFromExcel("Excer", 2, 4);
            string l_name = eu.GetDataFromExcel("Excer", 2, 5);
            string company = eu.GetDataFromExcel("Excer", 2, 5);
            string address = eu.GetDataFromExcel("Excer", 2, 6);
            string country = eu.GetDataFromExcel("Excer", 2, 7);
            string state = eu.GetDataFromExcel("Excer", 2, 8);
            string city = eu.GetDataFromExcel("Excer", 2, 9);
            string zipcode = eu.GetDataFromExcel("Excer", 2, 10);
            string mobile_No = eu.GetDataFromExcel("Excer", 2, 11);

            //3. Verify that home page is visible successfully
            string title = driver.Title;
            StringAssert.IsMatch("Automation Exercise", title);



            //4. Click on 'Signup / Login' button
            WelcomePage wp = new WelcomePage(driver);
            wp.getLoginSignuplink().Click();

            //5. Verify 'New User Signup!' is visible
            LoginPage lp = new LoginPage(driver);

            //6. Enter name and email address
            lp.getNametxt().SendKeys(name);
            lp.getSignUpEmailtxt().SendKeys(email);

            //7. Click 'Signup' button
            lp.getSignupbtn().Click();

            //8. Verify that 'ENTER ACCOUNT INFORMATION' is visible
            SignUpPage sup = new SignUpPage(driver);
            Assert.IsTrue(sup.getEnterAccInfoText().Displayed);

            //9. Fill details: Title, Name, Email, Password, Date of birth
            sup.getMaleTitle().Click();
            sup.getPasswordtxt().SendKeys(password);
            wu.SelectSingleElement(sup.getDOB_Days(), "30");
            wu.SelectSingleElement(sup.getDOB_Months(), "March");
            wu.SelectSingleElement(sup.getDOB_Years(), "1996");

            //10. Select checkbox 'Sign up for our newsletter!'
            wu.ScrollUntillElementIsVisible(driver, sup.getNewsLetterCheckBox());
            sup.getNewsLetterCheckBox().Click();

            //11. Select checkbox 'Receive special offers from our partners!'
            sup.getreceiveSpecialOfferCheckbox().Click();

            //12. Fill details: First name, Last name, Company, Address, Address2, Country, State, City, Zipcode, Mobile Number
            sup.getfirstNametxt().SendKeys(f_name);
            sup.getlastNametxt().SendKeys(l_name);
            sup.getcompanytxt().SendKeys(company);
            sup.getaddresstxt().SendKeys(address);
            wu.SelectSingleElement(sup.getCountrySelect(), country);
            sup.getstatetxt().SendKeys(state);
            sup.getcitytxt().SendKeys(city);
            sup.getzipCodetxt().SendKeys(zipcode);
            sup.getmobileNotxt().SendKeys(mobile_No);

            //13. Click 'Create Account button'
            wu.ScrollUntillElementIsVisible(driver, sup.getcreateAcBTN());
            sup.getcreateAcBTN().Click();

            //14. Verify that 'ACCOUNT CREATED!' is visible
            Account_Created ac = new Account_Created(driver);
            Assert.IsTrue(ac.getAccountCreatedtext().Displayed);

            //15. Click 'Continue' button
            ac.getContinueBTN().Click();

            //16. Verify that 'Logged in as username' is visible
            HomePage hp = new HomePage(driver);
            Assert.IsTrue(hp.getLoggedintxt().Displayed);

            //17. Click 'Delete Account' button
            hp.getDeleteAccounttext().Click();

            //18. Verify that 'ACCOUNT DELETED!' is visible and click 'Continue' button
            Assert.IsTrue(ac.getAccountdeletedtext().Displayed);
        }
    }
}
