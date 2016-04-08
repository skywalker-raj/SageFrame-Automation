/*
 -----------------------------------------------------------------------------------------------------------------------------------------
 Author: Raj Kumar Thapa
 -----------------------------------------------------------------------------------------------------------------------------------------
 */
using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Net;
using NUnit.Framework;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium.Support.Events;
using System.Drawing.Imaging;
using Applitools;
using System.Drawing;
using System.Web;
using System.Web.Hosting;
using System.Data.SqlClient;
//using System.Windows.Forms;
namespace SageFrame.Framework
{
    #region
    public class MouseMovement
    {
        public IWebElement Element { get; set; }
        public bool Click { get; set; }
        public MouseMovement(IWebElement element, bool click)
        {
            Element = element;
            Click = click;
        }
    }
    public class DragNDrop
    {
        public IWebElement Source { get; set; }
        public IWebElement Target { get; set; }
        public DragNDrop(IWebElement source, IWebElement target)
        {
            Source = source;
            Target = target;
        }
    }
    public class WaitForElement
    {
        public By by { get; set; }
        public int timeoutInSeconds { get; set; }
        public WaitForElement(By By, int TimeoutInSeconds)
        {
            by = By;
            timeoutInSeconds = TimeoutInSeconds;
        }
    }
    public class InjectJs
    {
        public string ClassName { get; set; }
        public string Value { get; set; }
        public string Attribute { get; set; }
        public InjectJs(string classname, string value, string attribute)
        {
            ClassName = classname;
            Value = value;
            Attribute = attribute;
        }
    }
    public class JSExecutor
    {
        public string JS { get; set; }
        public IWebElement Element { get; set; }
        public JSExecutor(string js, IWebElement element)
        {
            JS = js;
            Element = element;
        }
    }
    #endregion
    public static class Browser
    {
        private static string screenShotPath = "." + Path.DirectorySeparatorChar + "Screenshots" + Path.DirectorySeparatorChar;
        private static string errorScreenShotPath = "." + Path.DirectorySeparatorChar + "ErrorScreenshots" + Path.DirectorySeparatorChar;
        public static string baseURL = "http://172.18.12.225:4567/";
        public static EventFiringWebDriver firingDriver;
        public static IWebDriver IECapabilities()
        {
            try
            {
                InternetExplorerOptions options = new InternetExplorerOptions();
                options.Proxy = proxy;
                options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                options.UsePerProcessProxy = true;
                options.EnsureCleanSession = true;
                //var capabilitiesInternet = new OpenQA.Selenium.Remote.DesiredCapabilities();
                //capabilitiesInternet.SetCapability("ignoreProtectedModeSettings", true);
                //capabilitiesInternet.SetCapability("ie.ensureCleanSession", true);
                IWebDriver webDriver = new InternetExplorerDriver(@"C:\Program Files\Selenium\", options);
                return webDriver;
            }
            catch (Exception)
            {
                return null;
                // throw ex;
            }
        }
        public static DesiredCapabilities Desired()
        {
            DesiredCapabilities capability = DesiredCapabilities.HtmlUnit();
            capability.IsJavaScriptEnabled = true;
            return capability;
        }
        public static FirefoxProfile GetFireFoxProfile()
        {
            try
            {
                FirefoxProfile user_pref = new FirefoxProfile();
                //user_pref.SetPreference("setAlwaysLoadNoFocusLib", true);
                //user_pref.SetPreference("browser.tabs.loadInBackground", false);            
                //if (File.Exists(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\firebug@software.joehewitt.com.xpi"))
                //{
                //    FileStream firebug = new FileStream(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\firebug@software.joehewitt.com.xpi", FileMode.Open, FileAccess.Write);
                //    File firebug = new File(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\firebug@software.joehewitt.com.xpi");
                //user_pref.AddExtension(new File(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\firebug@software.joehewitt.com.xpi"));
                //    user_pref.SetPreference(“extensions.firebug.currentVersion”, “2.0”);
                //    user_pref.SetPreference(“extensions.firebug.addonBarOpened”, true);
                //    user_pref.SetPreference(“extensions.firebug.console.enableSites”, true);
                //    user_pref.SetPreference(“extensions.firebug.script.enableSites”, true);
                //    user_pref.SetPreference(“extensions.firebug.net.enableSites”, true);
                //    user_pref.SetPreference(“extensions.firebug.previousPlacement”, 1);
                //    user_pref.SetPreference(“extensions.firebug.allPagesActivation”, “on”);
                //    user_pref.SetPreference(“extensions.firebug.onByDefault”, true);
                //    user_pref.SetPreference(“extensions.firebug.defaultPanelName”, “net”);
                //    if (File.Exists(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\yslow@yahoo-inc.com.xpi"))
                //    {
                //        File yslow = new File(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\yslow@yahoo-inc.com.xpi");
                //        user_pref.AddExtension((yslow));
                //        user_pref.SetPreference(“extensions.yslow.beaconUrl”, “http://www.showslow.com/beacon/yslow/ “);
                //        user_pref.SetPreference(“extensions.yslow.beaconInfo”,”grade”);
                //        user_pref.SetPreference(“extensions.yslow.optinBeacon”,true);
                //        user_pref.SetPreference(“extensions.yslow.autorun”,true);
                //    }
                //}
                //user_pref.SetProxyPreferences(proxy);
                user_pref.SetPreference("SetEnableNativeEvents", true);//scroll webelements
                user_pref.SetPreference("intl.accept_languages", "jp");//Support internationalizatin
                user_pref.SetPreference("browser.helperApps.alwaysAsk.force", false);
                user_pref.SetPreference("browser.download.folderList", 2);
                user_pref.SetPreference("browser.download.dir", @"C:\Users\RajKumar-PC\Downloads\Documents");
                user_pref.SetPreference("browser.download.useDownloadDir", true);
                user_pref.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);
                user_pref.SetPreference("browser.download.manager.alertOnEXEOpen", false);
                user_pref.SetPreference("browser.download.manager.closeWhenDone", true);
                user_pref.SetPreference("browser.download.manager.focusWhenStarting", false);
                user_pref.SetPreference("browser.helperApps.neverAsk.saveToDisk", "text/xml, text/csv, text/plain, text/log, application/zip, application/zlib, application/x-gzip, application/x-gtar, multipart/x-gzip, application/tgz, application/gnutar, application/x-tar, application/gzip, application/pdf, application/x-msexcel, application/x-compressed, application/x-zip-compressed, multipart/x-zip, application/x-rar-compressed, application/octet-stream");
                user_pref.SetPreference("pdfjs.disabled", true);
                user_pref.SetPreference("setAcceptUntrustedCertificates", false);
                return user_pref;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        public static FirefoxProfile Profile = GetFireFoxProfile();
        public static string DriverPath = @"D:\Personnel\Selenium WebDriver\Driversfor selenium";
        public static IWebDriver FireFox()
        {           
            return new FirefoxDriver();
        }
        public static IWebDriver InternetExplorer()
        {
            return new InternetExplorerDriver(DriverPath);
        }
        public static IWebDriver ChromeDriver()
        {
            return new ChromeDriver(DriverPath);
        }
        public static IWebDriver Remote(Uri DriverHub, string BrowserName, string BrowserVersion)
        {
            try
            {
                DesiredCapabilities Capabilities = new DesiredCapabilities();              
                switch (BrowserName)
                {
                    case "Chrome":
                        ChromeOptions ChromeOpt = new ChromeOptions();
                        ChromeOpt.AddArguments("test-type");
                        Capabilities = DesiredCapabilities.Chrome();
                        Capabilities.SetCapability(ChromeOptions.Capability, ChromeOpt);
                        break;
                    case "IE":
                        Capabilities = DesiredCapabilities.InternetExplorer();
                        break;
                    case "FireFox":
                        Capabilities = DesiredCapabilities.Firefox();
                        //FirefoxProfile Profile = GetFireFoxProfile();
                        Capabilities.SetCapability(FirefoxDriver.ProfileCapabilityName, Profile);
                        break;
                    case "HtmlUnit":
                        Capabilities = DesiredCapabilities.HtmlUnit();
                        break;
                        
                }
                Capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
                Capabilities.SetCapability(CapabilityType.BrowserName, BrowserName);
                Capabilities.SetCapability(CapabilityType.Version, BrowserVersion);
                Capabilities.SetCapability(CapabilityType.TakesScreenshot, true);
                //"http://172.18.12.109:5555/wd/hub"
                return new RemoteWebDriver(DriverHub, Capabilities);
                //return new EventFiringWebDriver(new FirefoxDriver(Profile));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string ScreenshotPath
        {
            get { return screenShotPath; }
            set
            {
                if (value.EndsWith(Path.DirectorySeparatorChar.ToString()))
                {
                    screenShotPath = value;
                }
                else
                {
                    screenShotPath = value + Path.DirectorySeparatorChar;
                }
            }
        }
        public static string ErrorScreenshotPath
        {
            get { return errorScreenShotPath; }
            set
            {
                if (value.EndsWith(Path.DirectorySeparatorChar.ToString()))
                {
                    errorScreenShotPath = value;
                }
                else
                {
                    errorScreenShotPath = value + Path.DirectorySeparatorChar;
                }
            }
        }
        public static void TakeScreenShot(IWebDriver Driver, string FileName)
        {
            try
            {
                Screenshot ScreenShotFile = ((ITakesScreenshot)Driver).GetScreenshot();
                ScreenShotFile.SaveAsFile(ScreenshotPath + FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void CaptureError(IWebDriver Driver, string FileName)
        {
            try
            {
                Screenshot ScreenShotFile = ((ITakesScreenshot)Driver).GetScreenshot();
                ScreenShotFile.SaveAsFile(ErrorScreenshotPath + FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Object ExecuteJSCommand(IWebDriver webDriver, string JSCommand)
        {
            try
            {
                IJavaScriptExecutor JSE = (IJavaScriptExecutor)webDriver;
                Object obj = JSE.ExecuteScript(JSCommand);
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void ConfigureBrowser(IWebDriver Driver)
        {
            try
            {
                //Driver.Manage().Cookies.DeleteAllCookies(); 
                Driver.Manage().Window.Maximize();
                //Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5)); // Set implicit wait timeouts to 5 secs
                //Driver.Manage().Timeouts().SetScriptTimeout(new TimeSpan(0, 0, 0, 5));   // Set script timeouts to 5 secs
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public static void GoTo(IWebDriver Driver, string url)
        {
            try
            {
                string rootUrl = baseURL + url;
                Driver.Url = rootUrl;
                ConfigureBrowser(Driver);
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public static Proxy proxy = new OpenQA.Selenium.Proxy();
        public static string LoginTitle = "Login";
        //public static Eyes eyes = new Eyes();
        //public static IWebDriver Desired()
        //{
        //    try
        //    {
        //        DesiredCapabilities capability = DesiredCapabilities.Firefox();
        //        capability.SetCapability(CapabilityType.BrowserName, "firefox");
        //        capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.XP));
        //        capability.SetCapability(CapabilityType.TakesScreenshot, true);
        //        capability.SetCapability(CapabilityType.Version, "42.0");
        //        //capability.SetCapability(CapabilityType.Proxy, "8888");
        //        RemoteWebDriver webDriver = new RemoteWebDriver(new Uri("http://172.18.12.109:5555/wd/hub"), capability);
        //        return webDriver;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //} 
        //public static IWebDriver webDriver = Desired(); 
        //public static void IsLoginPage()
        //{
        //    try
        //    {
        //        if (Browser.IsAt(Browser.Title, Browser.LoginTitle) == false)
        //        {
        //            throw new IllegalLocatorException("Not the LoginPage");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static string MapPath()
        //{
        //    try
        //    {
        //        string path = HostingEnvironment.MapPath("..");
        //        return path;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //        //throw ex;
        //    }
        //} 
        //public static IWebDriver GetWebDriver(string BrowserType)
        //{
        //    try
        //    {
        //        IWebDriver webDriver;
        //        //IWebDriver firingDriver;              
        //        //eyes.ApiKey = "TokoaWZXzhDW109RmvVc5Izbrd6dPnDxTenKlrg104Ni1Gk110";
        //        switch (BrowserType)
        //        {
        //            case "FireFox":
        //                {
        //                    //firingDriver = new EventFiringWebDriver(new FirefoxDriver());
        //                    //firingDriver.ExceptionThrown += firingDriver_TakeScreenshotOnException;
        //                    webDriver = new FirefoxDriver(Profile);
        //                    //webDriver = firingDriver;
        //                    //webDriver = eyes.Open(webDriver, "Login", "Can_Login", new Size(1280, 1024));
        //                    break;
        //                }
        //            case "Chrome":
        //                {
        //                    ChromeOptions chromeOptions = new ChromeOptions();
        //                    chromeOptions.Proxy = proxy;
        //                    //firingDriver = new EventFiringWebDriver(new ChromeDriver());
        //                    //firingDriver.ExceptionThrown += firingDriver_TakeScreenshotOnException;
        //                    webDriver = new ChromeDriver();
        //                    //webDriver = firingDriver;
        //                    //webDriver = eyes.Open(firingDriver, "BgileApp", "BgileAppTest", new Size(1280, 1024));
        //                    break;
        //                }
        //            case "IE":
        //                {
        //                    webDriver = IECapabilities();
        //                    //firingDriver = new EventFiringWebDriver(IECapabilities());
        //                    //firingDriver.ExceptionThrown += firingDriver_TakeScreenshotOnException;
        //                    //webDriver = firingDriver;
        //                    //webDriver = eyes.Open(firingDriver, "BgileApp", "BgileAppTest", new Size(1280, 1024));
        //                    break;
        //                }
        //            case "HtmlUnit":
        //                {
        //                    //firingDriver = new EventFiringWebDriver(new RemoteWebDriver(Desired()));
        //                    //firingDriver.ExceptionThrown += firingDriver_TakeScreenshotOnException;
        //                    webDriver = new RemoteWebDriver(Desired());
        //                    //webDriver = firingDriver;
        //                    //webDriver = eyes.Open(firingDriver, "Login", "Can_Login", new Size(1280, 1024));
        //                    break;
        //                }
        //            default:
        //                {
        //                    Console.WriteLine("App.config key error.");
        //                    Console.WriteLine("Defaulting to Firefox");
        //                    //firingDriver = new EventFiringWebDriver(new FirefoxDriver());
        //                    //firingDriver.ExceptionThrown += firingDriver_TakeScreenshotOnException;
        //                    webDriver = new FirefoxDriver();
        //                    //webDriver = firingDriver;
        //                    //webDriver = eyes.Open(firingDriver, "BgileApp", "BgileAppTest", new Size(1024, 768));
        //                    break;
        //                }
        //        }
        //        return webDriver;
        //    }
        //    catch (Exception ex)
        //    {
        //        //return null;
        //        throw ex;
        //    }
        //}      
        //public static ISearchContext Driver
        //{
        //    get { return webDriver; }
        //}        
        //public static void firingDriver_TakeScreenshotOnException(Object sender, WebDriverExceptionEventArgs e)
        //{
        //    try
        //    {
        //        string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
        //        firingDriver.GetScreenshot().SaveAsFile("Exception-" + timestamp + ".png", ImageFormat.Png);
        //        //var screenshot = ((ITakesScreenshot)webDriver).GetScreenshot();
        //        //screenshot.SaveAsFile("Exception-" + timestamp + ".png", ImageFormat.Png);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static string Title
        //{
        //    get { return webDriver.Title; }
        //}
        //public static void MouseClick(IWebElement Element)
        //{
        //    try
        //    {
        //        Actions Builder = new Actions(webDriver);
        //        Builder.MoveToElement(Element).Click().Build().Perform();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}             
        //public static void ClickOnFade()
        //{
        //    try
        //    {
        //        IWebElement FadeElement = Browser.Driver.FindElement(By.ClassName("fade"));
        //        ClickOnInvisibleElement(FadeElement);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}      
    }
}
