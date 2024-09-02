using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Hiten_s_Automation_Exercise.GenericUtility.WebDriverUtility;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


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
            test = reports.CreateTest(TestContext.CurrentContext.Test.Name);


            //wu.LaunchBrowser(driver, "chrome");
            wu.ImplicitWait(driver);
            wu.MaximizeBrowser(driver);
            driver.Url = "https://automationexercise.com/";

        }
        [TearDown]
        public void CloseBrowser()
        {
            if(TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                test.Log(Status.Fail,TestContext.CurrentContext.Test.Name+ " Failed");
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                string value = ts.GetScreenshot().AsBase64EncodedString;
                test.AddScreenCaptureFromBase64String(value,TestContext.CurrentContext.Test.Name);
                
            }else { test.Log(Status.Pass, TestContext.CurrentContext.Test.Name + " Passed"); }
            driver.Dispose();
            reports.Flush();
        }
    }
}
