using GoogleSearch.Pages;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework.Internal;

namespace GoogleSearch.tests
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            GoogleSearchPage search = new GoogleSearchPage();

            driver.Navigate().GoToUrl("https://www.google.com/");

            search.googleSearch(driver, TestContext.Parameters["SearchWord"]);
            Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}