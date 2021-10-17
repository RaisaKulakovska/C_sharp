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
            metanitPageObject = new MetanitPageObject(browser);
            metanitPageObject.WaitUntilTutorialPageLoaded();
            browser.Manage().Window.Maximize();
            
        }

        [Test]
        [TestCase("https://metanit.com/sharp/tutorial/5.5.php")]
        public void VerifyUrl(string expectedUrl)
        {
            // Act
            metanitPageObject.SelectChapter();
            metanitPageObject.SelectInnerChapter();
            metanitPageObject.WaitUntilInnerPageLoaded();
            var actualUrl = metanitPageObject.GetUrl();
            //bool isRightUrl = metanitPageObject.IsRightUrl(url);

            // Assert
            Assert.AreEqual(expectedUrl, actualUrl);
        }    

        /*[TearDown]
        public void TearDown()
        {
            browser.Quit();
        }*/
    }
}