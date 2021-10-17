using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace MetanitPageTest
{
    class MetanitPageObject
    {
        private IWebDriver webDriver;

        public MetanitPageObject(IWebDriver driver)
        {
            webDriver = driver;
        }

        // Placing XPathes into constants
        private const string CHAPTER_XPATH = "//span[@class='folder'  and text()='Глава 21. Работа с потоками и файловой системой']";
        private const string INNER_CHAPTER_XPATH = "//ul//a[text()='Работа с файлами. Классы File и FileInfo']";

        // UI elements initialising
        private IWebElement Chapter => webDriver.FindElement(By.XPath(CHAPTER_XPATH));
        private IWebElement InnerChapter => webDriver.FindElement(By.XPath(INNER_CHAPTER_XPATH));

        // Method for chapter's select
        public void SelectChapter()
        {
            Chapter.Click();
        }

        public void SelectInnerChapter()
        {
            InnerChapter.Click();
        }

        public virtual string GetUrl()
        {
            try
            {
                string currentUrl = webDriver.Url;
                return currentUrl;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException)
            {
                return "";
            }
        }

        public virtual bool IsRightUrl(string needUrl)
        {
            string gottenUrl = GetUrl();
            return gottenUrl == needUrl;
        }

        public void WaitUntilTutorialPageLoaded(int timeout = 10)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeout));
            wait.Until(drv => Chapter.Displayed);
        }

        public void WaitUntilInnerPageLoaded(int timeout = 10)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeout));
            wait.Until(drv => InnerChapter.Displayed);
        }

        public bool IsInnerChapterVisible()
        {
            try
            {
                return InnerChapter.Displayed;

            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}