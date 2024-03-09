using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleSearch.Objects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

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
