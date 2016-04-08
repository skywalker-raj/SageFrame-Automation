using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using SageFrame.Framework.Page_Objects;
using SageFrame.Framework.Components;
namespace SageFrame.Framework.Page_Objects
{
    #region
    public class AddEventStartUp
    {
        public string ControlUrl { get; set; }
        public string EventLocation { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsControlUrl { get; set; }
        public bool IsActive { get; set; }
        public bool Confirm { get; set; }
        public AddEventStartUp(string controlurl, string eventlocation, bool isadmin, bool iscontrolurl, bool isactive, bool confirm)
        {
            ControlUrl = controlurl;
            EventLocation = eventlocation;
            IsAdmin = isadmin;
            IsControlUrl = iscontrolurl;
            IsActive = isactive;
            Confirm = confirm;
        }
    }
    public class EventListManagement
    {
        public int[] EventNo { get; set; }
        public string[] Action { get; set; }
        public AddEventStartUp[] AddEventStartUp { get; set; }
        public bool[] Delete { get; set; }
        public EventListManagement(int[] eventno, string[] action, AddEventStartUp[] addeventstartup, bool[] delete)
        {
            EventNo = eventno;
            Action = action;
            AddEventStartUp = addeventstartup;
            Delete = delete;
        }
    }
    #endregion
    public class System_Event_Startup : Page
    {
        public static string SystemEventStartupUrl = "Admin/System-Event-StartUp.aspx";
        protected readonly static string[] LocatorValue = { "ctl19_lblAddNew", "ctl19_ddlControlUrl", "ctl19_ddlEventLocation", "ctl19_chkIsAdmin", "ctl19_chkIsControlUrl", "ctl19_chkIsActive", "ctl19_lblSave", "ctl19_lblCancel" };
        private SetElement[] SystemEventStartUpPageElements = {
                                                                    // Add New Event
                                                       new SetElement(Locator[0], LocatorValue[0]), //Add System Event StartUp Button
                                                       new SetElement(Locator[0], LocatorValue[1]), //Control Url DropDown
                                                       new SetElement(Locator[0], LocatorValue[2]), //Event Location
                                                       new SetElement(Locator[0], LocatorValue[3]), //IsAdmin CheckBox
                                                       new SetElement(Locator[0], LocatorValue[4]), //IsControl CheckBox
                                                       new SetElement(Locator[0], LocatorValue[5]), //IsActive CheckBox
                                                       new SetElement(Locator[0], LocatorValue[6]), //Save Button
                                                       new SetElement(Locator[0], LocatorValue[7]), //Cancel Button
                                                };
        public System_Event_Startup(IWebDriver Driver) : base(Driver) { } 
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
        public Page Add_Event_Startup(AddEventStartUp AddEventStartUp)
        {
            try
            {
                By AddSystemEventStartUpBtn = this.SetElement(SystemEventStartUpPageElements[0]);
                if (this.IsElementVisible(AddSystemEventStartUpBtn))
                {
                    this.SetElementValue(AddSystemEventStartUpBtn, true); 
                }
                By ControlUrlDropDownLocator = this.SetElement(SystemEventStartUpPageElements[1]);
                this.SetElementValue(ControlUrlDropDownLocator, AddEventStartUp.ControlUrl);
                By EventLocationDropDownLocator = this.SetElement(SystemEventStartUpPageElements[2]);
                this.SetElementValue(EventLocationDropDownLocator, AddEventStartUp.EventLocation);
                By IsAdminCheckBoxLocator = this.SetElement(SystemEventStartUpPageElements[3]);
                this.SetElementValue(IsAdminCheckBoxLocator, AddEventStartUp.IsAdmin);
                By IsControlUrlCheckBoxLocator = this.SetElement(SystemEventStartUpPageElements[4]);
                this.SetElementValue(IsControlUrlCheckBoxLocator, AddEventStartUp.IsControlUrl );
                By IsActiveCheckBoxLocator = this.SetElement(SystemEventStartUpPageElements[5]);
                this.SetElementValue(IsActiveCheckBoxLocator, AddEventStartUp.IsActive);
                switch(AddEventStartUp.Confirm)
                {
                    case true:
                        By SaveButtonLocator = this.SetElement(SystemEventStartUpPageElements[6]);
                        this.SetElementValue(SaveButtonLocator, true); 
                        break;
                    default:
                        By CancelButtonLocator = this.SetElement(SystemEventStartUpPageElements[7]);
                        this.SetElementValue(CancelButtonLocator, true); 
                        break;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page EventListManagement(EventListManagement EventListManagement)
        {
            try
            {
                int i = 0;
                foreach(string Action in EventListManagement.Action)
                {
                    switch(Action)
                    {
                        case "Edit":
                            SetElement EditEvent = new SetElement(Locator[0], "ctl19_grdList_ctl0" + (EventListManagement.EventNo[i] + 1) + "_imbEdit");
                            By EditEventLocator = this.SetElement(EditEvent);
                            this.SetElementValue(EditEventLocator, true);
                            this.Add_Event_Startup(EventListManagement.AddEventStartUp[i]);
                            break;
                        case "Delete":
                            SetElement DeleteEvent = new SetElement(Locator[0], "ctl19_grdList_ctl0" + (EventListManagement.EventNo[i] + 1) + "_imbDelete");
                            By DeleteEventLocator = this.SetElement(DeleteEvent);
                            this.SetElementValue(DeleteEventLocator, true);
                            IList<IWebElement> DeleteButtonList = this.Driver.FindElements(By.TagName("button"));
                            switch (EventListManagement.Delete[i])
                            {
                                case true:
                                    DeleteButtonList[1].Click();
                                    break;
                                default:
                                    DeleteButtonList[2].Click();
                                    break;
                            }
                            break;
                    }
                    i++;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
    }
}
