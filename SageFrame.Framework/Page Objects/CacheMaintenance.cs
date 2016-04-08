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
    public class CacheSettings
    {
        public bool[] Clear;
        public bool ClearAll;
        public bool SaveAll;
        public bool[] Save;
        public CacheSettings(bool[] clear, bool clearall, bool saveall, bool[] save)
        {
            Clear = clear;
            ClearAll = clearall;
            SaveAll = saveall;
            Save = save;
        }
    }
    #endregion
    public class CacheMaintenance : Page
    {
        public static string CacheMaintenanceUrl = "Admin/Cache-Maintenance.aspx";
        protected static string CacheSaved = "Cache Settings saved successfully.";
        protected static string CacheCleared = "Cache clear successfully";
        protected readonly static string[] LocatorValue = { "chkCheckAllHeavyCache", "chkCheckAll", "btnSave", "btnEnableCache", "chkFrontMenu", "chkSideMenu", "chkFooterMenu", "chk_", "spnMessage" };
        private SetElement[] CacheMaintenancePageElements = {
                                                        new SetElement(Locator[0], LocatorValue[0]),
                                                        new SetElement(Locator[0], LocatorValue[1]),
                                                        new SetElement(Locator[0], LocatorValue[2]),
                                                        new SetElement(Locator[0], LocatorValue[3]),
                                                        new SetElement(Locator[0], LocatorValue[4]),
                                                        new SetElement(Locator[0], LocatorValue[5]),
                                                        new SetElement(Locator[0], LocatorValue[6]),
                                                        new SetElement(Locator[0], LocatorValue[7]),
                                                        new SetElement(Locator[0], LocatorValue[8]),
                                                  };
        public CacheMaintenance(IWebDriver Driver) : base(Driver) { }
        public Login LoginOperation(LoginData logindata)
        {
            try
            {
                Login Login = new Login(Driver);
                Page NewPage = Login.LoginOperation(logindata); 
            }
            catch (Exception)
            {
                throw;
            }
            return new Login(Driver);
        }
        public Page CacheMaintenanceSettings(CacheSettings Cache)
        {
            try
            {
                int i;
                //By MessageLocator = SetElement(CacheMaintenancePageElements[8]);
                //IWebElement MessageLink = Driver.FindElement(MessageLocator);
                By ClearAllCacheLocator = this.SetElement(CacheMaintenancePageElements[1]);
                switch (Cache.ClearAll)
                {
                    case true:                       
                        this.SetElementValue(ClearAllCacheLocator, true);
                        break;
                    default:
                        this.SetElementValue(ClearAllCacheLocator, false);
                        By ClearCacheCheckBoxLocator = this.SetElement(CacheMaintenancePageElements[7]);
                        IList<IWebElement> ClearCacheCheckBoxList = this.GetAllWhenPresent(ClearCacheCheckBoxLocator);
                        for (i = 0; i < ClearCacheCheckBoxList.Count; i++)
                        {
                            this.SetElementValue(ClearCacheCheckBoxList[i], Cache.Clear[i]);
                        }
                        break;
                }
                By ClearCacheBtnLocator = this.SetElement(CacheMaintenancePageElements[2]);
                this.SetElementValue(ClearCacheBtnLocator, true);
                //IsAt CacheClear = new IsAt(MessageLink.Text, CacheCleared);
                //Assert.IsTrue(IsAt(CacheClear));
                By HeavyCacheCheckAllLocator = this.SetElement(CacheMaintenancePageElements[0]);
                switch (Cache.SaveAll)
                {
                    case true:
                        this.SetElementValue(HeavyCacheCheckAllLocator, true);
                        break;
                    default:
                        this.SetElementValue(HeavyCacheCheckAllLocator, false);
                        By FrontMenuCheckBoxLocator = this.SetElement(CacheMaintenancePageElements[4]);
                        By SideMenuCheckBoxLocator = this.SetElement(CacheMaintenancePageElements[5]);
                        By FooterMenuCheckBoxLocator = this.SetElement(CacheMaintenancePageElements[6]);
                        this.SetElementValue(FrontMenuCheckBoxLocator, Cache.Save[0]);
                        this.SetElementValue(SideMenuCheckBoxLocator, Cache.Save[1]);
                        this.SetElementValue(FooterMenuCheckBoxLocator, Cache.Save[2]);
                        break;
                }
                By SaveHeavyCacheBtnLocator = this.SetElement(CacheMaintenancePageElements[3]);
                this.SetElementValue(SaveHeavyCacheBtnLocator, true);
                //IsAt CacheSave = new IsAt(MessageLink.Text, CacheSaved);
                //Assert.IsTrue(IsAt(CacheSave));
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver); 
        }
    }
}
