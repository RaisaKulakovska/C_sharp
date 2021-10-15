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
        private const string CHAPTER_XPATH = "//span[@class='folder aMItem' and text()='Глава 21. Работа с потоками и файловой системой']";
        
        // UI elements initialising
        private IWebElement Chapter => webDriver.FindElement(By.XPath(CHAPTER_XPATH));

        // Method for chapter's select
        public void SelectChapter()
        {
            Chapter.Click();
        }

        public virtual string GetUrl()
        {
            string currentUrl = webDriver.Url;
            return currentUrl;
        }

        public virtual bool IsRightUrl(string needUrl)
        {
            string gottenUrl = GetUrl();
            return gottenUrl == needUrl;
        }
    }
}