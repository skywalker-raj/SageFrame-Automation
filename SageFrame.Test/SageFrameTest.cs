/*
 -----------------------------------------------------------------------------------------------------------------------------------------
 Author: Raj Kumar Thapa
 -----------------------------------------------------------------------------------------------------------------------------------------
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageFrame.Framework;
using SageFrame.Framework.Page_Objects;
using OpenQA.Selenium;
//using NUnit.Framework;
namespace SageFrame.Test
{
    [TestClass]
    public class SageFrameTest
    {
        private IWebDriver Driver;
        private Uri Url = new Uri("http://172.18.12.225:4444/wd/hub/");
        private string BrowserName = "FireFox";
        [TestInitialize]
        public void Setup()
        {
            try
            {
                Driver = Browser.Remote(Url, BrowserName, "");
                //Driver.Url = Browser.baseURL + LoginPage.LoginUrl;
                //Driver.Url = "http://superuser:supersuer@172.18.12.225:4567/sf/sfLogin.aspx";
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_Login()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            try
            {
                LoginPage LoginPage = new LoginPage(Driver);
                Browser.GoTo(Driver, LoginPage.LoginUrl);
                Page NewPage = LoginPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Home")); 
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_Register()
        {
            string UserName = "illusion";
            string Email = "rthapa@braindigit.com";
            string FirstName = "Raj";
            string LastName = "Thapa";
            string Password = "soundgravity";
            string ConfirmPassword = "soundgravity";
            bool Register = true;
            RegisterUser[] Registeruser = {
                                              new RegisterUser(FirstName, LastName, UserName, Email, Password, ConfirmPassword, Register),
                                          };
            try
            {
                User_Registration UserRegistrationPage = new User_Registration(Driver);
                Browser.GoTo(Driver, User_Registration.UserRegistrationUrl);
                Page NewPage = UserRegistrationPage.UserRegistration(Registeruser[0]);
                Assert.IsTrue(NewPage.Is_At("Home"));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_AddUser()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            string UserNameI = "illusion";
            string EmailI = "illusionineyes@gmail.com";
            string FirstName = "Raj";
            string LastName = "Thapa";
            string PasswordI = "soundgravity";
            string ReTypePassword = "soundgravity";
            string SQuestion = "What is your pet's name?";
            string SAnswer = "Dalle";
            string[] UserRole = { "Registered User", "Site Admin" };
            bool CreateUser = true;
            AddUser AddUser = new AddUser(UserNameI, EmailI, FirstName, LastName, PasswordI, ReTypePassword, SQuestion, SAnswer, UserRole, CreateUser);
            try
            {
                User UserPage = new User(Driver);
                Browser.GoTo(Driver, User.UserUrl);
                Page NewPage = UserPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Users"));
                NewPage = UserPage.AddUser(AddUser);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_EditUser()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            string rolechange = "Unselect";
            bool UserInformationChange = true; 
            bool RoleChange = true;
            string UserRole = "Registered User";
            int N = 2;
            string Sex = "Male";
            string ResPhone = "071437601";
            string Mobile = "9819445633";
            string Others = "";
            string FN = "Raj";
            string LN = "Thapa";
            DateTime BDate = new DateTime(1990, 12, 06);
            string Location = "Butwal";
            string FullName = "Raj Kumar Thapa";
            string[] EmailI = { "illusionineyes@gmail.com", "illusionineyes@hotmail.com", "rthapa@braindigit.com" };
            bool PasswordChange = true;
            string NewPassword = "soundgravity";
            string ReTypePassword = "soundgravity";
            bool UserProfileChange = true;
            string ImgPath = @"D:\snips\Free Images\Pearl-Jam-Stickman.png";
            string AboutMe = "Quality Assurance Engineer At Braindigit IT Solutions PVT Limited";
            bool Active = true;
            EditUser EditUser = new EditUser(rolechange, UserInformationChange, RoleChange, UserRole, N, Sex, ResPhone, Mobile, Others, FN, LN, BDate, Location, FullName, EmailI, PasswordChange, NewPassword, ReTypePassword, UserProfileChange, ImgPath, AboutMe, Active);
            try
            {
                User UserPage = new User(Driver);
                Browser.GoTo(Driver, User.UserUrl);
                Page NewPage = UserPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Users"));
                NewPage = UserPage.EditUser(EditUser);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_SearchUser()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            string UserRole = "Site Admin";
            string Rpp = "25";
            string Search = "illusion";
            DateTime DateFrom = new DateTime(2015, 06, 12);
            DateTime DateTo = new DateTime(2016, 07, 15);
            string FilterMode = "Approved";
            SearchUser SearchUser = new SearchUser(UserRole, Rpp, Search, DateFrom, DateTo, FilterMode);
            try
            {
                User UserPage = new User(Driver);
                Browser.GoTo(Driver, User.UserUrl);
                Page NewPage = UserPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Users"));
                NewPage = UserPage.SearchUser(SearchUser);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_ExportImportUser()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            string Action = "Export";
            string Path = @"C:\Users\Raj\Downloads\User-Report_3_02_2016_17_3_41.csv";
            bool Save = true;
            ExportImportUser ExportImportUser = new ExportImportUser(Action, Path, Save);
            try
            {
                User UserPage = new User(Driver);
                Browser.GoTo(Driver, User.UserUrl);
                Page NewPage = UserPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Users"));
                NewPage = UserPage.ExportImportUser(ExportImportUser);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_UpdateUserSettings()
        {
            try
            {

            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_Perform_CacheMaintenance()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            bool[] Clear = { true, false, true, true, false, true, true, false, false };
            bool ClearAll = false;
            bool SaveAll = false;
            bool[] Save = { true, false, true };
            CacheSettings Cache = new CacheSettings(Clear, ClearAll, SaveAll, Save);
            try
            {
                CacheMaintenance CacheMaintenancePage = new CacheMaintenance(Driver);
                Browser.GoTo(Driver, CacheMaintenance.CacheMaintenanceUrl);
                Page NewPage = CacheMaintenancePage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Cache Maintenance"));
                NewPage = CacheMaintenancePage.CacheMaintenanceSettings(Cache);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_GenerateSiteMap()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            double Priority = 0.9;
            string Frequency = "Yearly";
            bool Google = true;
            bool Yahoo = true;
            bool Bing = true;
            bool Ask = true;
            GenerateSiteMap GenerateSiteMap = new GenerateSiteMap(Priority, Frequency, Google, Yahoo, Bing, Ask);
            try
            {
                SEO SEOPage = new SEO(Driver);
                Browser.GoTo(Driver, SEO.SEOUrl);
                Page NewPage = SEOPage.LoginOperation(Logindata);
                NewPage = SEOPage.GenerateSiteMap(GenerateSiteMap); 
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_GenerateRobot()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            bool[] Pages = { true, true, false, true, false };
            bool Google = true;
            bool Yahoo = true;
            bool Bing = true;
            bool Msn = true;
            GenerateRobots GenerateRobots = new GenerateRobots(Google, Yahoo, Bing, Msn, Pages);
            try
            {
                SEO SEOPage = new SEO(Driver);
                Browser.GoTo(Driver, SEO.SEOUrl);
                Page NewPage = SEOPage.LoginOperation(Logindata);
                NewPage = SEOPage.GenerateRobots(GenerateRobots); 
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_AddGoogleJS()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            string GoogleJS = "(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)})(window,document,'script','//www.google-analytics.com/analytics.js','ga');ga('create', 'UA-64446976-1', 'auto');ga('send', 'pageview');";
            bool IsActive = true;
            bool Update = true;
            bool Refresh = false;
            AddGoogleJs AddGoogleJs = new AddGoogleJs(GoogleJS, IsActive, Update, Refresh);
            try
            {
                SEO SEOPage = new SEO(Driver);
                Browser.GoTo(Driver, SEO.SEOUrl);
                Page NewPage = SEOPage.LoginOperation(Logindata);
                NewPage = SEOPage.AddGoogleJS(AddGoogleJs);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_CreateModule()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            string ModuleName = "Test";
            string ModuleDescription = "TestDescription";
            string ModuleTableName = "TestTable";
            bool IncludeCss = false;
            bool IncludeJs = true;
            bool IncludeWebService = true;
            bool EditInclude = true;
            bool SettingInclude = false;
            string ModuleType = "Portal";
            bool AutoIncrement = true;
            string[] ColumnName = { "TestID", "Name", "Number" };
            string[] DataType = { "int", "varchar(50)", "bigint" };
            bool[] AllowNull = { true, true };
            bool DownloadClassZip = false;
            bool Back = true;
            ModuleMaker ModuleMaker = new ModuleMaker(ModuleName, ModuleDescription, ModuleTableName, IncludeCss, IncludeJs, IncludeWebService, EditInclude, SettingInclude, ModuleType, AutoIncrement, ColumnName, DataType, AllowNull, DownloadClassZip, Back);
            try
            {
                Module_Maker ModuleMakerPage = new Module_Maker(Driver);
                Browser.GoTo(Driver, Module_Maker.ModuleMakerUrl);
                Page NewPage = ModuleMakerPage.LoginOperation(Logindata);
                NewPage = ModuleMakerPage.CreateModule(ModuleMaker);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_Perform_SQLOperation()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            bool ArchiveSession = true;
            bool BackupDatabase = true;
            bool CleanUpScript = false;
            bool UploadFile = false;
            string SQLFilePath = @"‪C:\Users\Raj\Documents\script.sql";
            string SqlScript = "select * from Users";
            bool RunAsScript = false;
            SQLPageFunction SQLPageFunction = new SQLPageFunction(ArchiveSession, BackupDatabase, CleanUpScript, UploadFile, SQLFilePath, SqlScript, RunAsScript);
            try
            {
                SQL SQLPage = new SQL(Driver);
                Browser.GoTo(Driver, SQL.SQLUrl);
                Page NewPage = SQLPage.LoginOperation(Logindata);
                NewPage = SQLPage.SQLOperations(SQLPageFunction);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_Perform_LayoutOperation()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            int TemplateNo = 2;
            string Options = "Customize";
            string Customize = "Layout Manager";
            TemplateOptions TemplateOptions = new TemplateOptions(TemplateNo, Options, Customize);
            string LayoutName = "test";
            string Operation = "Create Modern";
            bool Delete = false;
            string NewLayoutName = "test1";
            string LayoutHolder = @"<layout name=""layout_all"" modern=""true""><div class=""container sfCol_100""></div></layout>";
            bool Create = true;
            Layout Layout = new Layout(LayoutName, Operation, Delete, NewLayoutName, LayoutHolder, Create);
            try
            {
                Templates TemplatesPage = new Templates(Driver);
                Browser.GoTo(Driver, Templates.TemplateUrl);
                Page NewPage = TemplatesPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Templates"));
                NewPage = TemplatesPage.TemplateOptions(TemplateOptions);
                NewPage = TemplatesPage.Layout(Layout);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_Perform_ThemeOptions()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            int TemplateNo = 2;
            string Options = "Customize";
            string Customize = "Theme Options";
            TemplateOptions TemplateOptions = new TemplateOptions(TemplateNo, Options, Customize);
            bool Navigation = true;
            bool Forms = true;
            bool Tables = true;
            bool Pagination = true;
            CSSComponents CSSComponents = new CSSComponents(Navigation, Forms, Tables, Pagination);
            bool GeneralI = true;
            string Layout = "Fluid";
            bool RightToLeft = true;
            string GutterSpace = "20";
            General General = new General(GeneralI, Layout, CSSComponents, RightToLeft, GutterSpace);
            bool TypographyI = true;
            bool GoogleFont = false;
            string GoogleFontI = "https://fonts.googleapis.com/css?family=Tangerine|Inconsolata|Droid+Sans";
            string HeadingFont = "icon-font";
            string BodyFont = "icon-font";
            string CustomFont = @"‪C:\Users\Raj\Downloads\Font\Art Brewery.ttf";
            string BaseFontSize = "29";
            string BaseLineHeight = "12";
            string H1Size = "30";
            string H2Size = "29";
            string H3Size = "28";
            string H4Size = "27";
            string H5Size = "26";
            string H6Size = "25";
            Typography Typography = new Typography(TypographyI, GoogleFont, GoogleFontI, HeadingFont, BodyFont, CustomFont, BaseFontSize, BaseLineHeight, H1Size, H2Size, H3Size, H4Size, H5Size, H6Size);
            bool ImagesI = true;
            bool ChangeFavIcon = true;
            string FavIcon = @"‪D:\snips\Logo\donatelo.ico";
            bool ChangeBackgroundImage = true;
            string BackgroundImage = @"‪D:\snips\Free Images\Café.jpg";
            bool ChangePattern = false;
            string Pattern = @"‪C:\Users\Raj\Desktop\pattern\pattern7.png";
            Images Images = new Images(ImagesI, ChangeFavIcon, FavIcon, ChangeBackgroundImage, BackgroundImage, ChangePattern, Pattern);
            bool ColorsI = true;
            string BodyTextColor = "#a6cc2b";
            string BodyBackgroundColor = "#fff";
            string LinkTextColor = "#428bca";
            string LinkHoverColor = "#c45bde";
            bool UnderLineLinkHover = true;
            string H1TextColor = "#428bca";
            string H2TextColor = "#5cb85c";
            string H3TextColor = "#5bc0de";
            string H4TextColor = "#d9534f";
            string H5TextColor = "#f0ad4e";
            string H6TextColor = "#555";
            string PrimaryButtonColor = "#428bca";
            string SuccessButtonColor = "#5cb85c";
            string InfoButtonColor = "#5bc0de";
            string ErrorButtonColor = "#d9534f";
            string WarningButtonColor = "#f0ad4e";
            Colors Colors = new Colors(ColorsI, BodyTextColor, BodyBackgroundColor, LinkTextColor, LinkHoverColor, UnderLineLinkHover, H1TextColor, H2TextColor, H3TextColor, H4TextColor, H5TextColor, H6TextColor, PrimaryButtonColor, SuccessButtonColor, InfoButtonColor, ErrorButtonColor, WarningButtonColor);
            bool HeaderI = true;
            bool HeaderSticky = true;
            bool DisableHeaderSmallScreens = false;
            bool HeaderTransparent = true;
            string TransparentValue = "0.5";
            bool LeftSideHeader = false;
            Header Header = new Header(HeaderI, HeaderSticky, DisableHeaderSmallScreens, HeaderTransparent, TransparentValue, LeftSideHeader);
            bool CustomCSSI = true;
            string CustomCSSValue = "body { display:block; }";
            CustomCSS CustomCSS = new CustomCSS(CustomCSSI, CustomCSSValue);
            bool Reset = false;
            bool Save = true;
            ThemeOptions ThemeOptions = new ThemeOptions(General, Typography, Images, Colors, Header, CustomCSS, Reset, Save);
            try
            {
                Templates TemplatesPage = new Templates(Driver);
                Browser.GoTo(Driver, Templates.TemplateUrl);
                Page NewPage = TemplatesPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Templates"));
                NewPage = TemplatesPage.TemplateOptions(TemplateOptions);
                NewPage = TemplatesPage.ThemeOptions(ThemeOptions);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_Add_System_Event_StartUp()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            string ControlUrl = "Modules/Admin/Adsense/Adsense.ascx";
            string EventLocation = "Middle";
            bool IsAdmin = true;
            bool IsControlUrl = true;
            bool IsActive = true;
            bool Confirm = true;
            AddEventStartUp AddEventStartUp = new AddEventStartUp(ControlUrl, EventLocation, IsAdmin, IsControlUrl, IsActive, Confirm);
            try
            {
                System_Event_Startup SystemEventStartupPage = new System_Event_Startup(Driver);
                Browser.GoTo(Driver, System_Event_Startup.SystemEventStartupUrl);
                Page NewPage = SystemEventStartupPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("System Event StartUp"));
                NewPage = SystemEventStartupPage.Add_Event_Startup(AddEventStartUp);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_Perform_EventListManagement()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            int[] EventNo = { 1 };
            string[] Action = { "Edit" };
            string ControlUrl = "Modules/Admin/CacheMaintenance/CacheMaintenance.ascx";
            string EventLocation = "Top";
            bool IsAdmin = false;
            bool IsControlUrl = false;
            bool IsActive = true;
            bool Confirm = true;
            AddEventStartUp[] AddEventStartUp = {
                                                    new AddEventStartUp(ControlUrl, EventLocation, IsAdmin, IsControlUrl, IsActive, Confirm),
                                                };
            bool[] Delete = { true };
            EventListManagement EventListManagement = new EventListManagement(EventNo, Action, AddEventStartUp, Delete);
            try
            {
                System_Event_Startup SystemEventStartupPage = new System_Event_Startup(Driver);
                Browser.GoTo(Driver, System_Event_Startup.SystemEventStartupUrl);
                Page NewPage = SystemEventStartupPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("System Event StartUp"));
                NewPage = SystemEventStartupPage.EventListManagement(EventListManagement);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_ChangeBasicSettings()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            string PortalTitle = "www.sageframe.com";
            string PortalDescription = "www.sageframe.com";
            string KeyWords = "www.sageframe.com";
            string GoogleAdsenseID = "pub-1427651338796450";
            bool ShowProfileLink = true;
            bool EnableCDN = true;
            bool EnableSessionTracker = true;
            bool EnableOptimizationCSS = true;
            bool EnableOptimizationJS = true;
            bool EnableDashboardLiveFeeds = true;
            bool OpenIDEnable = true;
            string FBConsumerKey = "276571315797718";
            string FBSecretKey = "35a35c105f883b3a35953d88e33a3047";
            string LIConsumerKey = "mhziyr2sgko6";
            string LISecretKey = "4p0SoFgdkEuhf277";
            bool SaveBasicSettings = true;
            BasicSettings BasicSettings = new BasicSettings(PortalTitle, PortalDescription, KeyWords, GoogleAdsenseID, ShowProfileLink, EnableCDN, EnableSessionTracker, EnableOptimizationCSS, EnableOptimizationJS, EnableDashboardLiveFeeds, OpenIDEnable, FBConsumerKey, FBSecretKey, LIConsumerKey, LISecretKey, SaveBasicSettings);
            try
            {
                Setting SettingsPage = new Setting(Driver);
                Browser.GoTo(Driver, Setting.SettingUrl);
                Page NewPage = SettingsPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Setting"));
                NewPage = SettingsPage.ChangeBasicSettings(BasicSettings); 
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void Can_ChangeAdvancedSettings()
        {
            string UserName = "superuser";
            string Password = "superuser";
            bool ForgotPassword = false;
            string Email = "info@sageframe.com";
            LoginData Logindata = new LoginData(UserName, Password, ForgotPassword, Email);
            string UserRegistration = "Public";
            string LoginPage = "Login";
            string PortalDefaultPage = "Home";
            string UserProfilePage = "User Profile";
            string UserRegistrationPage = "User Registration";
            string UserActivationPage = "User Activation";
            string UserForgotPasswordPage = "Forgot Password";
            string PageNotAccessiblePage = "Page Not Accessible";
            string PageNotFoundPage = "Page Not Found";
            string PasswordRecoveryPage = "Password Recovery";
            string MessageSetting = "Custom";
            string MessageType = "Success";
            string DefaultLanguage = "English(United States)";
            string LanguageType = "English";
            string PortalTimeZone = "(UTC +05:45) Kathmandu";
            string SiteAdminEmailAddress = "admin@sageframe.com";
            string LogoTemplate = "C-Panel";
            string CopyRight = "Copyright 2015 SageFrame.com. All Rights Reserved®";
            bool SaveAdvancedSettings = true;
            AdvancedSettings AdvancedSettings = new AdvancedSettings(UserRegistration, LoginPage, PortalDefaultPage, UserProfilePage, UserRegistrationPage, UserActivationPage, UserForgotPasswordPage, PageNotAccessiblePage, PageNotFoundPage, PasswordRecoveryPage, MessageSetting, MessageType, DefaultLanguage, LanguageType, PortalTimeZone, SiteAdminEmailAddress, LogoTemplate, CopyRight, SaveAdvancedSettings);
            try
            {
                Setting SettingsPage = new Setting(Driver);
                Browser.GoTo(Driver, Setting.SettingUrl);
                Page NewPage = SettingsPage.LoginOperation(Logindata);
                Assert.IsTrue(NewPage.Is_At("Setting"));
                NewPage = SettingsPage.ChangeAdvancedSettings(AdvancedSettings);  
            }
            catch(Exception)
            {
                throw;
            }
        }
        [TestCleanup]
        public void Teardown()
        {
            try
            {
                Driver.Close();
                //eyes.Close();
                //eyes.AbortIfNotClosed();
                Driver.Quit();
            }
            catch (Exception)
            {
                throw;
            }
        }      
    }
}
