using GoogleSearch.Pages;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleSearch.tests
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            GoogleSearchPage search = new GoogleSearchPage();

            driver.Navigate().GoToUrl("https://www.google.com/");
            string PageTitle = driver.Title;
            Assert.That(TestContext.Parameters["SearchPageTitle"], Is.EqualTo(PageTitle));
            search.googleSearch(driver, TestContext.Parameters["SearchWord"]);
            string ResultPageTitle = driver.Title;
            Assert.That(TestContext.Parameters["ResultPageTitle"], Is.EqualTo(ResultPageTitle));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}