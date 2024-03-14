using OpenQA.Selenium;

namespace GoogleSearch.Objects
{
    internal class GoogleObjects
    {
        private IWebElement? element;

        public WebElement SearchBox(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//textarea[@id=\"APjFqb\"]"));
            return (WebElement)element;
        }

    }
}
