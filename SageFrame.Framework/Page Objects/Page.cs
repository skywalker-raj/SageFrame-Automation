/*
 -----------------------------------------------------------------------------------------------------------------------------------------
 Author: Raj Kumar Thapa
 -----------------------------------------------------------------------------------------------------------------------------------------
 */
using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Net;
using OpenQA.Selenium.Remote;
namespace SageFrame.Framework.Page_Objects
{
    #region
    public class WaitForWebElement
    {
        public IWait<IWebDriver> Wait { get; set; }
        public IWebElement WebElement { get; set; }
        public WaitForWebElement(IWait<IWebDriver> wait, IWebElement webElement)
        {
            Wait = wait;
            WebElement = webElement;
        }
    }
    public class ChkBox
    {
        public bool Check { get; set; }
        public IWebElement CheckBox { get; set; }
        public ChkBox(bool check, IWebElement checkBox)
        {
            Check = check;
            CheckBox = checkBox;
        }
    }
    public class DropDownSelect
    {
        public string Select { get; set; }
        public IWebElement AvailableList { get; set; }
        public DropDownSelect(string select, IWebElement availablelist)
        {
            Select = select;
            AvailableList = availablelist;
        }
    }
    //public class SelectDate
    //{
    //    public DropDownSelect YearDropDownSelect { get; set; }
    //    public DropDownSelect MonthDropDownSelect { get; set; }
    //    public string Day { get; set; }
    //    public SelectDate(DropDownSelect yearDropDownSelect, DropDownSelect monthDropDownSelect, string day)
    //    {
    //        YearDropDownSelect = yearDropDownSelect;
    //        MonthDropDownSelect = monthDropDownSelect;
    //        Day = day;
    //    }
    //}
    public class SelectDate
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
        public SelectDate(int month, int year, int day)
        {
            Month = month;
            Year = year;
            Day = day;
        }
    }
    public class ClearAndFillTextBox
    {
        public IWebElement Element { get; set; }
        public string FillText { get; set; }
        public ClearAndFillTextBox(IWebElement element, string fillText)
        {
            Element = element;
            FillText = fillText;
        }
    }
    public class IsAt
    {
        public string Header { get; set; }
        public string Title { get; set; }
        public IsAt(string header, string title)
        {
            Header = header;
            Title = title;
        }
    }
    public class SaveCancel
    {
        public IWebElement Create { get; set; }
        public IWebElement CancelButton { get; set; }
        public bool Save { get; set; }
        public SaveCancel(IWebElement create, IWebElement cancelbutton, bool save)
        {
            Create = create;
            CancelButton = cancelbutton;
            Save = save;
        }
    }
    public class DBConnection
    {
        public string SqlCmd { get; set; }
        public string Connection { get; set; } //"Server=172.18.29.30;Initial Catalog=Bgile_Dev; uid=bzile_user;pwd=bd@123"
        public DBConnection(string sqlcmd, string connection)
        {
            SqlCmd = sqlcmd;
            Connection = connection;
        }
    }
    public class SetElement
    {
        public string Locator { get; set; }
        public string LocatorValue { get; set; }
        public SetElement(string locator, string locatorvalue)
        {
            Locator = locator;
            LocatorValue = locatorvalue;
        }
    }
    public class MouseOperations
    {
        public IWebElement Element { get; set; }
        public string Action { get; set; }
        public MouseOperations(IWebElement element, string action)
        {
            Element = element;
            Action = action;
        }
    }
    #endregion
    public class Page
    {
        protected IWebDriver Driver;
        protected string PageHandle;
        protected string PageTitle;
        protected int TimeOut = 30;
        protected static string[] Locator = { "Id", "ClassName", "LinkText", "Name", "TagName", "PartialLinkText", "XPath", "CssSelector" };
        private SetElement[] PageElements = {
                                                new SetElement(Locator[1], "ui-datepicker-month"),
                                                new SetElement(Locator[1], "ui-datepicker-year"),
                                            };
        //Constructors
        public Page() { }
        public Page(IWebDriver Driver)
        {
            this.Driver = Driver;
            this.PageHandle = Driver.CurrentWindowHandle;
            this.PageTitle = Driver.Title;
        }
        public Page(IWebDriver Driver, string PagTitle)
        {
            this.Driver = Driver;
            this.PageHandle = Driver.CurrentWindowHandle;
            if (Driver.Title == PagTitle)
            {
                this.PageTitle = PagTitle;
            }
            else
            {
                throw new InvalidElementStateException("Incorrect page loaded: found " + Driver.Title + " expected " + PagTitle);
            }
        }
        public void Initialize(IWebDriver Driver)
        {
            this.Driver = Driver;
            this.PageHandle = Driver.CurrentWindowHandle;
        }
        public int Timeout
        {
            get { return TimeOut; }
            set { TimeOut = value; }
        }
        // My Methods
        public void WaitForAnWebElementDisplayed(WaitForWebElement WaitForWebElement)
        {
            try
            {
                WaitForWebElement.Wait.Until(x => WaitForWebElement.WebElement.Displayed);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void WaitForAnWebElementEnabled(WaitForWebElement WaitForWebElement)
        {
            try
            {
                WaitForWebElement.Wait.Until(x => WaitForWebElement.WebElement.Enabled);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void InjectJs(InjectJs InjectJs)
        {
            try
            {
                String script = "document.getElementsByClassName('" + InjectJs.ClassName + "')." + InjectJs.Attribute + "='" + InjectJs.Value + "';";
                ((IJavaScriptExecutor)Driver).ExecuteScript(script);
            }
            catch (Exception)
            {
                throw;
            }
        }       
        public IWebElement WaitForElement(WaitForElement waitForElement)
        {
            try
            {
                if (waitForElement.timeoutInSeconds > 0)
                {
                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitForElement.timeoutInSeconds));
                    return wait.Until(drv => drv.FindElement(waitForElement.by));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Driver.FindElement(waitForElement.by);
        }
        public void JSExecutor(JSExecutor JSExecutor)
        {
            try
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript(JSExecutor.JS, JSExecutor.Element);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ClickOnInvisibleElement(IWebElement Element)
        {
            try
            {
                JSExecutor JSExecutor1 = new JSExecutor("arguments[0].click();", Element);
                //((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
                JSExecutor(JSExecutor1);
                //((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].hidden = false;", element);
                //element.Click();
                //((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].hidden = true;", element);
                //return element;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int CheckBrokenImages()
        {
            int oklinks = 0;
            int brokenlinks = 0;
            try
            {
                IList<IWebElement> ImageLinks = Driver.FindElements(By.TagName("img"));
                List<string> list = new List<string>();
                foreach (IWebElement Links in ImageLinks)
                {
                    list.Add(Links.GetAttribute("src"));
                }
                foreach (string item in list)
                {
                    HttpWebRequest lxRequest = (HttpWebRequest)WebRequest.Create(item);
                    //String lsResponse = string.Empty;
                    using (HttpWebResponse lxResponse = (HttpWebResponse)lxRequest.GetResponse())
                    {
                        switch (lxResponse.StatusCode)
                        {
                            case HttpStatusCode.OK:
                                {
                                    oklinks++;
                                    break;
                                }
                            default:
                                {
                                    brokenlinks++;
                                    break;
                                }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return brokenlinks;
        }
        public void Wait()
        {
            try
            {
                Driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void SwitchFrames(IWebElement frame)
        {
            try
            {
                Driver.SwitchTo().Frame(frame);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void SwitchToMainWindow()
        {
            try
            {
                Driver.SwitchTo().DefaultContent();
            }
            catch (Exception)
            {
                throw;
            }
        }       
        public void ScrollDown(bool down)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                switch (down)
                {
                    case true:
                        {
                            js.ExecuteScript("scroll(0,600);");
                            break;
                        }
                    default:
                        {
                            js.ExecuteScript("scroll(0,0);");
                            break;
                        }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Is_At(string Title)
        {
            return Driver.Title == Title;
        }       
        public IWebElement GetWhenEnabled(WaitForWebElement WaitForWebElement)
        {
            try
            {
                WaitForWebElement.Wait.Until(x => WaitForWebElement.WebElement.Enabled);                
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return WaitForWebElement.WebElement;
        }
        public By SetElement(SetElement SetElement)
        {
            By Element;
            try
            {
                switch (SetElement.Locator)
                {
                    case "Id":
                        Element = By.Id(SetElement.LocatorValue);
                        break;
                    case "ClassName":
                        Element = By.ClassName(SetElement.LocatorValue);
                        break;
                    case "LinkText":
                        Element = By.LinkText(SetElement.LocatorValue);
                        break;
                    case "Name":
                        Element = By.Name(SetElement.LocatorValue);
                        break;
                    case "TagName":
                        Element = By.TagName(SetElement.LocatorValue);
                        break;
                    case "PartialLinkText":
                        Element = By.PartialLinkText(SetElement.LocatorValue);
                        break;
                    case "XPath":
                        Element = By.XPath(SetElement.LocatorValue);
                        break;
                    case "CssSelector":
                        Element = By.CssSelector(SetElement.LocatorValue);
                        break;
                    default:
                        Element = By.Id(SetElement.LocatorValue);
                        break;
                } 
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return Element;
        }
        public void MouseOperations(MouseOperations MouseOperations)
        {
            try
            {
                Actions Builder = new Actions(Driver);
                switch (MouseOperations.Action)
                {
                    case "Right Click":
                        Builder.ContextClick(MouseOperations.Element).Build().Perform();
                        break;
                    case "Double Click":
                        Builder.DoubleClick(MouseOperations.Element).Build().Perform();
                        break;
                    case "Hover":
                        Builder.MoveToElement(MouseOperations.Element).Build().Perform();
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void ProcessRun(string FilePath)
        {
            Process MyProcess = new Process();
            try
            {
                MyProcess.StartInfo.UseShellExecute = false;
                //string FilePath = @"C:\Users\RajKumar-PC\Documents\Visual Studio 2013\Projects\QASageframe\AutoIt\Download.exe";
                MyProcess.StartInfo.FileName = FilePath;
                MyProcess.StartInfo.CreateNoWindow = true;
                MyProcess.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public bool SwitchToAlert(bool Confirm)
        {
            try
            {
                switch (Confirm)
                {
                    case true:
                        {
                            Driver.SwitchTo().Alert().Accept();
                            break;
                        }
                    default:
                        {
                            Driver.SwitchTo().Alert().Dismiss();
                            break;
                        }
                }
                return true;
            }
            catch (NoAlertPresentException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                return false;
            }
        }
        public void Refresh(IWebElement Element)
        {
            try
            {
                //Element.SendKeys(Keys.F5);
                Driver.Navigate().Refresh();
                //Driver.Navigate().GoToUrl(webDriver.Url);
                //Driver.Url = webDriver.Url;
                //Element.SendKeys("\uE035"); 
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public bool SwitchWindow()
        {
            try
            {
                string BaseWindow = Driver.CurrentWindowHandle;
                ReadOnlyCollection<string> Handles = Driver.WindowHandles;
                if (Handles.Count > 0)
                {
                    try
                    {
                        foreach (string Handle in Handles)
                        {
                            if (Handle != BaseWindow)
                            {
                                Driver.SwitchTo().Window(Handle);
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                        return false;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public void DragAndDrop(DragNDrop DragNDrop)
        {
            try
            {
                Actions Place = new Actions(Driver);
                Place.DragAndDrop(DragNDrop.Source, DragNDrop.Target).Perform();
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public void Input(By Locator, string ElementType, ClearAndFillTextBox ClearNFill, ChkBox BoxCheck, DropDownSelect DropDownSelect)
        {
            try
            {
                IWebElement Field = this.GetWhenPresent(Locator);
                if (Field != null)
                {
                    switch (ElementType)
                    {
                        case "TextBox":
                        case "TextArea":
                        case "Input":
                            ClearAndFillTextBox(ClearNFill);
                            break;
                        case "DatePicker":

                            break;
                        case "CheckBox":
                            CheckBox(BoxCheck);
                            break;
                        case "DropDown":
                        case "List":
                            SelectDropdown(DropDownSelect);
                            break;
                        case "Button":
                        case "Submit":
                        case "Reset":
                        case "Image":
                            Field.Click();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public bool IsAt(IsAt IsAt)
        {
            return IsAt.Header == IsAt.Title;
        }
        public void CheckBox(ChkBox CheckBox)
        {
            try
            {
                switch (CheckBox.Check)
                {
                    case true:
                        {
                            if (!CheckBox.CheckBox.Selected)
                            {
                                CheckBox.CheckBox.Click();
                            }
                            break;
                        }
                    default:
                        {
                            if (CheckBox.CheckBox.Selected)
                            {
                                CheckBox.CheckBox.Click();
                            }
                            break;
                        }
                }
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public void SelectDropdown(DropDownSelect DropDownSelect)
        {
            try
            {
                SelectElement AvailableModuleSelect = new SelectElement(DropDownSelect.AvailableList);
                AvailableModuleSelect.SelectByText(DropDownSelect.Select);
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public void ClearAndFillTextBox(ClearAndFillTextBox ClearNFillTextBox)
        {
            try
            {
                ClearNFillTextBox.Element.Clear();
                ClearNFillTextBox.Element.SendKeys(ClearNFillTextBox.FillText);
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public void SaveCancel(SaveCancel SaveCancel)
        {
            try
            {
                switch (SaveCancel.Save)
                {
                    case true:
                        {
                            switch (SaveCancel.Create.Enabled)
                            {
                                case true:
                                    {
                                        SaveCancel.Create.Click();
                                        break;
                                    }
                                default:
                                    {
                                        //MessageBox.Show("Fill valid Details!");
                                        //Browser.SwitchToAlert(true);
                                        break;
                                    }
                            }
                            break;
                        }
                    default:
                        {
                            SaveCancel.CancelButton.Click();
                            break;
                        }
                }
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public void DateSelect(SelectDate SelectDate)
        {
            try
            {
                //SelectDropdown(SelectDate.YearDropDownSelect);
                //SelectDropdown(SelectDate.MonthDropDownSelect);
                By SetMonthLocator = this.SetElement(PageElements[0]);
                switch (SelectDate.Month)
                {
                    case 1:
                        this.SetElementValue(SetMonthLocator, "Jan");
                        break;
                    case 2:
                        this.SetElementValue(SetMonthLocator, "Feb");
                        break;
                    case 3:
                        this.SetElementValue(SetMonthLocator, "Mar");
                        break;
                    case 4:
                        this.SetElementValue(SetMonthLocator, "Apr");
                        break;
                    case 5:
                        this.SetElementValue(SetMonthLocator, "May");
                        break;
                    case 6:
                        this.SetElementValue(SetMonthLocator, "Jun");
                        break;
                    case 7:
                        this.SetElementValue(SetMonthLocator, "Jul");
                        break;
                    case 8:
                        this.SetElementValue(SetMonthLocator, "Aug");
                        break;
                    case 9:
                        this.SetElementValue(SetMonthLocator, "Sep");
                        break;
                    case 10:
                        this.SetElementValue(SetMonthLocator, "Oct");
                        break;
                    case 11:
                        this.SetElementValue(SetMonthLocator, "Nov");
                        break;
                    case 12:
                        this.SetElementValue(SetMonthLocator, "Dec");
                        break;
                }
                By SetYearLocator = this.SetElement(PageElements[1]);
                this.SetElementValue(SetYearLocator, SelectDate.Year.ToString());
                SetElement SetDayElement = new SetElement("LinkText", SelectDate.Day.ToString());
                By SelectDayLocator = SetElement(SetDayElement);
                this.SetElementValue(SelectDayLocator, true); 
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public string RandomStringGenerator()
        {
            try
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                Random random = new Random();
                string Result = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
                return Result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Confirm(bool Confirm)
        {
            try
            {
                switch (Confirm)
                {
                    case true:
                        {
                            IWebElement DeleteConfirm = Driver.FindElement(By.ClassName("ConfirmYes"));
                            DeleteConfirm.Click();
                            break;
                        }
                    case false:
                        {
                            IWebElement CancelDelete = Driver.FindElement(By.ClassName("ConfirmNo"));
                            CancelDelete.Click();
                            break;
                        }
                }
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public void DatabaseConnection(DBConnection DBConnection)
        {
            try
            {
                SqlCommand Command = new SqlCommand();
                Command.Connection = new SqlConnection(DBConnection.Connection);
                Command.CommandText = DBConnection.SqlCmd;
                Command.Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    //string username = cursor["UserId"].ToString();
                    //string password = cursor["Password"].ToString();
                }
                Reader.Close();
                Reader.Dispose();
                if (Command.Connection != null)
                {
                    Command.Connection.Close();
                    Command.Connection.Dispose();
                }
            }
            catch (SqlException ex)
            {
                string ErrorMessage = "A error occurred while trying to connect to the server.";
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Environment.NewLine;
                ErrorMessage += ex.Message;
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        // Page Class Methods 
        public ReadOnlyCollection<IWebElement> GetAllWhenPresent(By Locator)
        {
            ReadOnlyCollection<IWebElement> FoundElements = null;
            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                FoundElements = Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(Locator));
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return FoundElements;
        }
        public ReadOnlyCollection<IWebElement> GetAllWhenVisible(ReadOnlyCollection<IWebElement> Elements)
        {
            ReadOnlyCollection<IWebElement> FoundElements = null;
            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                FoundElements = Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(Elements));
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return FoundElements;
        }
        public IWebElement GetWhenPresent(By Locator)
        {
            IWebElement FoundElement = null;
            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                FoundElement = Wait.Until(ExpectedConditions.ElementExists(Locator));
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return FoundElement;
        }
        public IWebElement GetWhenVisible(By Locator)
        {
            IWebElement FoundElement = null;
            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                FoundElement = Wait.Until(ExpectedConditions.ElementIsVisible(Locator));
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return FoundElement;
        }
        public IWebElement GetWhenClickable(By Locator)
        {
            IWebElement FoundElement = null;
            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                FoundElement = Wait.Until(ExpectedConditions.ElementToBeClickable(Locator));
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return FoundElement;
        }
        public bool IsTextPresent(By Locator, string Value)
        {
            bool Result = false;
            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                Result = Wait.Until(ExpectedConditions.TextToBePresentInElementLocated(Locator, Value));
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                Result = false;
            }
            return Result;
        }
        public bool IsTextPresentInValue(By Locator, string Value)
        {
            bool Result = false;
            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                Result = Wait.Until(ExpectedConditions.TextToBePresentInElementValue(Locator, Value));
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return Result;
        }
        public bool IsElementVisible(By Locator)
        {
            bool Result = false;
            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                if (Wait.Until(ExpectedConditions.InvisibilityOfElementLocated(Locator)))
                {
                    Result = false;
                }
                else
                {
                    Result = true;
                }
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return Result;
        }
        public bool IsElementAbsent(By Locator)
        {
            bool Result = false;
            try
            {
                IList<IWebElement> FoundElements = Driver.FindElements(Locator);
                if (FoundElements.Count > 0)
                {
                    Result = false;
                }
                else
                {
                    Result = true;
                }
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return Result;
        }
        public bool IsElementPresent(By Locator)
        {
            bool Result = false;

            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                ReadOnlyCollection<IWebElement> FoundElements = Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(Locator));
                if (FoundElements.Count > 0)
                {
                    Result = true;
                }
                else
                {
                    Result = false;
                }
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return Result;
        }
        public bool IsElementEnabled(By Locator)
        {
            bool Result = false;
            try
            {
                IWebElement Element = GetWhenPresent(Locator);
                if (null != Element)
                {
                    Result = Element.Enabled;
                }               
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return Result;
        }
        public bool IsElementStale(IWebElement Element)
        {
            bool Result = false;

            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
                Result = Wait.Until(ExpectedConditions.StalenessOf(Element));
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            return Result;

        }
        public void ClickWhenReady(IWebElement Element)
        {
            WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
            IWebElement FoundElement = Wait.Until(ExpectedConditions.ElementToBeClickable(Element));
            try
            {
                FoundElement.Click();
            }
            catch (StaleElementReferenceException)
            {
                IWebElement Retry = Wait.Until(ExpectedConditions.ElementToBeClickable(Element));
                Retry.Click();
            }
        }
        public bool SetElementValue(IWebElement Field, Object Value)
        {
            bool Success = false;
            try
            {
                if (Field != null)
                {
                    switch (Field.TagName.ToLower().Trim())
                    {
                        case "input":
                            switch (Field.GetAttribute("type").ToLower().Trim())
                            {
                                case "text":
                                case "hidden":
                                case "email":
                                case "number":
                                case "password":
                                    if (!(Field.Text.Equals((string)Value, StringComparison.CurrentCultureIgnoreCase) || (Field.GetAttribute("value").Equals((string)Value, StringComparison.CurrentCultureIgnoreCase))))
                                    {
                                        ClearAndFillTextBox ClearNFill = new ClearAndFillTextBox(Field, (string)Value);
                                        ClearAndFillTextBox(ClearNFill);
                                        //Field.Clear();
                                        //Field.SendKeys((string)Value);
                                        Success = true;
                                    }
                                    break;
                                case "checkbox":
                                    if (Field.Selected != (bool)Value)
                                    {
                                        Field.Click();
                                    }
                                    Success = true;
                                    break;
                                case "radio":
                                case "button":
                                case "submit":
                                case "reset":
                                case "image":
                                    Field.Click();
                                    Success = true;
                                    break;
                                case "file":
                                    Field.SendKeys((string)Value);
                                    Success = true;
                                    break;
                            }
                            break;
                        case "pre":
                            ClearAndFillTextBox ClearNFillBody = new ClearAndFillTextBox(Field, (string)Value);
                            ClearAndFillTextBox(ClearNFillBody);
                            Success = true;
                            break;
                        case "label":
                            Field.Click();
                            Success = true;
                            break;
                        case "a":
                            Field.Click();
                            Success = true;
                            break;
                        case "textarea":
                            ClearAndFillTextBox ClearNFillTextArea = new ClearAndFillTextBox(Field, (string)Value);
                            ClearAndFillTextBox(ClearNFillTextArea);
                            //Field.Clear();
                            //Field.SendKeys((string)Value);
                            Success = true;
                            break;
                        case "select":
                            try
                            {
                                SelectElement DDL = new SelectElement(Field);
                                if (Value.GetType().IsArray)
                                {
                                    if (DDL.IsMultiple)
                                    {
                                        int i;
                                        string[] MultipleValue = (string[])Value;
                                        for (i = 0; i < MultipleValue.Count(); i++)
                                        {
                                            DDL.SelectByText(MultipleValue[i]);
                                            Success = true;
                                        }
                                    }
                                    else
                                    {
                                        Success = false;
                                    }
                                }
                                else
                                {
                                    /* if (System.GetProperty("browserName") == "internet explorer")
                                    {
                                        System.out.println("Using alternate method.");
                                        IWebElement Option = Field.findElement(By.xpath("./option[text() == " + value));
                                        Option.click();
                                    }
                                    else
                                    { */
                                    DDL.SelectByText((string)Value);
                                    Success = true;
                                    //}
                                }
                            }
                            catch (NoSuchElementException)
                            {
                                string holder = (string)Value;
                                if (holder.Equals(""))
                                {
                                    Success = true;
                                }
                                else
                                {
                                    Success = false;
                                }
                            }
                            break;
                        default:
                            Success = false;
                            break;
                    }
                }
                return Success;
            }
            catch (StaleElementReferenceException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                return SetElementValue(Field, Value);
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            catch (Exception)
            {
                Browser.CaptureError(Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public bool SetElementValue(By Locator, Object Value)
        {
            bool Success = false;
            try
            {
                IWebElement Field = this.GetWhenPresent(Locator);
                if (Field != null)
                {
                    switch (Field.TagName.ToLower().Trim())
                    {
                        case "input":
                            switch (Field.GetAttribute("type").ToLower().Trim())
                            {
                                case "text":
                                case "hidden":
                                case "email":
                                case "number":
                                case "password":
                                    if (!(Field.Text.Equals((string)Value, StringComparison.CurrentCultureIgnoreCase) || (Field.GetAttribute("value").Equals((string)Value, StringComparison.CurrentCultureIgnoreCase))))
                                    {
                                        ClearAndFillTextBox ClearNFill = new ClearAndFillTextBox(Field, (string)Value);
                                        ClearAndFillTextBox(ClearNFill);
                                        //Field.Clear();
                                        //Field.SendKeys((string)Value);
                                        Success = true;
                                    }
                                    break;
                                case "checkbox":
                                    if (Field.Selected != (bool)Value)
                                    {
                                        Field.Click();
                                    }
                                    Success = true;
                                    break;
                                case "radio":
                                case "button":
                                case "submit":
                                case "reset":
                                case "image":
                                    Field.Click();
                                    Success = true;
                                    break;
                                case "file":
									Field.SendKeys((string)Value);
                                    Success = true;
                                    break;
                            }
                            break;
                        case "div":
                            ClearAndFillTextBox ClearNFillBody = new ClearAndFillTextBox(Field, (string)Value);
                            ClearAndFillTextBox(ClearNFillBody);
                            Success = true;
                            break;
                        case "li":
                            Field.Click();
                            Success = true;
                            break;
                        case "span":
                            Field.Click();
                            Success = true;
                            break;
                        case "label":
                            Field.Click();
                            Success = true;
                            break;
                        case "a":
                            Field.Click();
                            Success = true;
                            break;
                        case "textarea":
                            ClearAndFillTextBox ClearNFillTextArea = new ClearAndFillTextBox(Field, (string)Value);
                            ClearAndFillTextBox(ClearNFillTextArea);
                            //Field.Clear();
                            //Field.SendKeys((string)Value);
                            Success = true;
                            break;
                        case "select":
                            try
                            {
                                SelectElement DDL = new SelectElement(Field);
                                if (Value.GetType().IsArray)
                                {
                                    if (DDL.IsMultiple)
                                    {
                                        int i;
                                        string[] MultipleValue = (string[])Value;
                                        for (i = 0; i < MultipleValue.Count(); i++)
                                        {
                                            DDL.SelectByText(MultipleValue[i]);
                                            Success = true;
                                        }
                                    }
                                    else
                                    {
                                        Success = false;
                                    }
                                }
                                else
                                {
                                    /* if (System.GetProperty("browserName") == "internet explorer")
                                    {
                                        System.out.println("Using alternate method.");
                                        IWebElement Option = Field.findElement(By.xpath("./option[text() == " + value));
                                        Option.click();
                                    }
                                    else
                                    {*/
                                    DDL.SelectByText((string)Value);
                                    Success = true;
                                    //}
                                }
                            }
                            catch (NoSuchElementException)
                            {
                                string holder = (string)Value;
                                if (holder.Equals(""))
                                {
                                    Success = true;
                                }
                                else
                                {
                                    Success = false;
                                }
                            }
                            break;
                        default:
                            Success = false;
                            break;
                    }
                }
                return Success;
            }
            catch (StaleElementReferenceException)
            {
                Browser.CaptureError(this.Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                return SetElementValue(Locator, Value);
            }
            catch (TimeoutException)
            {
                Browser.CaptureError(this.Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
            catch (Exception)
            {
                Browser.CaptureError(this.Driver, "timeout" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                throw;
            }
        }
        public string PageSource()
        {
            return Driver.PageSource;
        }
        public bool IsPageTitle(string PageTitle)
        {
            bool MatchFound = false;
            try
            {
                MatchFound = (new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout))).Until(ExpectedConditions.TitleContains(PageTitle));               
            }
            catch (TimeoutException)
            {
                try
                {
                    Browser.CaptureError(Driver, "timeOut" + new DateTime().ToString("yyyyMMddhhmm") + ".jpg");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                throw;
            }
            return MatchFound;
        }
        public IAlert GetAlert()
        {
            try
            {
                return Driver.SwitchTo().Alert();
            }
            catch (NoAlertPresentException)
            {
                return null;
            }
        }
        public void SwitchToThisPage()
        {
            Driver.SwitchTo().Window(PageHandle);
        }
        //public bool IsAlertPresent()
        //{
        //    try
        //    {
        //        Driver.SwitchTo().Alert();
        //        return true;
        //    }
        //    catch (NoAlertPresentException)
        //    {
        //        return false;
        //    }
        //}       
    }
}
