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
    public class CDNChanges
    {
        public bool AddJs { get; set; }
        public string[] Js { get; set; }
        public bool AddCss { get; set; }
        public string[] Css { get; set; }
        public bool ChangeLinks { get; set; }
        public int LinkNo { get; set; }
        public bool Sort { get; set; }
        public bool Delete { get; set; }
        public bool Edit { get; set; }
        public bool JsEdit { get; set; }
        public bool CssEdit { get; set; }
        public string[] NewJs { get; set; }
        public string[] NewCss { get; set; }
        public bool Up { get; set; }
        public bool ConfirmDelete { get; set; }
        public CDNChanges(bool addjs, string[] js, bool addcss, string[] css, bool changelinks, int linkno, bool sort, bool delete, bool edit, bool jsedit, bool cssedit, string[] newjs, string[] newcss, bool up, bool confirmdelete)
        {
            AddJs = addjs;
            Js = js;
            AddCss = addcss;
            Css = css;
            ChangeLinks = changelinks;
            LinkNo = linkno;
            Sort = sort;
            Delete = delete;
            Edit = edit;
            JsEdit = jsedit;
            CssEdit = cssedit;
            NewJs = newjs;
            NewCss = newcss;
            Up = up;
            ConfirmDelete = confirmdelete;
        }
    }
    #endregion
    public class CDN : Page
    {
        public static string CDNUrl = "Admin/CDN.aspx";
        protected readonly static string[] LocatorValue = { "spnAddJS", "spnAddCSS", "down", "up", "sfDelete", "spnEdit", "spnSave" };
        private SetElement[] CDNPageElements = {
                                                        new SetElement(Locator[0], LocatorValue[0]), //AddJs Button
                                                        new SetElement(Locator[0], LocatorValue[1]), //AddCss Button
                                                        new SetElement(Locator[1], LocatorValue[2]), //OrderDown
                                                        new SetElement(Locator[1], LocatorValue[3]), //OrderUp
                                                        new SetElement(Locator[1], LocatorValue[4]), //DeleteUrl
                                                        new SetElement(Locator[0], LocatorValue[5]), //Edit Button
                                                        new SetElement(Locator[0], LocatorValue[6]), //Save
                                                  };
        public CDN(IWebDriver Driver) : base(Driver) { }
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
        public Page SaveCDN(CDNChanges CDNChanges)
        {
            try
            {
                if (CDNChanges.AddJs)
                {
                    int i = 1;
                    foreach (string JS in CDNChanges.Js)
                    {
                        By AddJsBtnLocator = this.SetElement(CDNPageElements[0]);
                        this.SetElementValue(AddJsBtnLocator, CDNChanges.AddJs);
                        SetElement AddJsTextBoxElement = new SetElement(Locator[0], "jsURL_" + i);
                        By AddJsTextBoxLocator = this.SetElement(AddJsTextBoxElement);
                        this.SetElementValue(AddJsTextBoxLocator, JS);
                        //AddJsBtn.Click();
                        //IWebElement AddJsTextBox = Browser.Driver.FindElement(By.Id("jsURL_" + (i + 1).ToString()));
                        //ClearAndFillTextBox AddJsClearNFill = new ClearAndFillTextBox(AddJsTextBox, JS);
                        //Browser.ClearAndFillTextBox(AddJsClearNFill);
                        i++;
                    }
                }
                if (CDNChanges.AddCss)
                {
                    int j = 1;
                    foreach (string CSS in CDNChanges.Css)
                    {
                        By AddCssBtnLocator = this.SetElement(CDNPageElements[1]);
                        this.SetElementValue(AddCssBtnLocator, CDNChanges.AddCss);
                        SetElement AddCssTextBoxElement = new SetElement(Locator[0], "cssURL_" + j);
                        By AddCssTextBoxLocator = this.SetElement(AddCssTextBoxElement);
                        this.SetElementValue(AddCssTextBoxLocator, CSS);
                        //AddCssBtn.Click();
                        //IWebElement AddCssTextBox = Browser.Driver.FindElement(By.Id("cssURL_" + (j + 1).ToString()));
                        //ClearAndFillTextBox AddCssClearNFill = new ClearAndFillTextBox(AddCssTextBox, css);
                        //Browser.ClearAndFillTextBox(AddCssClearNFill);
                        j++;
                    }
                }
                By SaveBtnLocator = this.SetElement(CDNPageElements[6]);
                this.SetElementValue(SaveBtnLocator, true);
                if (CDNChanges.Edit)
                {
                    By EditCDNBtnLocator = this.SetElement(CDNPageElements[5]);
                    this.SetElementValue(EditCDNBtnLocator, CDNChanges.Edit);
                    if (CDNChanges.JsEdit)
                    {
                        int k = 0;
                        foreach (string JS in CDNChanges.NewJs)
                        {
                            SetElement JsTextBoxElement = new SetElement(Locator[0], "jsURL_" + (k + 2).ToString());
                            By JsTextBoxLocator = this.SetElement(JsTextBoxElement);
                            bool DisplayJSTextBox = this.IsElementVisible(JsTextBoxLocator);
                            switch (DisplayJSTextBox)
                            {
                                case false:
                                    By AddJsBtnLocator = this.SetElement(CDNPageElements[0]);
                                    this.SetElementValue(AddJsBtnLocator, true);
                                    k--;
                                    break;
                                default:
                                    this.SetElementValue(JsTextBoxLocator, JS);
                                    break;
                            }
                            k++;
                        }
                    }
                    if (CDNChanges.CssEdit)
                    {
                        int l = 0;
                        foreach (string NewCSS in CDNChanges.NewCss)
                        {
                            SetElement CssTextBoxElement = new SetElement(Locator[0], "cssURL_" + (CDNChanges.NewJs.Length + CDNChanges.Js.Length + l).ToString());
                            By CssTextBoxLocator = this.SetElement(CssTextBoxElement);
                            IList<IWebElement> CssTextBox = this.GetAllWhenPresent(CssTextBoxLocator); 
                            switch(CssTextBox.Count)
                            {
                                case 0 :
                                    By AddCssBtnLocator = this.SetElement(CDNPageElements[1]);
                                    this.SetElementValue(AddCssBtnLocator, CDNChanges.AddCss);
                                    SetElement CssTxtBoxElement = new SetElement(Locator[0], "cssURL_" + (l + 1).ToString());
                                    By CssTxtBoxLocator = this.SetElement(CssTxtBoxElement);
                                    this.SetElementValue(CssTxtBoxLocator, NewCSS);
                                    break;
                                default:
                                    this.SetElementValue(CssTextBox[0], NewCSS); 
                                    break;
                            }
                        }
                    }
                    this.SetElementValue(SaveBtnLocator, true);
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
