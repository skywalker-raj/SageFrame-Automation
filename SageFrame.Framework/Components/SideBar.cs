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
    #region
    public class ClickSideBar
    {
        public bool PMActive { get; set; }
        public string Page { get; set; }
        public ClickSideBar(bool pmactive, string page)
        {
            PMActive = pmactive;
            Page = page;
        }
    }
    #endregion
    public class SideBar: Page
    {
        protected readonly static string[] LocatorValue = { "Grandparent", "sfLevel1", "sfLevel2", "sidebarExpand", "sidebarCollapse", "sf-with-ul", "ctl14_FinishButton", "hypPreview" };
        private SetElement[] SideBarElements = {
                                                        new SetElement(Locator[1], LocatorValue[0]),
                                                        new SetElement(Locator[1], LocatorValue[1]),
                                                        new SetElement(Locator[1], LocatorValue[2]),
                                                        new SetElement(Locator[1], LocatorValue[3]),
                                                        new SetElement(Locator[1], LocatorValue[4]),
                                                        new SetElement(Locator[1], LocatorValue[5]),
                                                        new SetElement(Locator[0], LocatorValue[6]),
                                                        new SetElement(Locator[0], LocatorValue[7]),
                                                  };
        public SideBar(IWebDriver Driver) : base(Driver) { }
        public void GetElements(string Page)
        {           
            try
            {
                By LevelIILocator = this.SetElement(SideBarElements[2]);
                IList<IWebElement> ListLevelIILink = this.GetAllWhenPresent(LevelIILocator);               
                switch (Page)
                {
                    case "Users":
                    case "Pages":
                    case "SEO":
                    case "SQL":
                    case "System Event StartUp":
                        ListLevelIILink[0].Click();
                        break;
                    case "Roles":
                    case "Menu":
                    case "Localization":
                    case "Lists":
                    case "Modules":
                        ListLevelIILink[1].Click();
                        break;
                    case "Message Templates":
                    case "Templates":
                    case "Scheduler":
                    case "Event Log":
                    case "Module Message":
                        ListLevelIILink[2].Click();
                        break;
                    case "Portal Settings":
                    case "Cache Maintenance":
                    case "Module Maker":
                        ListLevelIILink[3].Click();
                        break;
                    case "Files":
                        ListLevelIILink[4].Click(); 
                        break;
                    case "Links":
                        ListLevelIILink[5].Click(); 
                        break;
                    case "CDN":
                        ListLevelIILink[6].Click(); 
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }            
        }
        public Page ClickSideBar(ClickSideBar ClickSideBar)
        {
            try
            {
                By PortalManagementLocator = this.SetElement(SideBarElements[0]);
                IWebElement PortalManagementLink = this.GetWhenClickable(PortalManagementLocator);
                IWebElement ActiveLink = PortalManagementLink.FindElement(By.TagName("a"));
                switch (ClickSideBar.PMActive)
                {
                    case true:
                        if (ActiveLink.GetAttribute("class") != "active")
                        {
                            ActiveLink.Click();
                            By LevelLocator = this.SetElement(SideBarElements[1]);
                            IList<IWebElement> LevelLink = this.GetAllWhenPresent(LevelLocator);
                            switch (ClickSideBar.Page)
                            {
                                case "Users":
                                case "Roles":
                                case "Message Templates":
                                    LevelLink[0].Click();
                                    GetElements(ClickSideBar.Page);
                                    break;
                                case "Pages":
                                case "Menu":
                                case "Templates":
                                    LevelLink[1].Click();
                                    GetElements(ClickSideBar.Page);
                                    break;
                                case "SEO":
                                case "Localization":
                                case "Scheduler":
                                case "Portal Settings":
                                    LevelLink[2].Click();
                                    GetElements(ClickSideBar.Page);
                                    break;
                                case "SQL":
                                case "Lists":
                                case "Event Log":
                                case "Cache Maintenance":
                                case "Files":
                                case "Links":
                                case "CDN":
                                    LevelLink[3].Click();
                                    GetElements(ClickSideBar.Page);
                                    break;
                                case "System Event StartUp":
                                case "Modules":
                                case "Module Message":
                                case "Module Maker":
                                    LevelLink[4].Click();
                                    GetElements(ClickSideBar.Page);
                                    break;
                                case "Portals":
                                    LevelLink[5].Click();
                                    break;
                                case "Site Analytics":
                                    LevelLink[6].Click();
                                    break;
                            }
                        }
                        break;
                    case false:
                        if (ActiveLink.GetAttribute("class") == "active")
                        {
                            ActiveLink.Click();
                        }
                        break;
                }
                return new Page(Driver);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
