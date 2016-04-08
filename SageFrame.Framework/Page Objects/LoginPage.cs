/*
 -----------------------------------------------------------------------------------------------------------------------------------------
 Author: Raj Kumar Thapa
 -----------------------------------------------------------------------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using SageFrame.Framework.Components;
namespace SageFrame.Framework.Page_Objects
{
    #region
    public class LoginData
    {
        public string Username { get; set; }        
        public string Password { get; set; }
        public bool ForgotPassword { get; set; }
        public string Email { get; set; }
        public LoginData(string username, string password, bool forgotpassword, string email )
        {
            Username = username;
            Password = password;
            ForgotPassword = forgotpassword;
            Email = email;
        }
    }
    public class ChangePassword
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public ChangePassword(string oldpassword, string newpassword, string confirmpassword)
        {
            OldPassword = oldpassword;
            NewPassword = newpassword;
            ConfirmPassword = confirmpassword;
        }
    }
    #endregion
    public class LoginPage: Page
    {
        public static string LoginUrl = "sf/sfLogin.aspx";
        public LoginPage(IWebDriver Driver) : base(Driver) { }
        public Login LoginOperation(LoginData Logindata)
        {
            try
            {
                Login Login = new Login(Driver);
                Page NewPage = Login.LoginOperation(Logindata);
                return new Login(Driver);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
