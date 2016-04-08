/*
 -----------------------------------------------------------------------------------------------------------------------------------------
 Author: Raj Kumar Thapa
 -----------------------------------------------------------------------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using SageFrame.Framework.Page_Objects;
namespace SageFrame.Framework.Components
{
    public class Login : Page
    {
        protected readonly static string[] LocatorValue = { "ctl14_UserName", "ctl14_Password", "ctl14_LoginButton", "ctl14_hypForgotPassword", "hypPreview", "imgLogo", "ctl14_UserNameRequired", "ctl14_PasswordRequired", "Username and password combination didn't match!", "User does not exist!", "sfError" };
        private SetElement[] LoginElements = {
                                             new SetElement(Locator[0], LocatorValue[0]),
                                             new SetElement(Locator[0], LocatorValue[1]),
                                             new SetElement(Locator[0], LocatorValue[2]),
                                             new SetElement(Locator[0], LocatorValue[3]),
                                             new SetElement(Locator[0], LocatorValue[4]),
                                             new SetElement(Locator[0], LocatorValue[5]),
                                             new SetElement(Locator[0], LocatorValue[6]),
                                             new SetElement(Locator[0], LocatorValue[7]),
                                             new SetElement(Locator[4], LocatorValue[8]),
                                             new SetElement(Locator[4], LocatorValue[9]),
                                             new SetElement(Locator[1], LocatorValue[10]),
                                       };
        public Login(IWebDriver Driver) : base(Driver) { }
        public Page LoginOperation(LoginData Logindata)
        {
            LoginData logindata = new LoginData("superuser", "superuser", false, "illusionineyes@gmail.com");
            try
            {
                By UserNameTextBoxLocator = this.SetElement(LoginElements[0]);
                this.SetElementValue(UserNameTextBoxLocator, Logindata.Username);
                By PasswordTextBoxLocator = this.SetElement(LoginElements[1]);
                this.SetElementValue(PasswordTextBoxLocator, Logindata.Password);
                By LoginButtonLocator = this.SetElement(LoginElements[2]);
                this.SetElementValue(LoginButtonLocator, true);
                if(Is_At("Login"))
                {
                    By UsernameRequiredLocator = this.SetElement(LoginElements[6]);
                    //bool UsernameRequired = IsTextPresent(UsernameRequiredLocator, "*");
                    if (this.IsElementEnabled(UsernameRequiredLocator))
                    {
                        this.SetElementValue(UserNameTextBoxLocator, logindata.Username);                        
                    }
                    By PasswordRequiredLocator = this.SetElement(LoginElements[7]);
                    //bool PasswordRequired = IsTextPresent(PasswordRequiredLocator, "*");
                    if (this.IsElementEnabled(PasswordRequiredLocator))
                    {
                        this.SetElementValue(PasswordTextBoxLocator, logindata.Password);
                    }
                    By ErrorMessageLocator = this.SetElement(LoginElements[10]);
                    if (!this.IsElementAbsent(ErrorMessageLocator))
                    {
                        IWebElement ErrorMessage = Driver.FindElement(ErrorMessageLocator); 
                        if (ErrorMessage.Text == "Username and password combination didn't match!")
                        {
                            this.SetElementValue(PasswordTextBoxLocator, logindata.Password);
                        }
                        if (ErrorMessage.Text == "User does not exist!")
                        {
                            this.SetElementValue(UserNameTextBoxLocator, logindata.Username);
                            this.SetElementValue(PasswordTextBoxLocator, logindata.Password);                          
                        }
                    }
                    this.SetElementValue(LoginButtonLocator, true);
                }
                By ForgotPasswordLocator = this.SetElement(LoginElements[3]);
                By BackToHomeLocator = this.SetElement(LoginElements[4]);
                By ToSageFrameLocator = this.SetElement(LoginElements[5]);               
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
    }
}
