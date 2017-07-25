using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Promote4Me_Automation.PageObjects.IntroPage
{
    public class IntroPage : PageObject
    {
        public IntroElementMap Map => new IntroElementMap();

        public IntroPage(IWebDriver driver, string baseUrl) : base(driver, baseUrl) { }
    }
}
