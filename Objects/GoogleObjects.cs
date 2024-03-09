using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

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
