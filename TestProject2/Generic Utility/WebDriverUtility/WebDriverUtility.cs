


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace Hiten_s_Automation_Exercise.GenericUtility.WebDriverUtility
{
    public class WebDriverUtil
    {
        //public void LaunchBrowser(IWebDriver driver, string browserName)
        //{
        //    if (string.Equals(browserName,"chrome",StringComparison.OrdinalIgnoreCase))
        //    {
        //        driver = new ChromeDriver();
        //    }else if (string.Equals(browserName, "firefox", StringComparison.OrdinalIgnoreCase))
        //    {
        //        driver = new FirefoxDriver();
        //    }else if (string.Equals(browserName, "egde", StringComparison.OrdinalIgnoreCase))
        //    {
        //        driver = new EdgeDriver();
        //    }
        //}
        public void ImplicitWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
        }

        public void ExplicitWait(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void SwitchToChildTab(IWebDriver driver,string PartialURL)
        {
            ReadOnlyCollection<string> setwin = driver.WindowHandles;
            foreach(string s in setwin)
            {
                driver.SwitchTo().Window(s);
                if(PartialURL.Contains(driver.Url))
                {
                    break;
                }
            }
        }

        public void SwitchToParentTab(IWebDriver driver, string PartialURL)
        {
            ReadOnlyCollection<string> setwin = driver.WindowHandles;
            foreach (string s in setwin)
            {
                driver.SwitchTo().Window(s);
                if (PartialURL.Contains(driver.Url))
                {
                    break;
                }
            }
        }

        public void SwitchToFrame(IWebDriver driver, int FrameIndex)
        {
            driver.SwitchTo().Frame(FrameIndex);
        }

        public void SwitchToFrame(IWebDriver driver, string Name_ID)
        {
            driver.SwitchTo().Frame(Name_ID);
        }

        public void SwitchToFrame(IWebDriver driver, IWebElement element)
        {
            driver.SwitchTo().Frame(element);
        }

        public void SwitchToParentFrame(IWebDriver driver)
        {
            driver.SwitchTo().ParentFrame();
        }

        public void SwitchToAlertAndAccept(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }
        public void SwitchToAlertAndDismiss(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();
        }

        public void SelectSingleElement(IWebElement element,string visibleText)
        {
            SelectElement sel=new SelectElement(element);
            sel.SelectByText(visibleText);
        }

        public void SelectMultipleElement(IWebElement element,List<string> visibleText)
        {
            SelectElement sel = new SelectElement(element);
            foreach(string text in visibleText)
            sel.SelectByText(text);
        }

        public void SelectSingleElement(IWebElement element, int index)
        {
            SelectElement sel = new SelectElement(element);
            sel.SelectByIndex(index);
        }
        public void SelectMultipleElement(IWebElement element, List<int> index)
        {
            SelectElement sel = new SelectElement(element);
            foreach (int ind in index)
                sel.SelectByIndex(ind);
        }

        public void MoveToElement(IWebDriver driver,IWebElement element)
        {
            Actions act=new Actions(driver);
            act.MoveToElement(element).Build().Perform();
        }

        public void DragAndDrop(IWebDriver driver,IWebElement src, IWebElement dest)
        {
            Actions act=new Actions(driver);
            act.DragAndDrop(src, dest).Build().Perform();
        }

        public void RightClick(IWebDriver driver,IWebElement element)
        {
            Actions act=new Actions(driver);
            act.ContextClick(element).Build().Perform();
        }

        public void TypeInElement(IWebDriver driver,IWebElement element, string data)
        {
            Actions act=new Actions(driver);
            act.SendKeys(element, data).Build().Perform();
        }

        public void ScrollToElement(IWebDriver driver,IWebElement element)
        {
            Actions act = new Actions(driver);
            act.ScrollToElement(element).Build().Perform();
        }

        public void ScrollUntillElementIsVisible(IWebDriver driver,IWebElement element)
        {
            int y=element.Location.Y;
            IJavaScriptExecutor jse=(IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0, "+y+")");
        }

        public void DoubleClick(IWebDriver driver,IWebElement element)
        {
            Actions act=new Actions(driver);
            act.DoubleClick(element).Build().Perform();
        }

        public void MaximizeBrowser(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }

        public void MinimizeBrowser(IWebDriver driver)
        {
            driver.Manage().Window.Minimize();
        }

        public void GetPageScreenShot(IWebDriver driver)
        {
            Screenshot takeScreenshot = ((ITakesScreenshot)driver).GetScreenshot();
            String title = driver.Title;
            String fpath = "E:\\VisualStudio\\TestProject1\\TestProject1\\ScreenShot\\" + title + ".png";
            takeScreenshot.SaveAsFile(fpath);
        }

        internal void LaunchBrowserEnterURL(IWebDriver driver, string v)
        {
            throw new NotImplementedException();
        }
    }
}
