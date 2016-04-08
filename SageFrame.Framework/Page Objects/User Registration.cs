/*
 -----------------------------------------------------------------------------------------------------------------------------------------
 Author: Raj Kumar Thapa
 -----------------------------------------------------------------------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
namespace SageFrame.Framework.Page_Objects
{
    #region
    public class RegisterUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool Register { get; set; }
        public RegisterUser(string firstname, string lastname, string username, string email, string password, string confirmpassword, bool register)
        {
            FirstName = firstname;
            LastName = lastname;
            UserName = username;
            Email = email;
            Password = password;
            ConfirmPassword = confirmpassword; 
            Register = register;
        }
    }
    #endregion
    public class User_Registration: Page
    {
        public static string UserRegistrationUrl = "sf/sfUser-Registration.aspx";
        protected readonly static string[] LocatorValue = { "ctl14_FirstName", "ctl14_LastName", "ctl14_UserName", "ctl14_Email", "ctl14_Password", "ctl14_ConfirmPassword", "ctl14_FinishButton", "hypPreview" };
        private SetElement[] UserRegistrationPageElements = {
                                                        new SetElement(Locator[0], LocatorValue[0]),
                                                        new SetElement(Locator[0], LocatorValue[1]),
                                                        new SetElement(Locator[0], LocatorValue[2]),
                                                        new SetElement(Locator[0], LocatorValue[3]),
                                                        new SetElement(Locator[0], LocatorValue[4]),
                                                        new SetElement(Locator[0], LocatorValue[5]),
                                                        new SetElement(Locator[0], LocatorValue[6]),
                                                        new SetElement(Locator[0], LocatorValue[7]),
                                                  };
        public User_Registration(IWebDriver Driver) : base(Driver) { }
        public Page UserRegistration(RegisterUser RegisterUser)
        {
            try
            {
                By FirstNameTextBoxLocator = this.SetElement(UserRegistrationPageElements[0]);
                this.SetElementValue(FirstNameTextBoxLocator, RegisterUser.FirstName);
                By LastNameTextBoxLocator = this.SetElement(UserRegistrationPageElements[1]);
                this.SetElementValue(LastNameTextBoxLocator, RegisterUser.LastName);
                By UserNameTextBoxLocator = this.SetElement(UserRegistrationPageElements[2]);
                this.SetElementValue(UserNameTextBoxLocator, RegisterUser.UserName);
                By EmailTextBoxLocator = this.SetElement(UserRegistrationPageElements[3]);
                this.SetElementValue(EmailTextBoxLocator, RegisterUser.Email);
                By PasswordTextBoxLocator = this.SetElement(UserRegistrationPageElements[4]);
                this.SetElementValue(PasswordTextBoxLocator, RegisterUser.Password);
                By ConfirmPasswordTextBoxLocator = this.SetElement(UserRegistrationPageElements[5]);
                this.SetElementValue(ConfirmPasswordTextBoxLocator, RegisterUser.ConfirmPassword);
                switch (RegisterUser.Register)
                {
                    case true:
                        By FinishTextBoxLocator = this.SetElement(UserRegistrationPageElements[6]);
                        this.SetElementValue(FinishTextBoxLocator, true);
                        break;
                    default:
                        By BackToHomeLocator = this.SetElement(UserRegistrationPageElements[7]);
                        this.SetElementValue(BackToHomeLocator, true);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
    }
}
