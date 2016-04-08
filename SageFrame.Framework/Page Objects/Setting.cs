using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using SageFrame.Framework.Page_Objects;
using SageFrame.Framework.Components;
namespace SageFrame.Framework.Page_Objects
{
    #region
    public class DivExpansion
    {
        public IWebElement SettingDiv { get; set; }
        public int N { get; set; }
        public DivExpansion(IWebElement settingdiv, int n)
        {
            SettingDiv = settingdiv;
            N = n;
        }
    }
    public class BasicSettings
    {
        public string PortalTitle { get; set; }
        public string PortalDescription { get; set; }
        public string KeyWords { get; set; }
        public string GoogleAdSenseID { get; set; }
        public bool ShowProfileLink { get; set; }
        public bool EnableCDN { get; set; }
        public bool EnableSessionTracker { get; set; }
        public bool EnableOptimizationCSS { get; set; }
        public bool EnableOptimizationJs { get; set; }
        public bool EnableDashboardLiveFeeds { get; set; }
        public bool OpenIdEnable { get; set; }
        public string FbConsumerKey { get; set; }
        public string FbSecretKey { get; set; }
        public string LIConsumerKey { get; set; }
        public string LISecretKey { get; set; }
        public bool SaveBasicSettings { get; set; }
        public BasicSettings(string portaltitle, string portaldescription, string keywords, string googleadsenseid, bool showprofilelink, bool enablecdn, bool enablesessiontracker, bool enableoptimizationcss, bool enableoptimizationjs, bool enabledashboardlivefeeds, bool openidenable, string fbconsumerkey, string fbsecretkey, string liconsumerkey, string lisecretkey, bool savebasicsettings)
        {
            PortalTitle = portaltitle;
            PortalDescription = portaldescription;
            KeyWords = keywords;
            GoogleAdSenseID = googleadsenseid;
            ShowProfileLink = showprofilelink;
            EnableCDN = enablecdn;
            EnableSessionTracker = enablesessiontracker;
            EnableOptimizationCSS = enableoptimizationcss;
            EnableOptimizationJs = enableoptimizationjs;
            EnableDashboardLiveFeeds = enabledashboardlivefeeds;
            OpenIdEnable = openidenable;
            FbConsumerKey = fbconsumerkey;
            FbSecretKey = fbsecretkey;
            LIConsumerKey = liconsumerkey;
            LISecretKey = lisecretkey;
            SaveBasicSettings = savebasicsettings;
        }
    }
    public class AdvancedSettings
    {
        public string UserRegistration { get; set; }
        public string LoginPage { get; set; }
        public string PortalDefaultPage { get; set; }
        public string UserProfilePage { get; set; }
        public string UserRegistrationPage { get; set; }
        public string UserActivationPage { get; set; }
        public string UserForgotPasswordPage { get; set; }
        public string PageNotAccessiblePage { get; set; }
        public string PageNotFoundPage { get; set; }
        public string PasswordRecoveryPage { get; set; }
        public string MessageSetting { get; set; }
        public string MessageType { get; set; }
        public string DefaultLanguage { get; set; }
        public string LanguageType { get; set; }
        public string PortalTimeZone { get; set; }
        public string SiteAdminEmailAddress { get; set; }
        public string LogoTemplate { get; set; }
        public string CopyRight { get; set; }
        public bool SaveAdvancedSettings { get; set; }
        public AdvancedSettings(string userregistration, string loginpage, string portaldefaultpage, string userprofilepage, string userregistrationpage, string useractivationpage, string userforgotpasswordpage, string pagenotaccessiblepage, string pagenotfoundpage, string passwordrecoverypage, string messagesetting, string messagetype, string defaultlanguage, string languagetype, string portaltimezone, string siteadminemailaddress, string logotemplate, string copyright, bool saveadvancedsettings)
        {
            UserRegistration = userregistration;
            LoginPage = loginpage;
            PortalDefaultPage = portaldefaultpage;
            UserProfilePage = userprofilepage;
            UserRegistrationPage = userregistrationpage;
            UserActivationPage = useractivationpage;
            UserForgotPasswordPage = userforgotpasswordpage;
            PageNotAccessiblePage = pagenotaccessiblepage;
            PageNotFoundPage = pagenotfoundpage;
            PasswordRecoveryPage = passwordrecoverypage;
            MessageSetting = messagesetting;
            MessageType = messagetype;
            DefaultLanguage = defaultlanguage;
            LanguageType = languagetype;
            PortalTimeZone = portaltimezone;
            SiteAdminEmailAddress = siteadminemailaddress;
            LogoTemplate = logotemplate;
            CopyRight = copyright;
            SaveAdvancedSettings = saveadvancedsettings;
        }
    }
    public class SuperUserSettings
    {
        public string SiteTitle { get; set; }
        public string SiteUrl { get; set; }
        public string SiteEmail { get; set; }
        public bool CopyrightEnable { get; set; }
        public bool CustomError { get; set; }
        public string SMTPServerAndPort { get; set; }
        public bool SMTPBasic { get; set; }
        public bool EnableSSL { get; set; }
        public string SMTPUserName { get; set; }
        public string SMTPPassword { get; set; }
        public string FileExtensions { get; set; }
        public string HelpUrl { get; set; }
        public string PageExtension { get; set; }
        public string UserAgent { get; set; }
        public bool EnableScheduler { get; set; }
        public bool EnableDashboardHelp { get; set; }
        public string ServerCookieExpirationTime { get; set; }
        public bool SaveSuperUserSettings { get; set; }
        public bool TestSMTP { get; set; }
        public SuperUserSettings(string sitetitle, string siteurl, string siteemail, bool copyrightenable, bool customerror, string smtpserverandport, bool smtpbasic, bool enablessl, string smtpusername, string smtppassword, string fileextensions, string helpurl, string pageextension, string useragent, bool enablescheduler, bool enabledashboardhelp, string servercookieexpirationtime, bool savesuperusersettings, bool testsmtp)
        {
            SiteTitle = sitetitle;
            SiteUrl = siteurl;
            SiteEmail = siteemail;
            CopyrightEnable = copyrightenable;
            CustomError = customerror;
            SMTPServerAndPort = smtpserverandport;
            SMTPBasic = smtpbasic;
            EnableSSL = enablessl;
            SMTPUserName = smtpusername;
            SMTPPassword = smtppassword;
            FileExtensions = fileextensions;
            HelpUrl = helpurl;
            PageExtension = pageextension;
            UserAgent = useragent;
            EnableScheduler = enablescheduler;
            EnableDashboardHelp = enabledashboardhelp;
            ServerCookieExpirationTime = servercookieexpirationtime;
            SaveSuperUserSettings = savesuperusersettings;
            TestSMTP = testsmtp;
        }
    }
    #endregion
    public class Setting : Page
    {
        public static string SettingUrl = "Admin/Settings.aspx";
        protected readonly static string[] LocatorValue = { "__tab_ctl19_TabContainer_tabBasicSetting", "__tab_ctl19_TabContainer_tabAdvanceSetting", "__tab_ctl19_TabContainer_TabPanel1", "ctl19_TabContainer_tabBasicSetting_txtPortalTitle", "ctl19_TabContainer_tabBasicSetting_txtDescription", "ctl19_TabContainer_tabBasicSetting_txtKeyWords", "ctl19_TabContainer_tabBasicSetting_txtPortalGoogleAdSenseID", "ctl19_TabContainer_tabBasicSetting_rblPortalShowProfileLink_0", "ctl19_TabContainer_tabBasicSetting_rblPortalShowProfileLink_1", "ctl19_TabContainer_tabBasicSetting_chkEnableCDN", "ctl19_TabContainer_tabBasicSetting_chkSessionTracker", "ctl19_TabContainer_tabBasicSetting_chkOptCss", "ctl19_TabContainer_tabBasicSetting_chkOptJs", "ctl19_TabContainer_tabBasicSetting_chkLiveFeeds", "ctl19_TabContainer_tabBasicSetting_btnRefreshCache", "ctl19_TabContainer_tabBasicSetting_chkOpenID", "ctl19_TabContainer_tabBasicSetting_txtFacebookConsumerKey", "ctl19_TabContainer_tabBasicSetting_txtFaceBookSecretKey", "ctl19_TabContainer_tabBasicSetting_txtLinkedInConsumerKey", "ctl19_TabContainer_tabBasicSetting_txtLinkedInSecretKey", "ctl19_imbSave", "ctl19_imbRefresh", "ctl19_TabContainer_tabAdvanceSetting_rblUserRegistration_0", "ctl19_TabContainer_tabAdvanceSetting_rblUserRegistration_1", "ctl19_TabContainer_tabAdvanceSetting_rblUserRegistration_2", "ctl19_TabContainer_tabAdvanceSetting_rblUserRegistration_3", "ctl19_TabContainer_tabAdvanceSetting_ddlLoginPage", "ctl19_TabContainer_tabAdvanceSetting_ddlPortalDefaultPage", "ctl19_TabContainer_tabAdvanceSetting_ddlPortalUserProfilePage", "ctl19_TabContainer_tabAdvanceSetting_ddlUserRegistrationPage", "ctl19_TabContainer_tabAdvanceSetting_ddlPortalUserActivation", "ctl19_TabContainer_tabAdvanceSetting_ddlPortalForgotPassword", "ctl19_TabContainer_tabAdvanceSetting_ddlPortalPageNotAccessible", "ctl19_TabContainer_tabAdvanceSetting_ddlPortalPageNotFound", "ctl19_TabContainer_tabAdvanceSetting_ddlPortalPasswordRecovery", "ctl19_TabContainer_tabAdvanceSetting_rdbDefault", "ctl19_TabContainer_tabAdvanceSetting_rdbCustom", "sfDefaultSuccess", "sfDefaultError", "sfDefaultAlert", "ctl19_TabContainer_tabAdvanceSetting_ddlDefaultLanguage", "ctl19_TabContainer_tabAdvanceSetting_rbLanguageType_0", "ctl19_TabContainer_tabAdvanceSetting_rbLanguageType_1", "ctl19_TabContainer_tabAdvanceSetting_ddlPortalTimeZone", "ctl19_TabContainer_tabAdvanceSetting_txtSiteAdminEmailAddress", "ctl19_TabContainer_tabAdvanceSetting_txtLogoTemplate", "ctl19_TabContainer_tabAdvanceSetting_txtCopyright", "ctl19_TabContainer_TabPanel1_imbRestart", "ctl19_TabContainer_TabPanel1_txtHostTitle", "ctl19_TabContainer_TabPanel1_txtHostUrl", "ctl19_TabContainer_TabPanel1_txtHostEmail", "ctl19_TabContainer_TabPanel1_chkCopyright", "ctl19_TabContainer_TabPanel1_chkUseCustomErrorMessages", "ctl19_TabContainer_TabPanel1_txtSMTPServerAndPort", "ctl19_TabContainer_TabPanel1_lnkTestSMTP", "ctl19_TabContainer_TabPanel1_rblSMTPAuthentication_0", "ctl19_TabContainer_TabPanel1_rblSMTPAuthentication_1", "ctl19_TabContainer_TabPanel1_chkSMTPEnableSSL", "ctl19_TabContainer_TabPanel1_txtSMTPUserName", "ctl19_TabContainer_TabPanel1_txtSMTPPassword", "ctl19_TabContainer_TabPanel1_txtFileExtensions", "ctl19_TabContainer_TabPanel1_txtHelpUrl", "ctl19_TabContainer_TabPanel1_txtPageExtension", "ctl19_TabContainer_TabPanel1_txtScheduler", "ctl19_TabContainer_TabPanel1_rdBtnPC", "ctl19_TabContainer_TabPanel1_rdBtnMobile", "ctl19_TabContainer_TabPanel1_rdBtnDefault", "ctl19_TabContainer_TabPanel1_chkDashboardHelp", "ctl19_TabContainer_TabPanel1_txtServerCookieExpiration" };
        private SetElement[] SettingPageElements = {
                                                       // Settings Tab
                                                       new SetElement(Locator[0], LocatorValue[0]), // Basic Setting
                                                       new SetElement(Locator[0], LocatorValue[1]), // Advanced Setting
                                                       new SetElement(Locator[0], LocatorValue[2]), // Superuser Setting
                                                       // Basic Settings
                                                       new SetElement(Locator[0], LocatorValue[3]), // Title TextBox
                                                       new SetElement(Locator[0], LocatorValue[4]), // Description TextBox
                                                       new SetElement(Locator[0], LocatorValue[5]), // KeyWord TextBox
                                                       new SetElement(Locator[0], LocatorValue[6]), // Google Adsense TextBox
                                                       new SetElement(Locator[0], LocatorValue[7]), // ProfileLink NO Radio Button
                                                       new SetElement(Locator[0], LocatorValue[8]), // ProfileLink Yes Radio Button
                                                       new SetElement(Locator[0], LocatorValue[9]), // Enable CDN CheckBox
                                                       new SetElement(Locator[0], LocatorValue[10]), // Enable SessionTracker CheckBox
                                                       new SetElement(Locator[0], LocatorValue[11]), // Optimize CSS CheckBox
                                                       new SetElement(Locator[0], LocatorValue[12]), // Optimize JS CheckBox
                                                       new SetElement(Locator[0], LocatorValue[13]), // Enable DashBoard Live Feeds CheckBox
                                                       new SetElement(Locator[0], LocatorValue[14]), // Refresh Cache Button
                                                       new SetElement(Locator[0], LocatorValue[15]), // OpenId Login CheckBox
                                                       new SetElement(Locator[0], LocatorValue[16]), // FaceBook Consumer Key TextBox
                                                       new SetElement(Locator[0], LocatorValue[17]), // FaceBook Secret Key TextBox
                                                       new SetElement(Locator[0], LocatorValue[18]), // LinkedIn Consumer Key TextBox
                                                       new SetElement(Locator[0], LocatorValue[19]), // LinkedIn Secret Key TextBox
                                                       // Save Refresh
                                                       new SetElement(Locator[0], LocatorValue[20]), // Save Button
                                                       new SetElement(Locator[0], LocatorValue[21]), // Refresh Button
                                                       // Advanced Settings
                                                       new SetElement(Locator[0], LocatorValue[22]), // None User Registration
                                                       new SetElement(Locator[0], LocatorValue[23]), // Private User Registration
                                                       new SetElement(Locator[0], LocatorValue[24]), // Public User Registration
                                                       new SetElement(Locator[0], LocatorValue[25]), // Verified User Registration
                                                       new SetElement(Locator[0], LocatorValue[26]), // Login Page DropDown
                                                       new SetElement(Locator[0], LocatorValue[27]), // Portal Default Page DropDown
                                                       new SetElement(Locator[0], LocatorValue[28]), // User Profile Page DropDown
                                                       new SetElement(Locator[0], LocatorValue[29]), // User Registration Page DropDown
                                                       new SetElement(Locator[0], LocatorValue[30]), // User Activation Page DropDown
                                                       new SetElement(Locator[0], LocatorValue[31]), // User Forgot Password Page DropDown
                                                       new SetElement(Locator[0], LocatorValue[32]), // Page Not Accessible Page DropDown
                                                       new SetElement(Locator[0], LocatorValue[33]), // Page Not Found Page DropDown
                                                       new SetElement(Locator[0], LocatorValue[34]), // Password Recovery Page DropDown
                                                       new SetElement(Locator[0], LocatorValue[35]), // Default Message Settings Radio Button
                                                       new SetElement(Locator[0], LocatorValue[36]), // Custom Message Settings Page DropDown
                                                       new SetElement(Locator[1], LocatorValue[37]), // Success Msg Button
                                                       new SetElement(Locator[1], LocatorValue[38]), // Error Msg Button
                                                       new SetElement(Locator[1], LocatorValue[39]), // Warning Msg Button
                                                       new SetElement(Locator[0], LocatorValue[40]), // Default Language DropDown
                                                       new SetElement(Locator[0], LocatorValue[41]), // English Radio Button
                                                       new SetElement(Locator[0], LocatorValue[42]), // Native Radio Button
                                                       new SetElement(Locator[0], LocatorValue[43]), // Portal TimeZone DropDown
                                                       new SetElement(Locator[0], LocatorValue[44]), // Site Email Address TextBox
                                                       new SetElement(Locator[0], LocatorValue[45]), // C-Panel Title TextBox
                                                       new SetElement(Locator[0], LocatorValue[46]), // C-Panel Copyright TextBox
                                                       // SuperUser Settings
                                                       new SetElement(Locator[0], LocatorValue[47]), // Restart Application
                                                       new SetElement(Locator[0], LocatorValue[48]), // Site Title TextBox
                                                       new SetElement(Locator[0], LocatorValue[49]), // Site Url TextBox
                                                       new SetElement(Locator[0], LocatorValue[50]), // Site Email TextBox
                                                       new SetElement(Locator[0], LocatorValue[51]), // Show Copyright CheckBox
                                                       new SetElement(Locator[0], LocatorValue[52]), // Custom Error Messages CheckBox
                                                       new SetElement(Locator[0], LocatorValue[53]), // SMTP Server and Port TextBox
                                                       new SetElement(Locator[0], LocatorValue[54]), // Test SMTP
                                                       new SetElement(Locator[0], LocatorValue[55]), // SMTP Authentication Anonymous
                                                       new SetElement(Locator[0], LocatorValue[56]), // SMTP Authentication Basic
                                                       new SetElement(Locator[0], LocatorValue[57]), // SMTP Enable SSL
                                                       new SetElement(Locator[0], LocatorValue[58]), // SMTP Username
                                                       new SetElement(Locator[0], LocatorValue[59]), // SMTP Password
                                                       new SetElement(Locator[0], LocatorValue[60]), // Allowable File Extension TextArea
                                                       new SetElement(Locator[0], LocatorValue[61]), // HelpUrl TextBox
                                                       new SetElement(Locator[0], LocatorValue[62]), // Page Extension TextBox
                                                       new SetElement(Locator[0], LocatorValue[63]), // Scheduler CheckBox
                                                       new SetElement(Locator[0], LocatorValue[64]), // User Agent PC Radio Button
                                                       new SetElement(Locator[0], LocatorValue[65]), // User Agent Mobile Radio Button
                                                       new SetElement(Locator[0], LocatorValue[66]), // User Agent Default Radio Button
                                                       new SetElement(Locator[0], LocatorValue[67]), // Enable Dashboard Help CheckBox
                                                       new SetElement(Locator[0], LocatorValue[68]), // Server Cookie Expiration TextBox
                                                };
        public Setting(IWebDriver Driver) : base(Driver) { }
        public Login LoginOperation(LoginData Logindata)
        {
            try
            {
                Login Login = new Login(Driver);
                Page NewPage = Login.LoginOperation(Logindata);
            }
            catch (Exception)
            {
                throw;
            }
            return new Login(Driver);
        }
        public Page DivExpansion(DivExpansion DivExpansion)
        {
            try
            {
                int i;
                for (i = 0; i < DivExpansion.N; i++)
                {
                    IList<IWebElement> DivCollaspeWrapper = DivExpansion.SettingDiv.FindElements(By.ClassName("sfCollapsewrapper"));
                    IWebElement DivAccordian = DivCollaspeWrapper[i].FindElements(By.TagName("div"))[0];
                    IWebElement DivAccordianholder = DivAccordian.FindElement(By.TagName("div"));
                    string DivAccordianholdertext = DivAccordianholder.GetAttribute("class");
                    IWebElement DivAccordianheader = DivAccordianholder.FindElement(By.TagName("div"));
                    if (DivAccordianholdertext == "sfAccordianholder")
                    {
                        DivAccordianheader.Click();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page ExpandingDiv()
        {
            try
            {
                int i;
                IWebElement SuperUserSettingsDiv = this.Driver.FindElement(By.Id("ctl19_TabContainer_TabPanel1"));
                for (i = 1; i < 4; i++)
                {
                    IList<IWebElement> DivCollaspeWrapper = SuperUserSettingsDiv.FindElements(By.ClassName("sfCollapsewrapper"));
                    switch (i)
                    {
                        case 0:
                            {
                                IWebElement AccordianDiv = DivCollaspeWrapper[i].FindElements(By.TagName("div"))[1];
                                IWebElement Accordianholder = AccordianDiv.FindElement(By.TagName("div"));
                                string Accordianholdertext = Accordianholder.GetAttribute("class");
                                IWebElement Accordianheader = Accordianholder.FindElement(By.TagName("div"));
                                if (Accordianholdertext == "sfAccordianholder")
                                {
                                    Accordianheader.Click();
                                }
                                break;
                            }
                        default:
                            {
                                IWebElement DivAccordian = DivCollaspeWrapper[i].FindElements(By.TagName("div"))[0];
                                IWebElement DivAccordianholder = DivAccordian.FindElement(By.TagName("div"));
                                string DivAccordianholdertext = DivAccordianholder.GetAttribute("class");
                                IWebElement DivAccordianheader = DivAccordianholder.FindElement(By.TagName("div"));
                                if (DivAccordianholdertext == "sfAccordianholder")
                                {
                                    DivAccordianheader.Click();
                                }
                                break;
                            }
                    }
                }
                return new Page(Driver);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Page SaveSettings(bool Save)
        {
            try
            {
                switch (Save)
                {
                    case true:
                        By SaveButtonLocator = this.SetElement(SettingPageElements[20]);
                        this.SetElementValue(SaveButtonLocator, true);
                        break;
                    default:
                        By RefreshButtonLocator = this.SetElement(SettingPageElements[21]);
                        this.SetElementValue(RefreshButtonLocator, true);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page ChangeBasicSettings(BasicSettings BasicSettings)
        {
            try
            {
                By BasicSettingTabLocator = this.SetElement(SettingPageElements[0]);
                this.SetElementValue(BasicSettingTabLocator, true);
                IWebElement BasicSettingDiv = this.Driver.FindElement(By.Id("ctl19_TabContainer_tabBasicSetting"));
                DivExpansion DivExpansionI = new DivExpansion(BasicSettingDiv, 5);
                DivExpansion(DivExpansionI);
                By TitleTextBoxLocator = this.SetElement(SettingPageElements[3]);
                this.SetElementValue(TitleTextBoxLocator, BasicSettings.PortalTitle);
                By DescriptionTextBoxLocator = this.SetElement(SettingPageElements[4]);
                this.SetElementValue(DescriptionTextBoxLocator, BasicSettings.PortalDescription);
                By KeyWordsTextBoxLocator = this.SetElement(SettingPageElements[5]);
                this.SetElementValue(KeyWordsTextBoxLocator, BasicSettings.KeyWords);
                By GoogleAdsenseIDTextBox = this.SetElement(SettingPageElements[6]);
                this.SetElementValue(GoogleAdsenseIDTextBox, BasicSettings.GoogleAdSenseID);
                switch (BasicSettings.ShowProfileLink)
                {
                    case false:
                        {
                            By NoProfileLinkLocator = this.SetElement(SettingPageElements[7]);
                            this.SetElementValue(NoProfileLinkLocator, true); 
                            break;
                        }
                    default:
                        {
                            By ShowProfileLinkLocator = this.SetElement(SettingPageElements[8]);
                            this.SetElementValue(ShowProfileLinkLocator, true);
                            break;
                        }
                }
                By EnableCDNCheckBoxLocator = this.SetElement(SettingPageElements[9]);
                this.SetElementValue(EnableCDNCheckBoxLocator, BasicSettings.EnableCDN);
                By EnableSesionTrackerCheckBoxLocator = this.SetElement(SettingPageElements[10]);
                this.SetElementValue(EnableSesionTrackerCheckBoxLocator, BasicSettings.EnableSessionTracker);
                By OptimizeCSSCheckBoxLocator = this.SetElement(SettingPageElements[11]);
                this.SetElementValue(OptimizeCSSCheckBoxLocator, BasicSettings.EnableOptimizationCSS);
                By OptimizeJSCheckBoxLocator = this.SetElement(SettingPageElements[12]);
                this.SetElementValue(OptimizeJSCheckBoxLocator, BasicSettings.EnableOptimizationJs);
                By EnableDashboardLiveFeedsCheckBoxLocator = this.SetElement(SettingPageElements[13]);
                this.SetElementValue(EnableDashboardLiveFeedsCheckBoxLocator, BasicSettings.EnableDashboardLiveFeeds);
                By OpenIDLoginEnableCheckBoxLocator = this.SetElement(SettingPageElements[15]);
                switch(BasicSettings.OpenIdEnable)
                {
                    case true:
                        this.SetElementValue(OpenIDLoginEnableCheckBoxLocator, true);
                        By FacebookConsumerKeyTextBoxLocator = this.SetElement(SettingPageElements[16]);
                        this.SetElementValue(FacebookConsumerKeyTextBoxLocator, BasicSettings.FbConsumerKey);
                        By FacebookSecretKeyTextBoxLocator = this.SetElement(SettingPageElements[17]);
                        this.SetElementValue(FacebookSecretKeyTextBoxLocator, BasicSettings.FbSecretKey);
                        By LinkedInConsumerKeyTextBoxLocator = this.SetElement(SettingPageElements[18]);
                        this.SetElementValue(LinkedInConsumerKeyTextBoxLocator, BasicSettings.LIConsumerKey);
                        By LinkedInSecretKeyTextBoxLocator = this.SetElement(SettingPageElements[19]);
                        this.SetElementValue(LinkedInSecretKeyTextBoxLocator, BasicSettings.LISecretKey); 
                        break;
                    default:
                        this.SetElementValue(OpenIDLoginEnableCheckBoxLocator, false);
                        break;
                }
                SaveSettings(BasicSettings.SaveBasicSettings); 
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page ChangeAdvancedSettings(AdvancedSettings AdvancedSettings)
        {
            try
            {
                By AdvancedTabLocator = this.SetElement(SettingPageElements[1]);
                this.SetElementValue(AdvancedTabLocator, true);
                IWebElement AdvancedSettingDiv = this.Driver.FindElement(By.Id("ctl19_TabContainer_tabAdvanceSetting"));
                DivExpansion DivExpansionI = new DivExpansion(AdvancedSettingDiv, 4);
                DivExpansion(DivExpansionI);
                switch(AdvancedSettings.UserRegistration)
                {
                    case "None":
                        By NoneRadioButtonLocator = this.SetElement(SettingPageElements[22]);
                        this.SetElementValue(NoneRadioButtonLocator, true); 
                        break;
                    case "Private":
                        By PrivateRadioButtonLocator = this.SetElement(SettingPageElements[23]);
                        this.SetElementValue(PrivateRadioButtonLocator, true); 
                        break;
                    case "Public":
                        By PublicRadioButtonLocator = this.SetElement(SettingPageElements[24]);
                        this.SetElementValue(PublicRadioButtonLocator, true); 
                        break;
                    case "Verified":
                        By VerifiedRadioButtonLocator = this.SetElement(SettingPageElements[25]);
                        this.SetElementValue(VerifiedRadioButtonLocator, true); 
                        break;
                }
                By LoginPageDropDownLocator = this.SetElement(SettingPageElements[26]);
                this.SetElementValue(LoginPageDropDownLocator, AdvancedSettings.LoginPage);
                By PortalDefaultPageDropDownLocator = this.SetElement(SettingPageElements[27]);
                this.SetElementValue(PortalDefaultPageDropDownLocator, AdvancedSettings.PortalDefaultPage);
                By UserProfilePageDropDownLocator = this.SetElement(SettingPageElements[28]);
                this.SetElementValue(UserProfilePageDropDownLocator, AdvancedSettings.UserProfilePage);
                By UserRegistrationPageDropDownLocator = this.SetElement(SettingPageElements[29]);
                this.SetElementValue(UserRegistrationPageDropDownLocator, AdvancedSettings.UserRegistrationPage);
                By UserActivationPageDropDownLocator = this.SetElement(SettingPageElements[30]);
                this.SetElementValue(UserActivationPageDropDownLocator, AdvancedSettings.UserActivationPage);
                By UserForgotPasswordPageDropDownLocator = this.SetElement(SettingPageElements[31]);
                this.SetElementValue(UserForgotPasswordPageDropDownLocator, AdvancedSettings.UserForgotPasswordPage);
                By PageNotAccessibleDropDownLocator = this.SetElement(SettingPageElements[32]);
                this.SetElementValue(PageNotAccessibleDropDownLocator, AdvancedSettings.PageNotAccessiblePage);
                By PageNotFoundPageDropDownLocator = this.SetElement(SettingPageElements[33]);
                this.SetElementValue(PageNotFoundPageDropDownLocator, AdvancedSettings.PageNotFoundPage);
                By PasswordRecoveryPageDropDownLocator = this.SetElement(SettingPageElements[34]);
                this.SetElementValue(PasswordRecoveryPageDropDownLocator, AdvancedSettings.PasswordRecoveryPage);
                switch (AdvancedSettings.MessageSetting)
                {
                    case "Custom":
                        By CustomRadioButtonLocator = this.SetElement(SettingPageElements[36]);
                        this.SetElementValue(CustomRadioButtonLocator, true); 
                        break;
                    default:
                        By DefaultRadioButtonLocator = this.SetElement(SettingPageElements[35]);
                        this.SetElementValue(DefaultRadioButtonLocator, true); 
                        break;
                }
                switch (AdvancedSettings.MessageType)
                {
                    case "Success":
                        By SuccessButtonLocator = this.SetElement(SettingPageElements[37]);
                        this.SetElementValue(SuccessButtonLocator, true); 
                        break;
                    case "Error":
                        By ErrorButtonLocator = this.SetElement(SettingPageElements[38]);
                        this.SetElementValue(ErrorButtonLocator, true); 
                        break;
                    case "Alert":
                        By AlertButtonLocator = this.SetElement(SettingPageElements[39]);
                        this.SetElementValue(AlertButtonLocator, true);
                        break;
                }
                By DefaultLanguageDropDownLocator = this.SetElement(SettingPageElements[40]);
                this.SetElementValue(DefaultLanguageDropDownLocator, AdvancedSettings.DefaultLanguage);
                switch (AdvancedSettings.LanguageType)
                {
                    case "English":
                        By EnglishRadioButtonLocator = this.SetElement(SettingPageElements[41]);
                        this.SetElementValue(EnglishRadioButtonLocator, true); 
                        break;
                    case "Native":
                        By NativeRadioButtonLocator = this.SetElement(SettingPageElements[42]);
                        this.SetElementValue(NativeRadioButtonLocator, true); 
                        break;
                }
                By PortalTimeZoneDropDownLocator = this.SetElement(SettingPageElements[43]);
                this.SetElementValue(PortalTimeZoneDropDownLocator, AdvancedSettings.PortalTimeZone);
                By SiteAdminEmailAddressTextBoxLocator = this.SetElement(SettingPageElements[44]);
                this.SetElementValue(SiteAdminEmailAddressTextBoxLocator, AdvancedSettings.SiteAdminEmailAddress);
                By CPanelTitleTextBoxLocator = this.SetElement(SettingPageElements[45]);
                this.SetElementValue(CPanelTitleTextBoxLocator, AdvancedSettings.LogoTemplate);
                By CPanelCopyrightTextBoxLocator = this.SetElement(SettingPageElements[46]);
                this.SetElementValue(CPanelCopyrightTextBoxLocator, AdvancedSettings.CopyRight);
                SaveSettings(AdvancedSettings.SaveAdvancedSettings);
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }       
        public Page ChangeSuperUserSettings(SuperUserSettings SuperUserSettings)
        {
            try
            {
                By SuperUserSettingTabLocator = this.SetElement(SettingPageElements[2]);
                this.SetElementValue(SuperUserSettingTabLocator, true);
                ExpandingDiv();
                By SiteTitleTextBoxLocator = this.SetElement(SettingPageElements[48]);
                this.SetElementValue(SiteTitleTextBoxLocator, SuperUserSettings.SiteTitle);
                By SiteUrlTextBoxLocator = this.SetElement(SettingPageElements[49]);
                this.SetElementValue(SiteUrlTextBoxLocator, SuperUserSettings.SiteUrl);
                By SiteEmailTextBoxLocator = this.SetElement(SettingPageElements[50]);
                this.SetElementValue(SiteEmailTextBoxLocator, SuperUserSettings.SiteEmail);
                By ShowCopyrightCheckBoxLocator = this.SetElement(SettingPageElements[51]);
                this.SetElementValue(ShowCopyrightCheckBoxLocator, SuperUserSettings.CopyrightEnable);
                By CustomErrorMessageCheckBoxLocator = this.SetElement(SettingPageElements[52]);
                this.SetElementValue(CustomErrorMessageCheckBoxLocator, SuperUserSettings.CustomError);
                By SMTPServerAndPortTextBox = this.SetElement(SettingPageElements[53]);
                this.SetElementValue(SMTPServerAndPortTextBox, SuperUserSettings.SMTPServerAndPort);
                switch (SuperUserSettings.SMTPBasic)
                {
                    case true:
                        By BasicRadioButtonLocator = this.SetElement(SettingPageElements[56]);
                        this.SetElementValue(BasicRadioButtonLocator, true);
                        ExpandingDiv();
                        By UsernameTextBoxLocator = this.SetElement(SettingPageElements[58]);
                        this.SetElementValue(UsernameTextBoxLocator, SuperUserSettings.SMTPUserName);
                        By PasswordTextBoxLocator = this.SetElement(SettingPageElements[59]);
                        this.SetElementValue(PasswordTextBoxLocator, SuperUserSettings.SMTPPassword); 
                        break;
                    default:
                        By AnonymousRadioButtonLocator = this.SetElement(SettingPageElements[55]);
                        this.SetElementValue(AnonymousRadioButtonLocator, true); 
                        break;
                }
                By EnableSSLCheckBoxLocator = this.SetElement(SettingPageElements[57]);
                this.SetElementValue(EnableSSLCheckBoxLocator, SuperUserSettings.EnableSSL);
                By AllowFileExtensionTextAreaLocator = this.SetElement(SettingPageElements[60]);
                this.SetElementValue(AllowFileExtensionTextAreaLocator, SuperUserSettings.FileExtensions);
                By HelpUrlTextBoxLocator = this.SetElement(SettingPageElements[61]);
                this.SetElementValue(HelpUrlTextBoxLocator, SuperUserSettings.HelpUrl);
                By PageExtensionTextBoxLocator = this.SetElement(SettingPageElements[62]);
                this.SetElementValue(PageExtensionTextBoxLocator, SuperUserSettings.PageExtension);
                By SchedulerCheckBoxLocator = this.SetElement(SettingPageElements[63]);
                this.SetElementValue(SchedulerCheckBoxLocator, SuperUserSettings.EnableScheduler);
                switch (SuperUserSettings.UserAgent)
                {
                    case "PC":
                        By PCRadioButtonLocator = this.SetElement(SettingPageElements[64]);
                        this.SetElementValue(PCRadioButtonLocator, true);
                        break;
                    case "Mobile":
                        By MobileRadioButtonLocator = this.SetElement(SettingPageElements[65]);
                        this.SetElementValue(MobileRadioButtonLocator, true); 
                        break;
                    case "Default":
                        break;
                }
                By EnableDashboardHelpCheckBox = this.SetElement(SettingPageElements[66]);
                this.SetElementValue(EnableDashboardHelpCheckBox, SuperUserSettings.EnableDashboardHelp);
                By ServerCookieExpirationTextBoxLocator = this.SetElement(SettingPageElements[67]);
                this.SetElementValue(ServerCookieExpirationTextBoxLocator, SuperUserSettings.ServerCookieExpirationTime);
                SaveSettings(SuperUserSettings.SaveSuperUserSettings); 
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
    }
}