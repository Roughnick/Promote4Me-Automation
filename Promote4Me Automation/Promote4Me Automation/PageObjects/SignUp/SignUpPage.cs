using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Promote4Me_Automation.PageObjects.SignUp
{
    public class SignUpPage : PageObject
    {
        public IntroElementMap Map => new IntroElementMap();

        public SignUpPage(IWebDriver driver) : base(driver) { }
    }
}
