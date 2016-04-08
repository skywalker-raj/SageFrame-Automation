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
    public class SQLPageFunction
    {
        public bool ArchiveSession { get; set; }
        public bool BackupDataBase { get; set; }
        public bool CleanUpScript { get; set; }
        public bool UploadFile { get; set; }
        public string FilePath { get; set; }
        public string SqlScript { get; set; }
        public bool RunAsScript { get; set; }
        public SQLPageFunction(bool archivesession, bool backupdatabase, bool cleanupscript, bool uploadfile, string filepath, string sqlscript, bool runasscript)
        {
            ArchiveSession = archivesession;
            BackupDataBase = backupdatabase;
            CleanUpScript = cleanupscript;
            UploadFile = uploadfile;
            FilePath = filepath;
            SqlScript = sqlscript;
            RunAsScript = runasscript;
        }
    }
    #endregion
    public class SQL : Page
    {
        public static string SQLUrl = "Admin/SQL.aspx";
        protected readonly static string[] LocatorValue = { "icon-data", "icon-sql", "ctl19_fluSqlScript", "icon-upload", "ctl19_txtSqlQuery", "ctl19_chkRunAsScript", "icon-execute" };
        private SetElement[] SQLPageElements = {
                                                        new SetElement(Locator[1], LocatorValue[0]), //ArchiveSessionTracker
                                                        new SetElement(Locator[1], LocatorValue[1]), // BackUp and CleanUp
                                                        new SetElement(Locator[0], LocatorValue[2]), // Browse File
                                                        new SetElement(Locator[1], LocatorValue[3]), // Upload
                                                        new SetElement(Locator[0], LocatorValue[4]), // SQLTextBox
                                                        new SetElement(Locator[0], LocatorValue[5]), // Run as Script
                                                        new SetElement(Locator[1], LocatorValue[6]), //Execute
                                                  };
        public SQL(IWebDriver Driver) : base(Driver) { }
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
        public Page SQLOperations(SQLPageFunction SQLPageFunction)
        {
            try
            {
                 if (SQLPageFunction.ArchiveSession)
                {
                    By ArchiveSessionLocator = this.SetElement(SQLPageElements[0]);
                    this.SetElementValue(ArchiveSessionLocator, SQLPageFunction.ArchiveSession); 
                }
                By BackUpDataBaseLocator = this.SetElement(SQLPageElements[1]);
                IList<IWebElement> DataBaseOperations = this.GetAllWhenPresent(BackUpDataBaseLocator); 
                if (SQLPageFunction.BackupDataBase)
                {
                    DataBaseOperations[0].Click();
                }
                if (SQLPageFunction.CleanUpScript)
                {
                    DataBaseOperations[1].Click();
                }
                switch (SQLPageFunction.UploadFile)
                {
                    case true:
                        By BrowseFileLocator = this.SetElement(SQLPageElements[2]);
                        this.SetElementValue(BrowseFileLocator, SQLPageFunction.FilePath);
                        By UploadFileLocator = this.SetElement(SQLPageElements[3]);
                        this.SetElementValue(UploadFileLocator, true);
                        break;
                    default:
                        By SQLQueryTextBoxLocator = this.SetElement(SQLPageElements[4]);
                        this.SetElementValue(SQLQueryTextBoxLocator, SQLPageFunction.SqlScript); 
                        break;
                }
                By RunAsScriptLocator = this.SetElement(SQLPageElements[5]);
                this.SetElementValue(RunAsScriptLocator, SQLPageFunction.RunAsScript);
                By ExecuteLocator = this.SetElement(SQLPageElements[6]);
                this.SetElementValue(ExecuteLocator, true); 
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
    }
}
