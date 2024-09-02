using Hiten_s_Automation_Exercise.GenericUtility.WebDriverUtility;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace TestProject2.Generic_Utility.BaseUtility
{
    internal class BaseClass
    {
        public IWebDriver driver;
        public WebDriverUtil wu = new WebDriverUtil();
        public ExtentReports reports;
        public ExtentTest test;
        public ExtentSparkReporter spark;

        [SetUp]
        public void LaunchBrowserEnterUrl()
        {
            driver = new ChromeDriver();
            spark =new ExtentSparkReporter("E:\\VisualStudio\\TestProject2\\TestProject2\\Reports\\report.html");
            spark.Config.DocumentTitle = "TestCase";
            spark.Config.ReportName = "TestCase1";
            reports=new ExtentReports();
            reports.AttachReporter(spark);
            reports.AddSystemInfo("OS", "Win11");
            reports.AddSystemInfo("Browser", "Chrome");
            test = reports.CreateTest("TestCase1");


            //wu.LaunchBrowser(driver, "chrome");
            wu.ImplicitWait(driver);
            wu.MaximizeBrowser(driver);
            driver.Url = "https://automationexercise.com/";

        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Dispose();
            reports.Flush();
        }
    }
}
