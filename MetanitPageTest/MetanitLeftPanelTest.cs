using NUnit.Framework;
using OpenQA.Selenium ;
using OpenQA.Selenium.Chrome;
using System;

namespace MetanitPageTest
{
    public class MetanitLeftPanelTest
    {
        private IWebDriver browser;
        private MetanitPageObject metanitPageObject;

        [SetUp]
        public void Setup()
        {
            browser = new ChromeDriver();
            const string METANIT_PAGE_URL = "https://metanit.com/sharp/tutorial/";
            browser.Navigate().GoToUrl(METANIT_PAGE_URL);            
            browser.Manage().Window.Maximize();
            metanitPageObject = new MetanitPageObject(browser);
        }

        [Test]
        [TestCase("https://metanit.com/sharp/tutorial/5.5.php")]
        public void VerifyUrl(string url)
        {
            // Act
            metanitPageObject.SelectChapter();
            bool isRightUrl = metanitPageObject.IsRightUrl(url);

            // Assert
            Assert.True(isRightUrl, "Chapter isn't pressed, url is wrong");
        }    

        [TearDown]
        public void TearDown()
        {
            browser.Quit();
        }
    }
}