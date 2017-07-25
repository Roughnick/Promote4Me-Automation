using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Promote4Me_Automation.PageObjects
{
    public class PageObject
    {
        protected IWebDriver _driver;
        protected string _baseUrl;

        protected PageObject(IWebDriver driver, string baseUrl)
        {
            _driver = driver;
            _baseUrl = baseUrl;
        }

        public void Navigate()
        {
            _driver.Url = _baseUrl;
        }
    }
}
