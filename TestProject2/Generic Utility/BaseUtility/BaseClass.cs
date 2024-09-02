using Hiten_s_Automation_Exercise.GenericUtility.WebDriverUtility;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Generic_Utility.BaseUtility
{
    internal class BaseClass
    {
        public IWebDriver driver;
        public WebDriverUtil wu = new WebDriverUtil();

        [SetUp]
        public void LaunchBrowserEnterUrl()
        {
            driver = new ChromeDriver();

            //wu.LaunchBrowser(driver, "chrome");
            wu.ImplicitWait(driver);
            wu.MaximizeBrowser(driver);
            driver.Url = "https://automationexercise.com/";
        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Dispose();
        }
    }
}
