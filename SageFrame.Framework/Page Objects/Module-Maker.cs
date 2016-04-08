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
    public class ModuleMaker
    {
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public string ModuleTableName { get; set; }
        public bool IncludeCss { get; set; }
        public bool IncludeJs { get; set; }
        public bool IncludeWebservice { get; set; }
        public bool EditInclude { get; set; }
        public bool SettingInclude { get; set; }
        public string ModuleType { get; set; }
        public bool AutoIncrement { get; set; }
        public string[] ColumnName { get; set; }
        public string[] DataType { get; set; }
        public bool[] AllowNull { get; set; }
        public bool DownloadClassZip { get; set; }
        public bool Back { get; set; }
        public ModuleMaker(string modulename, string moduledescription, string moduletablename, bool includecss, bool includejs, bool includewebservice, bool editinclude, bool settinginclude, string moduletype, bool autoincrement, string[] columnname, string[] datatype, bool[] allownull, bool downloadclasszip, bool back)
        {
            ModuleName = modulename;
            ModuleDescription = moduledescription;
            ModuleTableName = moduletablename;
            IncludeCss = includecss;
            IncludeJs = includejs;
            IncludeWebservice = includewebservice;
            EditInclude = editinclude;
            SettingInclude = settinginclude;
            ModuleType = moduletype;
            AutoIncrement = autoincrement;
            ColumnName = columnname;
            DataType = datatype;
            AllowNull = allownull;
            DownloadClassZip = downloadclasszip;
            Back = back;
        }
    }
    #endregion
    public class Module_Maker : Page
    {
        public static string ModuleMakerUrl = "Admin/Module-Maker.aspx";
        protected readonly static string[] LocatorValue = { "ctl19_txtModuleName", "ctl19_txtModuleDescription", "ctl19_chkCss", "ctl19_chkJS", "ctl19_chkEdit", "ctl19_chkSetting", "sfRadioTab", "ctl19_txtTablename", "AddRow", "autoincrement", "icon-navigate", "chkNull", "ctl19_chkWebService", "btnBack", "btnCreateZipHelp", "btnCreateNewModuleHelp" };
        private SetElement[] ModuleMakerPageElements = {
                                                        new SetElement(Locator[0], LocatorValue[0]),
                                                        new SetElement(Locator[0], LocatorValue[1]),
                                                        new SetElement(Locator[0], LocatorValue[2]),
                                                        new SetElement(Locator[0], LocatorValue[3]),
                                                        new SetElement(Locator[0], LocatorValue[4]),
                                                        new SetElement(Locator[0], LocatorValue[5]),
                                                        new SetElement(Locator[1], LocatorValue[6]),
                                                        new SetElement(Locator[0], LocatorValue[7]),
                                                        new SetElement(Locator[0], LocatorValue[8]),
                                                        new SetElement(Locator[0], LocatorValue[9]),
                                                        new SetElement(Locator[1], LocatorValue[10]),
                                                        new SetElement(Locator[1], LocatorValue[11]),
                                                        new SetElement(Locator[0], LocatorValue[12]),
                                                        new SetElement(Locator[0], LocatorValue[13]),
                                                        new SetElement(Locator[0], LocatorValue[14]),
                                                        new SetElement(Locator[0], LocatorValue[15]),
                                                  };
        public Module_Maker(IWebDriver Driver) : base(Driver) { }
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
        public Page CreateModule(ModuleMaker ModuleMaker)
        {
            try
            {
Start:          By ModuleNameTextBoxLocator = this.SetElement(ModuleMakerPageElements[0]);
                this.SetElementValue(ModuleNameTextBoxLocator, ModuleMaker.ModuleName);
                By ModuleDescriptionTextBoxLocator = this.SetElement(ModuleMakerPageElements[1]);
                this.SetElementValue(ModuleDescriptionTextBoxLocator, ModuleMaker.ModuleDescription);
                By IncludeCssCheckBoxLocator = this.SetElement(ModuleMakerPageElements[2]);
                this.SetElementValue(IncludeCssCheckBoxLocator, ModuleMaker.IncludeCss);
                if (ModuleMaker.IncludeJs)
                {
                    By IncludeJsCheckBoxLocator = this.SetElement(ModuleMakerPageElements[3]);
                    this.SetElementValue(IncludeJsCheckBoxLocator, ModuleMaker.IncludeJs);
                    By IncludeWebServiceCheckBoxLocator = this.SetElement(ModuleMakerPageElements[12]);
                    this.SetElementValue(IncludeWebServiceCheckBoxLocator, ModuleMaker.IncludeWebservice); 
                }
                By IncludeEditCheckBoxLocator = this.SetElement(ModuleMakerPageElements[4]);
                this.SetElementValue(IncludeEditCheckBoxLocator, ModuleMaker.EditInclude);
                By IncludeSettingCheckBoxLocator = this.SetElement(ModuleMakerPageElements[5]);
                this.SetElementValue(IncludeSettingCheckBoxLocator, ModuleMaker.SettingInclude);
                By ModuleTypeLocator = this.SetElement(ModuleMakerPageElements[6]);
                IWebElement ModuleType = Driver.FindElement(ModuleTypeLocator);
                IList<IWebElement> ModuleTypleLabel = ModuleType.FindElements(By.TagName("label")); 
                switch (ModuleMaker.ModuleType)
                {
                    case "Portal":
                        this.SetElementValue(ModuleTypleLabel[0], true);
                        break;     
                    case "Admin":
                        this.SetElementValue(ModuleTypleLabel[1], true);
                        break;                                  
                }
                By ModuleTableNameLocator = this.SetElement(ModuleMakerPageElements[7]);
                this.SetElementValue(ModuleTableNameLocator, ModuleMaker.ModuleTableName);
                By AddColumnLocator = this.SetElement(ModuleMakerPageElements[8]);
                int i = 1;
                foreach (string ColName in ModuleMaker.ColumnName)
                {
                    SetElement ColumnName = new SetElement(Locator[0], "properties__" + i);
                    SetElement DataType = new SetElement(Locator[0], "autocomplete_" + i);
                    By ColumnNameLocator = this.SetElement(ColumnName);
                    this.SetElementValue(ColumnNameLocator, ColName);
                    By DataTypeLocator = this.SetElement(DataType);
                    this.SetElementValue(DataTypeLocator, ModuleMaker.DataType[i - 1]);
                    By CheckNullLocator = this.SetElement(ModuleMakerPageElements[11]);
                    IList<IWebElement> CheckNull = this.GetAllWhenPresent(CheckNullLocator);
                    switch (i - 1)
                    {
                        case 0:
                            {
                                if (ModuleMaker.AutoIncrement)
                                {
                                    By AutoIncrementCheckBoxLocator = this.SetElement(ModuleMakerPageElements[9]);
                                    this.SetElementValue(AutoIncrementCheckBoxLocator, true);
                                }
                                break;
                            }
                        default:
                            {
                                if (ModuleMaker.AllowNull[i - 2])
                                {
                                    this.SetElementValue(CheckNull[i - 1], ModuleMaker.AllowNull[i - 2]);
                                }
                                break;
                            }
                    }
                    if (CheckNull.Count < ModuleMaker.ColumnName.Length)
                    {
                        this.SetElementValue(AddColumnLocator, true);
                    }
                    i++;
                }
                //for (i = 1; i < ModuleMaker.ColumnName.Length + 1; i++ )
                //{
                //    SetElement ColumnName = new SetElement(Locator[0], "properties__" + i);
                //    SetElement DataType = new SetElement(Locator[0], "autocomplete_" + i); 
                //    By ColumnNameLocator = this.SetElement(ColumnName);
                //    this.SetElementValue(ColumnNameLocator, ModuleMaker.ColumnName[i - 1]);
                //    By DataTypeLocator = this.SetElement(DataType);
                //    this.SetElementValue(DataTypeLocator, ModuleMaker.DataType[i - 1]);
                //    By CheckNullLocator = this.SetElement(ModuleMakerPageElements[11]);
                //    IList<IWebElement> CheckNull = this.GetAllWhenPresent(CheckNullLocator);
                //    switch (i-1)
                //    {
                //        case 0:
                //            {
                //                if (ModuleMaker.AutoIncrement)
                //                {
                //                    By AutoIncrementCheckBoxLocator = this.SetElement(ModuleMakerPageElements[9]);
                //                    this.SetElementValue(AutoIncrementCheckBoxLocator, true); 
                //                }
                //                break;
                //            }
                //        default:
                //            {                            
                //                if (ModuleMaker.AllowNull[i - 2])
                //                {                                  
                //                    this.SetElementValue(CheckNull[i - 1], ModuleMaker.AllowNull[i - 2]);
                //                }
                //                break;
                //            }
                //    }
                //    if (CheckNull.Count < ModuleMaker.ColumnName.Length)
                //    {
                //        this.SetElementValue(AddColumnLocator, true);
                //    }
                //}
                By CreateSQLBtnLocator = this.SetElement(ModuleMakerPageElements[10]);
                this.SetElementValue(CreateSQLBtnLocator, true);
                this.ScrollDown(true);
                this.Wait();
                if(ModuleMaker.Back)
                {
                    By BackLocator = this.SetElement(ModuleMakerPageElements[13]);
                    this.SetElementValue(BackLocator, ModuleMaker.Back);
                    ModuleMaker.Back = false;
                    goto Start;
                }
                if (ModuleMaker.DownloadClassZip)
                {
                    By DownloadZipLocator = this.SetElement(ModuleMakerPageElements[14]);
                    this.SetElementValue(DownloadZipLocator, ModuleMaker.DownloadClassZip); 
                };
                By CreateModuleLocator = this.SetElement(ModuleMakerPageElements[15]);
                this.SetElementValue(CreateModuleLocator, true); 
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
    }
}
