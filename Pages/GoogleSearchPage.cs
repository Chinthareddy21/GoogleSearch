using GoogleSearch.Objects;
using OpenQA.Selenium;

namespace GoogleSearch.Pages
{
    internal class GoogleSearchPage
    {

        public void googleSearch(IWebDriver driver, String? search)
        {
            GoogleObjects objects = new GoogleObjects();

            objects.SearchBox(driver).SendKeys(search);
            objects.SearchBox(driver).SendKeys(Keys.Return);
        }
    }
}
