using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Hiten_s_Automation_Exercise.GenericUtility.FileUtility;
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
        public ExcelUtility eu = new ExcelUtility();
        public static ExtentReports reports;
        public ExtentTest test;
        public static ExtentSparkReporter spark;


        [OneTimeSetUp]
        public void createReport()
        {
            spark = new ExtentSparkReporter("E:\\VisualStudio\\TestProject2\\TestProject2\\Reports\\report.html");
            spark.Config.DocumentTitle = "report";
            
            spark.Config.ReportName = TestContext.CurrentContext.Test.Name;
            reports = new ExtentReports();
            reports.AttachReporter(spark);
            reports.AddSystemInfo("OS", "Win11");
            reports.AddSystemInfo("Browser", "Chrome");
        }
        [SetUp]
        public void LaunchBrowserEnterUrl()
        {
            driver = new ChromeDriver();
            wu.ImplicitWait(driver);
            wu.MaximizeBrowser(driver);
            driver.Url = "https://automationexercise.com/";

            test = reports.CreateTest(TestContext.CurrentContext.Test.Name);

        }
        [TearDown]
        public void CloseBrowser()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                test.Log(Status.Fail, TestContext.CurrentContext.Test.Name + " Failed");
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                string value = ts.GetScreenshot().AsBase64EncodedString;
                test.AddScreenCaptureFromBase64String(value, TestContext.CurrentContext.Test.Name);

            }
            else { test.Log(Status.Pass, TestContext.CurrentContext.Test.Name + " Passed"); }
            driver.Dispose();
        }
        [OneTimeTearDown]
        public void closeReport()
        {
            reports.Flush();
        }
    }
}
