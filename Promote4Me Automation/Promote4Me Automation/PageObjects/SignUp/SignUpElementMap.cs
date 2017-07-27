using OpenQA.Selenium;

namespace Promote4Me_Automation.PageObjects.SignUp
{
    public class IntroElementMap
    {
        public By freeTrialButton => By.ClassName("tfs-button-1");
        public By homeLogo => By.ClassName("fusion-logo-link");
        public By homeMenu => By.ClassName("menu-item-7");
        public By featureMenu => By.ClassName("menu-item-8");
        public By signUpMenu => By.ClassName("menu-item-10");
        public By contactMenu => By.ClassName("menu-item-13");
        public By companyNameField => By.Id("org-name");
        public By emailAddressField => By.Id("email-address");
        public By passwordField => By.Id("user-pass");
        public By cityField => By.Id("org-city");
        public By stateField => By.Id("org-state");
        public By signUpButton => By.Id("");
        public By contactName => By.ClassName("your-name");
        public By contactEmail => By.ClassName("your-email");
        public By contactMessage => By.ClassName("message");
        public By contactButton => By.Id("");
        public By socialIconDribble => By.ClassName("fusion-icon-dribbble");
        public By socialIconFacebook => By.ClassName("fusion-icon-facebook");
        public By socialIconTwitter => By.ClassName("fusion-icon-twitter");
        public By socialIconGooglePlus => By.ClassName("fusion-icon-googleplus");
    }
}
