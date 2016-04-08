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
using SageFrame.Framework.Components;
namespace SageFrame.Framework.Page_Objects
{
    #region
    public class AddGoogleJs
    {
        public string GoogleJS { get; set; }
        public bool IsActive { get; set; }
        public bool Update { get; set; }
        public bool Refresh { get; set; }
        public AddGoogleJs(string googlejs, bool isactive, bool update, bool refresh)
        {
            GoogleJS = googlejs;
            IsActive = isactive;
            Update = update;
            Refresh = refresh;
        }
    }
    public class GenerateSiteMap
    {
        public double Priority { get; set; }
        public string Frequency { get; set; }
        public bool Google { get; set; }
        public bool Yahoo { get; set; }
        public bool Bing { get; set; }
        public bool Ask { get; set; }
        public GenerateSiteMap(double priority, string frequency, bool google, bool yahoo, bool bing, bool ask)
        {
            Priority = priority;
            Frequency = frequency;
            Google = google;
            Yahoo = yahoo;
            Bing = bing;
            Ask = ask;
        }
    }
    public class GenerateRobots
    {
        public bool Google { get; set; }
        public bool Yahoo { get; set; }
        public bool Bing { get; set; }
        public bool Msn { get; set; }
        public bool[] Pages { get; set; }
        public GenerateRobots(bool google, bool yahoo, bool bing, bool msn, bool[] pages)
        {
            Google = google;
            Yahoo = yahoo;
            Bing = bing;
            Msn = msn;
            Pages = pages;
        }
    }
    #endregion
    public class SEO : Page
    {
        public static string SEOUrl = "Admin/SEO.aspx";
        protected static string SiteMapGenerated = "Sitemap Generated Successfully!";
        protected readonly static string[] LocatorValue = { "__tab_ctl19_TabContainer1_tpGoogleAnalytics", "__tab_ctl19_TabContainer1_tpSitemap", "__tab_ctl19_TabContainer1_tpRobots", "ctl19_TabContainer1_tpGoogleAnalytics_txtvalue", "ctl19_TabContainer1_tpGoogleAnalytics_chkIsActive", "ctl19_TabContainer1_tpSitemap_ddlPriorityValues", "ctl19_TabContainer1_tpSitemap_ddlChangeFrequency", "ctl19_TabContainer1_tpSitemap_chkSubmitSitemap_0", "ctl19_TabContainer1_tpSitemap_chkSubmitSitemap_1", "ctl19_TabContainer1_tpSitemap_chkSubmitSitemap_2", "ctl19_TabContainer1_tpSitemap_chkSubmitSitemap_3", "ctl19_TabContainer1_tpRobots_chkChoice_0", "ctl19_TabContainer1_tpRobots_chkChoice_1", "ctl19_TabContainer1_tpRobots_chkChoice_2", "ctl19_TabContainer1_tpRobots_chkChoice_3", "icon-update", "icon-refresh", "icon-send", "icon-generate",};
        private SetElement[] SEOPageElements = {
                                                        new SetElement(Locator[0], LocatorValue[0]),
                                                        new SetElement(Locator[0], LocatorValue[1]),
                                                        new SetElement(Locator[0], LocatorValue[2]),
                                                        new SetElement(Locator[0], LocatorValue[3]),
                                                        new SetElement(Locator[0], LocatorValue[4]),
                                                        new SetElement(Locator[0], LocatorValue[5]),
                                                        new SetElement(Locator[0], LocatorValue[6]),
                                                        new SetElement(Locator[0], LocatorValue[7]),
                                                        new SetElement(Locator[0], LocatorValue[8]),
                                                        new SetElement(Locator[0], LocatorValue[9]),
                                                        new SetElement(Locator[0], LocatorValue[10]),
                                                        new SetElement(Locator[0], LocatorValue[11]),
                                                        new SetElement(Locator[0], LocatorValue[12]),
                                                        new SetElement(Locator[0], LocatorValue[13]),
                                                        new SetElement(Locator[0], LocatorValue[14]),
                                                        new SetElement(Locator[1], LocatorValue[15]),
                                                        new SetElement(Locator[1], LocatorValue[16]),
                                                        new SetElement(Locator[1], LocatorValue[17]),
                                                        new SetElement(Locator[1], LocatorValue[18]),
                                                  };
        public SEO(IWebDriver Driver) : base(Driver) { }
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
        public Page AddGoogleJS(AddGoogleJs AddGoogleJs)
        {
            try
            {
                By GoogleAnalyticsTabLocator = this.SetElement(SEOPageElements[0]);
                this.SetElementValue(GoogleAnalyticsTabLocator, true);
                By GoogleJsTextBoxLocator = this.SetElement(SEOPageElements[3]);
                this.SetElementValue(GoogleJsTextBoxLocator, AddGoogleJs.GoogleJS);
                By GoogleAnalyticsIsActiveLocator = this.SetElement(SEOPageElements[4]);
                this.SetElementValue(GoogleAnalyticsIsActiveLocator, AddGoogleJs.IsActive);
                if (AddGoogleJs.Update)
                {
                    By UpdateLocator = this.SetElement(SEOPageElements[15]);
                    this.SetElementValue(UpdateLocator, true); 
                }
                if (AddGoogleJs.Refresh)
                {
                    By RefreshLocator = this.SetElement(SEOPageElements[16]);
                    this.SetElementValue(RefreshLocator, true);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page GenerateSiteMap(GenerateSiteMap GenerateSiteMap)
        {
            try
            {
                By GenerateSiteMapTabLocator = this.SetElement(SEOPageElements[1]);
                this.SetElementValue(GenerateSiteMapTabLocator, true);
                By PriorityValuesDropDownLocator = this.SetElement(SEOPageElements[5]);
                this.SetElementValue(PriorityValuesDropDownLocator, GenerateSiteMap.Priority.ToString());
                By FrequencyDropDownLocator = this.SetElement(SEOPageElements[6]);
                this.SetElementValue(FrequencyDropDownLocator, GenerateSiteMap.Frequency);
                By GoogleCheckBoxLocator = this.SetElement(SEOPageElements[7]);
                this.SetElementValue(GoogleCheckBoxLocator, GenerateSiteMap.Google);
                By YahooCheckBoxLocator = this.SetElement(SEOPageElements[8]);
                this.SetElementValue(YahooCheckBoxLocator, GenerateSiteMap.Yahoo);
                By BingCheckBoxLocator = this.SetElement(SEOPageElements[9]);
                this.SetElementValue(BingCheckBoxLocator, GenerateSiteMap.Bing);
                By AskCheckBoxLocator = this.SetElement(SEOPageElements[10]);
                this.SetElementValue(AskCheckBoxLocator, GenerateSiteMap.Ask);
                By SubmitSiteMapLocator = this.SetElement(SEOPageElements[17]);
                this.SetElementValue(SubmitSiteMapLocator, true);
                By GenerateSiteMapLocator = this.SetElement(SEOPageElements[18]);
                IWebElement GenerateSiteMapBtn = Driver.FindElements(GenerateSiteMapLocator)[0];
                this.SetElementValue(GenerateSiteMapBtn, true);
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page GenerateRobots(GenerateRobots GenerateRobots)
        {
            try
            {
                By RobotTabLocator = this.SetElement(SEOPageElements[2]);
                this.SetElementValue(RobotTabLocator, true);
                By GoogleRobotLocator = this.SetElement(SEOPageElements[11]);
                this.SetElementValue(GoogleRobotLocator, GenerateRobots.Google);
                By YahooRobotLocator = this.SetElement(SEOPageElements[12]);
                this.SetElementValue(YahooRobotLocator, GenerateRobots.Yahoo);
                By BingRobotLocator = this.SetElement(SEOPageElements[13]);
                this.SetElementValue(BingRobotLocator, GenerateRobots.Bing);
                By MsnRobotLocator = this.SetElement(SEOPageElements[14]);
                this.SetElementValue(MsnRobotLocator, GenerateRobots.Msn);
                int i = 2;
                foreach (bool Pages in GenerateRobots.Pages)
                {
                    SetElement PagePathNotToCrawl = new SetElement(Locator[0], "ctl19_TabContainer1_tpRobots_gdvRobots_ctl0" + i + "_chkPath");
                    By PagePathNotToCrawlLocator = this.SetElement(PagePathNotToCrawl);
                    this.SetElementValue(PagePathNotToCrawlLocator, Pages);
                    i++;
                }
                By GenerateSiteMapLocator = this.SetElement(SEOPageElements[18]);
                IWebElement GenerateSiteMapBtn = Driver.FindElements(GenerateSiteMapLocator)[1];
                this.SetElementValue(GenerateSiteMapBtn, true);
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
    }
}
