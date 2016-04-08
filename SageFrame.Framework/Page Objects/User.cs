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
using NUnit.Framework;
namespace SageFrame.Framework.Page_Objects
{
    #region
    public class DelUser
    {
        public int N { get; set; }
        public bool ConfirmDel { get; set; }
        public DelUser(int n, bool confirmdel)
        {
            N = n;
            ConfirmDel = confirmdel;
        }
    }
    public class ExportImportUser
    {
        public string Action { get; set; }
        public string Path { get; set; }
        public bool Save { get; set; }
        public ExportImportUser(string action, string path, bool save)
        {
            Action = action;
            Path = path;
            Save = save;
        }
    }
    public class SearchUser
    {
        public string UserRole { get; set; }
        public string Rpp { get; set; }
        public string Search { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string FilterMode { get; set; }
        public SearchUser(string userrole, string rpp, string search, DateTime datefrom, DateTime dateto, string filtermode)
        {
            UserRole = userrole;
            Rpp = rpp;
            Search = search;
            DateFrom = datefrom;
            DateTo = dateto;
            FilterMode = filtermode;
        }
    }
    public class EditUser
    {
        public string rolechange { get; set; }
        public bool UserInformationChange { get; set; }
        public bool RoleChange { get; set; }
        public string UserRole { get; set; }
        public int N { get; set; }
        public string Sex { get; set; }
        public string ResPhone { get; set; }
        public string Mobile { get; set; }
        public string Others { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }
        public DateTime BDate { get; set; }
        public string Location { get; set; }
        public string FullName { get; set; }
        public string[] Email { get; set; }
        public bool PasswordChange { get; set; }
        public string NewPassword { get; set; }
        public string ReTypePassword { get; set; }
        public bool UserProfileChange { get; set; }
        public string ImgPath { get; set; }
        public string AboutMe { get; set; }
        public bool Active { get; set; }
        public EditUser(string roleChange, bool userinformationchange, bool Rolechange, string userrole, int n, string sex, string resphone, string mobile, string others, string fn, string ln, DateTime bdate, string location, string fullname, string[] email, bool passwordchange, string newpassword, string retypepassword, bool userprofilechange, string imgpath, string aboutme, bool active)
        {
            rolechange = roleChange;
            UserInformationChange = userinformationchange;
            RoleChange = Rolechange;
            UserRole = userrole;
            N = n;
            Sex = sex;
            ResPhone = resphone;
            Mobile = mobile;
            Others = others;
            FN = fn;
            LN = ln;
            BDate = bdate;
            Location = location;
            FullName = fullname;
            Email = email;
            PasswordChange = passwordchange;
            NewPassword = newpassword;
            ReTypePassword = retypepassword;
            UserProfileChange = userprofilechange;
            ImgPath = imgpath;
            AboutMe = aboutme;
            Active = active;
        }
    }
    public class AddUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }
        public string ReTypePassword { get; set; }
        public string SQuestion { get; set; }
        public string SAnswer { get; set; }
        public string[] UserRole { get; set; }
        public bool CreateUser { get; set; }
        public AddUser(string username, string email, string fname, string lname, string password, string retypepassword, string squestion, string sanswer, string[] userrole, bool createuser)
        {
            UserName = username;
            Email = email;
            FName = fname;
            LName = lname;
            Password = password;
            ReTypePassword = retypepassword;
            SQuestion = squestion;
            SAnswer = sanswer;
            UserRole = userrole;
            CreateUser = createuser;
        }
    }
    public class UserSetting
    {
        public bool EnableCaptcha { get; set; }
        public bool AllowDuplicateEmail { get; set; }
        public bool Save { get; set; }
        public UserSetting(bool enablecaptcha, bool allowduplicateemail, bool save)
        {
            EnableCaptcha = enablecaptcha;
            AllowDuplicateEmail = allowduplicateemail;
            Save = save;
        }
    }
    public class SuspendedUser
    {
        public int[] N { get; set; }
        public bool[] Block { get; set; }
        public bool Save { get; set; }
        public SuspendedUser(int[] n, bool[] block, bool save)
        {
            N = n;
            Block = block;
            Save = save;
        }
    }
    public class UpdateChanges
    {
        public string Change { get; set; }
        public bool DeleteAll { get; set;}
        public bool[] Delete { get; set; }
        public bool AllStatus { get; set; }
        public bool[] Status { get; set; }
        public bool Confirm { get; set; }
        public UpdateChanges(string change, bool deleteall, bool[] delete, bool allstatus, bool[] status, bool confirm)
        {
            Change = change;
            DeleteAll = deleteall;
            Delete = delete;
            AllStatus = allstatus;
            Status = status;
            Confirm = confirm;
        }
    }
    #endregion
    public class User : Page
    {
        public static string UserUrl = "Admin/Users.aspx";
        protected readonly static string[] LocatorValue = { "ctl19_imgAddUser", "ctl19_txtUserName", "ctl19_txtEmail", "ctl19_txtFirstName", "ctl19_txtLastName", "ctl19_txtPassword", "ctl19_txtRetypePassword", "ctl19_txtSecurityQuestion", "ctl19_txtSecurityAnswer", "ctl19_lstAvailableRoles", "ctl19_imbCreateUser", "ctl19_imbBackinfo", "ctl16_lblUdpSageMesageCustom", "__tab_ctl19_TabContainerManageUser_tabUserInfo", "ctl19_TabContainerManageUser_tabUserInfo_txtManageFirstName", "ctl19_TabContainerManageUser_tabUserInfo_txtManageLastName", "ctl19_TabContainerManageUser_tabUserInfo_txtManageEmail", "ctl19_TabContainerManageUser_tabUserInfo_chkIsActive", "ctl19_TabContainerManageUser_tabUserInfo_imgUserInfoSave", "__tab_ctl19_TabContainerManageUser_tabUserRoles", "ctl19_TabContainerManageUser_tabUserRoles_lstUnselectedRoles", "ctl19_TabContainerManageUser_tabUserRoles_lstSelectedRoles", "icon-arrow-slimdouble-e", "icon-arrow-slim-e", "icon-arrow-slim-w", " icon-arrow-slimdouble-w", "ctl19_TabContainerManageUser_tabUserRoles_imgManageRoleSave", "__tab_ctl19_TabContainerManageUser_tabUserPassword", "ctl19_TabContainerManageUser_tabUserPassword_txtNewPassword", "ctl19_TabContainerManageUser_tabUserPassword_txtRetypeNewPassword", "ctl19_TabContainerManageUser_tabUserPassword_btnManagePasswordSave", "__tab_ctl19_TabContainerManageUser_tabUserProfile", "ctl19_TabContainerManageUser_tabUserProfile_btnEdit", "ctl19_TabContainerManageUser_tabUserProfile_fuImage", "ctl19_TabContainerManageUser_tabUserProfile_txtFName", "ctl19_TabContainerManageUser_tabUserProfile_txtLName", "ctl19_TabContainerManageUser_tabUserProfile_txtFullName", "ctl19_TabContainerManageUser_tabUserProfile_txtBirthDate", "ctl19_TabContainerManageUser_tabUserProfile_rdbGender_0", "ctl19_TabContainerManageUser_tabUserProfile_rdbGender_1", "ctl19_TabContainerManageUser_tabUserProfile_txtLocation", "ctl19_TabContainerManageUser_tabUserProfile_txtAboutYou", "ctl19_TabContainerManageUser_tabUserProfile_txtResPhone", "ctl19_TabContainerManageUser_tabUserProfile_txtMobile", "ctl19_TabContainerManageUser_tabUserProfile_txtOthers", "sfLocale", "ui-button-text-only", "ctl19_ddlSearchRole", "ctl19_txtSearchText", "ctl19_txtFrom", "ctl19_txtTo", "ctl19_ddlRecordsPerPage", "ctl19_rbFilterMode_0", "ctl19_rbFilterMode_1", "ctl19_rbFilterMode_2", "ctl19_imgSearch", "ctl19_imgBtnExportUser", "ctl19_imgBtnImportUser", "ctl19_fuUserImport", "lblImport", "lblCancel", "ctl19_imgBtnSettings", "ctl19_chkEnableDupEmail", "ctl19_chkEnableCaptcha", "ctl19_btnCancel", "ctl19_imgBtnSuspendedIP", "lblSaveChanges", "lblCancelSuspendedUser", "ctl19_imgBtnSaveChanges", "ctl19_imgBtnDeleteSelected", "ui-button-text-only" };
        private SetElement[] UserPageElements = {
                                                    // Add User
                                                        new SetElement(Locator[0], LocatorValue[0]), //Add User
                                                        new SetElement(Locator[0], LocatorValue[1]), //Username TextBox
                                                        new SetElement(Locator[0], LocatorValue[2]), //Email TextBox
                                                        new SetElement(Locator[0], LocatorValue[3]), //FirstName TextBox
                                                        new SetElement(Locator[0], LocatorValue[4]), //LastName TextBox
                                                        new SetElement(Locator[0], LocatorValue[5]), //Password TextBox
                                                        new SetElement(Locator[0], LocatorValue[6]), //ReTypePassword TextBox
                                                        new SetElement(Locator[0], LocatorValue[7]), //SecurityQuestion TextBox
                                                        new SetElement(Locator[0], LocatorValue[8]), //SecurityAnswer TextBox
                                                        new SetElement(Locator[0], LocatorValue[9]), //Roles Selector
                                                        new SetElement(Locator[0], LocatorValue[10]), //Create User Button
                                                        new SetElement(Locator[0], LocatorValue[11]), //Cancel Button
                                                        new SetElement(Locator[0], LocatorValue[12]), //Message
                                                    // Edit User
                                                        // User Info
                                                        new SetElement(Locator[0], LocatorValue[13]), //UserInformation Tab
                                                        new SetElement(Locator[0], LocatorValue[14]), //FirstName TextBox
                                                        new SetElement(Locator[0], LocatorValue[15]), //LastName TextBox
                                                        new SetElement(Locator[0], LocatorValue[16]), //Email TextBox
                                                        new SetElement(Locator[0], LocatorValue[17]), //IsActive CheckBox
                                                        new SetElement(Locator[0], LocatorValue[18]), //Update UserInfo
                                                        // User Roles
                                                        new SetElement(Locator[0], LocatorValue[19]), //UserRole Tab
                                                        new SetElement(Locator[0], LocatorValue[20]), //Unselected Roles
                                                        new SetElement(Locator[0], LocatorValue[21]), //Selected Roles
                                                        new SetElement(Locator[1], LocatorValue[22]), //Select All
                                                        new SetElement(Locator[1], LocatorValue[23]), //Select
                                                        new SetElement(Locator[1], LocatorValue[24]), //Unselect
                                                        new SetElement(Locator[1], LocatorValue[25]), //Unselect All
                                                        new SetElement(Locator[0], LocatorValue[26]), //Update UserRole
                                                        // Change Password
                                                        new SetElement(Locator[0], LocatorValue[27]), //UserPassword Tab
                                                        new SetElement(Locator[0], LocatorValue[28]), //New Password
                                                        new SetElement(Locator[0], LocatorValue[29]), //Retype Password
                                                        new SetElement(Locator[0], LocatorValue[30]), //Save Password
                                                        // User Profile
                                                        new SetElement(Locator[0], LocatorValue[31]), //UserPrfile Tab
                                                        new SetElement(Locator[0], LocatorValue[32]), //Edit
                                                        new SetElement(Locator[0], LocatorValue[33]), //Browse Image
                                                        new SetElement(Locator[0], LocatorValue[34]), //FirstName TextBox
                                                        new SetElement(Locator[0], LocatorValue[35]), //LastName TextBox
                                                        new SetElement(Locator[0], LocatorValue[36]), //FullName TextBox
                                                        new SetElement(Locator[0], LocatorValue[37]), //BirthDate Picker
                                                        new SetElement(Locator[0], LocatorValue[38]), //Male Radio Button
                                                        new SetElement(Locator[0], LocatorValue[39]), //Female Radio Button
                                                        new SetElement(Locator[0], LocatorValue[40]), //Location TextBox
                                                        new SetElement(Locator[0], LocatorValue[41]), //AboutYou TextArea
                                                        new SetElement(Locator[0], LocatorValue[42]), //Res.Phone TextBox
                                                        new SetElement(Locator[0], LocatorValue[43]), //Mobile TextBox
                                                        new SetElement(Locator[0], LocatorValue[44]), //Others TextBox
                                                        new SetElement(Locator[1], LocatorValue[45]), //Save Profile
                                                        // Del User
                                                        new SetElement(Locator[1], LocatorValue[46]), //Del YesNo Btn
                                                        // Search User
                                                        new SetElement(Locator[0], LocatorValue[47]), //User Role DropDown
                                                        new SetElement(Locator[0], LocatorValue[48]), //Search TextBox
                                                        new SetElement(Locator[0], LocatorValue[49]), //DateFrom TextBox
                                                        new SetElement(Locator[0], LocatorValue[50]), //DateTo TextBox
                                                        new SetElement(Locator[0], LocatorValue[51]), //RecordsPerPage DropDown
                                                        new SetElement(Locator[0], LocatorValue[52]), //All Radio
                                                        new SetElement(Locator[0], LocatorValue[53]), //Approved Radio
                                                        new SetElement(Locator[0], LocatorValue[54]), //UnApproved Radio
                                                        new SetElement(Locator[0], LocatorValue[55]), //Search Btn
                                                        // Export Import User
                                                        new SetElement(Locator[0], LocatorValue[56]), //Export Users
                                                        new SetElement(Locator[0], LocatorValue[57]), //Import Users
                                                        new SetElement(Locator[0], LocatorValue[58]), //Browse File
                                                        new SetElement(Locator[0], LocatorValue[59]), //Save Import
                                                        new SetElement(Locator[0], LocatorValue[60]), //Cancel
                                                        // User Setting
                                                        new SetElement(Locator[0], LocatorValue[61]), //User Setting Btn
                                                        new SetElement(Locator[0], LocatorValue[62]), //Allow Duplicate Email CheckBox
                                                        new SetElement(Locator[0], LocatorValue[63]), //Enable Captcha For Registration CheckBox
                                                        new SetElement(Locator[0], LocatorValue[64]), //Cancel User Setting Btn
                                                        // Suspended User
                                                        new SetElement(Locator[0], LocatorValue[65]), //Suspended User Btn
                                                        new SetElement(Locator[0], LocatorValue[66]), //Save Suspended User Settings
                                                        new SetElement(Locator[0], LocatorValue[67]), //Cancel Suspend User Settings
                                                        // Update Changes
                                                        new SetElement(Locator[0], LocatorValue[68]), //Update Changes Btn
                                                        new SetElement(Locator[0], LocatorValue[69]), //Delete Selected Btn
                                                        new SetElement(Locator[1], LocatorValue[70]), //Confirm
                                                  };
        public User(IWebDriver Driver) : base(Driver) { }
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
        public Page AddUser(AddUser AddUser)
        {
            try
            {
                By AddUserBtnLocator = this.SetElement(UserPageElements[0]);
                this.SetElementValue(AddUserBtnLocator, true);
                By UserNameTextBoxLocator = this.SetElement(UserPageElements[1]);
                this.SetElementValue(UserNameTextBoxLocator, AddUser.UserName);
                By EmailTextBoxLocator = this.SetElement(UserPageElements[2]);
                this.SetElementValue(EmailTextBoxLocator, AddUser.Email);
                By FirstNameTextBoxLocator = this.SetElement(UserPageElements[3]);
                this.SetElementValue(FirstNameTextBoxLocator, AddUser.FName);
                By LastNameTextBoxLocator = this.SetElement(UserPageElements[4]);
                this.SetElementValue(LastNameTextBoxLocator, AddUser.LName);
                By PasswordTextBoxLocator = this.SetElement(UserPageElements[5]);
                this.SetElementValue(PasswordTextBoxLocator, AddUser.Password);
                By RetypePasswordTextBoxLocator = this.SetElement(UserPageElements[6]);
                this.SetElementValue(RetypePasswordTextBoxLocator, AddUser.ReTypePassword);
                By SecurityQuestionTextBoxLocator = this.SetElement(UserPageElements[7]);
                this.SetElementValue(SecurityQuestionTextBoxLocator, AddUser.SQuestion);
                By SecurityAnswerTextBoxLocator = this.SetElement(UserPageElements[8]);
                this.SetElementValue(SecurityAnswerTextBoxLocator, AddUser.SAnswer);
                By RoleSelectLocator = this.SetElement(UserPageElements[9]);
                this.SetElementValue(RoleSelectLocator, AddUser.UserRole);
                switch (AddUser.CreateUser)
                {
                    case true:
                        By CreateUserBtnLocator = this.SetElement(UserPageElements[10]);
                        this.SetElementValue(CreateUserBtnLocator, AddUser.CreateUser);
                        By MessageLocator = this.SetElement(UserPageElements[12]);
                        IWebElement MessageLink = Driver.FindElement(MessageLocator);
                        IsAt UserCreated = new IsAt(MessageLink.Text, "User has been created successfully.");
                        Assert.IsTrue(IsAt(UserCreated));
                        break;
                    default:
                        By CancelBtnLocator = this.SetElement(UserPageElements[11]);
                        this.SetElementValue(CancelBtnLocator, true);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new User(Driver);
        }
        public Page EditUser(EditUser EditUser)
        {
            try
            {
                SetElement UserEditSetElement = new SetElement(Locator[0], "ctl19_gdvUser_ctl0" + (EditUser.N + 1) + "_imgEdit");
                By UserEditLocator = this.SetElement(UserEditSetElement);
                this.SetElementValue(UserEditLocator, true);
                if (EditUser.UserInformationChange)
                {
                    By UserInformationTabLocator = this.SetElement(UserPageElements[13]);
                    this.SetElementValue(UserInformationTabLocator, EditUser.UserInformationChange);
                    By FirstNameTextBoxLocator = this.SetElement(UserPageElements[14]);
                    this.SetElementValue(FirstNameTextBoxLocator, EditUser.FN);
                    By LastNameTextBoxLocator = this.SetElement(UserPageElements[15]);
                    this.SetElementValue(LastNameTextBoxLocator, EditUser.LN);
                    By EmailTextBoxLocator = this.SetElement(UserPageElements[16]);
                    this.SetElementValue(EmailTextBoxLocator, EditUser.Email[0]);
                    By IsActiveCheckBoxLocator = this.SetElement(UserPageElements[17]);
                    this.SetElementValue(IsActiveCheckBoxLocator, EditUser.Active);
                    By UpdateBtnLocator = this.SetElement(UserPageElements[18]);
                    this.SetElementValue(UpdateBtnLocator, true); 
                }
                if (EditUser.RoleChange)
                {
                    By UserRoleTabLocator = this.SetElement(UserPageElements[19]);
                    this.SetElementValue(UserRoleTabLocator, EditUser.RoleChange);
                    switch(EditUser.rolechange)
                    {
                        case "Select":
                            By UnselectedRoleSelect = this.SetElement(UserPageElements[20]);
                            this.SetElementValue(UnselectedRoleSelect, EditUser.UserRole);
                            By SelectRoleLink = this.SetElement(UserPageElements[23]);
                            this.SetElementValue(SelectRoleLink, true); 
                            break;
                        case "Unselect":
                            By SelectedRoleUnselect = this.SetElement(UserPageElements[21]);
                            this.SetElementValue(SelectedRoleUnselect, EditUser.UserRole);
                            By UnselectRoleLink = this.SetElement(UserPageElements[24]);
                            this.SetElementValue(UnselectRoleLink, true); 
                            break;
                        case "Select All":
                            By SelectAllLocator = this.SetElement(UserPageElements[22]);
                            this.SetElementValue(SelectAllLocator, true);
                            break;
                        case "Unselect All":
                            By UnselectAllLocator = this.SetElement(UserPageElements[25]);
                            this.SetElementValue(UnselectAllLocator, true);
                            break;
                    }
                    By UpdateUserRoleBtn = this.SetElement(UserPageElements[26]);
                    this.SetElementValue(UpdateUserRoleBtn, EditUser.RoleChange);
                }
                if (EditUser.PasswordChange)
                {
                    By PasswordChangeTabLocator = this.SetElement(UserPageElements[27]);
                    this.SetElementValue(PasswordChangeTabLocator, EditUser.PasswordChange);
                    By NewPasswordTextBoxLocator = this.SetElement(UserPageElements[28]);
                    this.SetElementValue(NewPasswordTextBoxLocator, EditUser.NewPassword);
                    By RetypePasswordTextBoxLocator = this.SetElement(UserPageElements[29]);
                    this.SetElementValue(RetypePasswordTextBoxLocator, EditUser.ReTypePassword);
                    By SavePasswordBtnLocator = this.SetElement(UserPageElements[30]);
                    this.SetElementValue(SavePasswordBtnLocator, EditUser.PasswordChange); 
                }
                if (EditUser.UserProfileChange)
                {
                    By UserProfileTabLocator = this.SetElement(UserPageElements[31]);
                    this.SetElementValue(UserProfileTabLocator, EditUser.UserProfileChange);
                    By EditProfileBtnLocator = this.SetElement(UserPageElements[32]);
                    this.SetElementValue(EditProfileBtnLocator, true);
                    By BrowserImageLocator = this.SetElement(UserPageElements[33]);
                    this.SetElementValue(BrowserImageLocator, EditUser.ImgPath);
                    By FirstNameTextBoxLocator = this.SetElement(UserPageElements[34]);
                    this.SetElementValue(FirstNameTextBoxLocator, EditUser.FN);
                    By LastNameTextBoxLocator = this.SetElement(UserPageElements[35]);
                    this.SetElementValue(LastNameTextBoxLocator, EditUser.LN);
                    By FullNameTextBoxLocator = this.SetElement(UserPageElements[36]);
                    this.SetElementValue(FullNameTextBoxLocator, EditUser.FullName);
                    By BirthDateLocator = this.SetElement(UserPageElements[37]);
                    IWebElement BirthDateTextBox = Driver.FindElement(BirthDateLocator);
                    BirthDateTextBox.Click();
                    int Month = EditUser.BDate.Month;
                    int Year = EditUser.BDate.Year;
                    int Day = EditUser.BDate.Day;
                    SelectDate BirthDate = new SelectDate(Month, Year, Day);
                    this.DateSelect(BirthDate);
                    //this.SetElementValue(BirthDateLocator, EditUser.BDate);
                    switch(EditUser.Sex)
                    {
                        case "Male":
                            By MaleRadioLocator = this.SetElement(UserPageElements[38]);
                            this.SetElementValue(MaleRadioLocator, true); 
                            break;
                        case "Female":
                            By FemaleRadioLocator = this.SetElement(UserPageElements[39]);
                            this.SetElementValue(FemaleRadioLocator, true);
                            break;
                    }
                    By LocationTextBoxLocator = this.SetElement(UserPageElements[40]);
                    this.SetElementValue(LocationTextBoxLocator, EditUser.Location);
                    By AboutYouTextBoxLocator = this.SetElement(UserPageElements[41]);
                    this.SetElementValue(AboutYouTextBoxLocator, EditUser.AboutMe);
                    int i = 1;
                    foreach(string Email in EditUser.Email)
                    {
                        SetElement EmailElement = new SetElement(Locator[0], "ctl19_TabContainerManageUser_tabUserProfile_txtEmail" + i);
                        By EmailLocator = this.SetElement(EmailElement);
                        this.SetElementValue(EmailLocator, Email);
                        i++;
                    }
                    By ResPhoneTextBoxLocator = this.SetElement(UserPageElements[42]);
                    this.SetElementValue(ResPhoneTextBoxLocator, EditUser.ResPhone);
                    By MobileTextBoxLocator = this.SetElement(UserPageElements[43]);
                    this.SetElementValue(MobileTextBoxLocator, EditUser.Mobile);
                    By OthersTextBoxLocator = this.SetElement(UserPageElements[44]);
                    this.SetElementValue(OthersTextBoxLocator, EditUser.Others);
                    By SaveUserProfileBtnLocator = this.SetElement(UserPageElements[45]);
                    this.SetElementValue(SaveUserProfileBtnLocator, true); 
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page DelUser(DelUser DelUser)
        {
            try
            {
                SetElement DelUserElement = new SetElement(Locator[0], "ctl19_gdvUser_ctl0" + (DelUser.N + 2) + "_imgDelete");
                By DelUserLocator = this.SetElement(DelUserElement);
                this.SetElementValue(DelUserLocator, true);
                By ConfirmBtnLocator = this.SetElement(UserPageElements[46]);
                IList<IWebElement> ConfirmBtn = Driver.FindElements(ConfirmBtnLocator);
                switch (DelUser.ConfirmDel)
                {
                    case true:
                        this.SetElementValue(ConfirmBtn[0], true);
                        break;
                    case false:
                        this.SetElementValue(ConfirmBtn[1], true);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page SearchUser(SearchUser SearchUser)
        {
            try
            {
                By RoleDropDownLocator = this.SetElement(UserPageElements[47]);
                this.SetElementValue(RoleDropDownLocator, SearchUser.UserRole);
                By RecordsPerPageDropDown = this.SetElement(UserPageElements[51]);
                this.SetElementValue(RecordsPerPageDropDown, SearchUser.Rpp);
                switch(SearchUser.FilterMode)
                {
                    case "Approved":
                        By ApprovedRadioLocator = this.SetElement(UserPageElements[53]);
                        this.SetElementValue(ApprovedRadioLocator, true); 
                        break;
                    case "Unapproved":
                        By UnApprovedRadioLocator = this.SetElement(UserPageElements[54]);
                        this.SetElementValue(UnApprovedRadioLocator, true); 
                        break;
                    default:
                        By AllRadioLocator = this.SetElement(UserPageElements[52]);
                        this.SetElementValue(AllRadioLocator, true);
                        break;
                }
                By SearchTextBoxLocator = this.SetElement(UserPageElements[48]);
                this.SetElementValue(SearchTextBoxLocator, SearchUser.Search); 
                By DateFromTextBoxLocator = this.SetElement(UserPageElements[49]);
                int DateFromMonth = SearchUser.DateFrom.Month;
                int DateFromYear = SearchUser.DateFrom.Year;
                int DateFromDay = SearchUser.DateFrom.Day;
                SelectDate DateFrom = new SelectDate(DateFromMonth, DateFromYear, DateFromDay);
                IWebElement DateFromTextBox = Driver.FindElement(DateFromTextBoxLocator);
                DateFromTextBox.Click(); 
                this.DateSelect(DateFrom);
                By DateToTextBoxLocator = this.SetElement(UserPageElements[50]);
                int DateToMonth = SearchUser.DateTo.Month;
                int DateToYear = SearchUser.DateTo.Year;
                int DateToDay = SearchUser.DateTo.Day;
                SelectDate DateTo = new SelectDate(DateToMonth, DateToYear, DateToDay);
                IWebElement DateToTextBox = Driver.FindElement(DateToTextBoxLocator);
                DateToTextBox.Click();
                this.DateSelect(DateTo);
                By SearchBtnLocator = this.SetElement(UserPageElements[55]);
                this.SetElementValue(SearchBtnLocator, true);
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page ExportImportUser(ExportImportUser ExportImportUser)
        {
            try
            {
                switch(ExportImportUser.Action)
                {
                    case "Export":
                        By ExportBtnLocator = this.SetElement(UserPageElements[56]);
                        this.SetElementValue(ExportBtnLocator, true); 
                        break;
                    case "Import":
                        By ImportBtnLocator = this.SetElement(UserPageElements[57]);
                        this.SetElementValue(ImportBtnLocator, true);
                        By BrowseUserImportFileLocator = this.SetElement(UserPageElements[58]);
                        this.SetElementValue(BrowseUserImportFileLocator, ExportImportUser.Path);
                        switch(ExportImportUser.Save)
                        {
                            case true:
                                By SaveBtnLocator = this.SetElement(UserPageElements[59]);
                                this.SetElementValue(SaveBtnLocator, true); 
                                break;
                            default:
                                By CancelBtnLocator = this.SetElement(UserPageElements[60]);
                                this.SetElementValue(CancelBtnLocator, true); 
                                break;
                        }
                        break;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page UserSetting(UserSetting UserSetting)
        {
            try
            {
                By UserSettingBtnLocator = this.SetElement(UserPageElements[61]);
                this.SetElementValue(UserSettingBtnLocator, true);
                By AllowDuplicateEmailCheckBoxLocator = this.SetElement(UserPageElements[62]);
                this.SetElementValue(AllowDuplicateEmailCheckBoxLocator, UserSetting.AllowDuplicateEmail);
                By EnableCaptchaCheckBoxLocator = this.SetElement(UserPageElements[63]);
                this.SetElementValue(EnableCaptchaCheckBoxLocator, UserSetting.EnableCaptcha);
                switch(UserSetting.Save)
                {
                    case true:
                        By SaveBtnLocator = this.SetElement(UserPageElements[45]);
                        this.SetElementValue(SaveBtnLocator, true); 
                        break;
                    default:
                        By CancelBtnLocator = this.SetElement(UserPageElements[64]);
                        this.SetElementValue(CancelBtnLocator, true); 
                        break;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page SuspendedUserSetting(SuspendedUser SuspendedUser)
        {
            try
            {
                By SuspendedUserBtnLocator = this.SetElement(UserPageElements[65]);
                this.SetElementValue(SuspendedUserBtnLocator, true);
                int i = 0;
                foreach(int N in SuspendedUser.N)
                {
                    SetElement SuspendedUserCheckBoxElement = new SetElement(Locator[0], "ctl19_gdvSuspendedIP_ctl0" + N + "_chkBoxIsSuspendedItem");
                    By SuspendeUserCheckBoxLocator = this.SetElement(SuspendedUserCheckBoxElement);
                    this.SetElementValue(SuspendeUserCheckBoxLocator, SuspendedUser.Block[i]);
                    i++;
                }
                switch (SuspendedUser.Save)
                {
                    case true:
                        By SaveBtnLocator = this.SetElement(UserPageElements[66]);
                        this.SetElementValue(SaveBtnLocator, true); 
                        break;
                    default:
                        By CancelBtnLocator = this.SetElement(UserPageElements[67]);
                        this.SetElementValue(CancelBtnLocator, true); 
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page UpdateChanges(UpdateChanges UpdateChanges)
        {
            try
            {
                switch (UpdateChanges.Change)
                {
                    case "Status":
                        switch (UpdateChanges.AllStatus)
                        {
                            case true:
                                SetElement AllUsersStatus = new SetElement(Locator[0], "ctl19_gdvUser_ctl01_chkBoxIsActiveHeader");
                                By AllUsersStatusCheckBoxLocator = this.SetElement(AllUsersStatus);
                                this.SetElementValue(AllUsersStatusCheckBoxLocator, true);
                                break;
                            default:
                                int i = 3;
                                foreach (bool Status in UpdateChanges.Status)
                                {
                                    SetElement UserStatus = new SetElement(Locator[0], "ctl19_gdvUser_ctl0" + i + "_chkBoxIsActiveItem");
                                    By UserStatusCheckBoxLocator = this.SetElement(UserStatus);
                                    this.SetElementValue(UserStatusCheckBoxLocator, Status); 
                                    i++;
                                }
                                break;
                        }
                        By UpdateChangesBtnLocator = this.SetElement(UserPageElements[68]);
                        this.SetElementValue(UpdateChangesBtnLocator, true);
                        break;
                    case "Delete":
                        switch (UpdateChanges.DeleteAll)
                        {
                            case true:
                                SetElement AllUsersDelete = new SetElement(Locator[0], "ctl19_gdvUser_ctl01_chkBoxHeader");
                                By AllUsersCheckBoxLocator = this.SetElement(AllUsersDelete);
                                this.SetElementValue(AllUsersCheckBoxLocator, true); 
                                break;
                            default:
                                int i = 3;
                                foreach (bool Delete in UpdateChanges.Delete)
                                {
                                    SetElement UsersDelete = new SetElement(Locator[0], "ctl19_gdvUser_ctl0" + i + "_chkBoxItem");
                                    By UserCheckBoxLocator = this.SetElement(UsersDelete);
                                    this.SetElementValue(UserCheckBoxLocator, Delete);
                                    i++;
                                }
                                break;
                        }
                        By DeleteSelectedBtnLocator = this.SetElement(UserPageElements[69]);
                        this.SetElementValue(DeleteSelectedBtnLocator, true);
                        break;
                }
                By ConfirmLocator = this.SetElement(UserPageElements[70]);
                IList<IWebElement> ConfirmBtn = this.GetAllWhenPresent(ConfirmLocator); 
                switch (UpdateChanges.Confirm)
                {
                    case true:
                        this.SetElementValue(ConfirmBtn[0], true); 
                        break;
                    default:
                        this.SetElementValue(ConfirmBtn[1], true); 
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
    }
}
