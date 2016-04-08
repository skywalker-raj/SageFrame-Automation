using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using SageFrame.Framework.Page_Objects;
using SageFrame.Framework.Components;
namespace SageFrame.Framework.Page_Objects
{
    #region
    public class TemplateOptions
    {
        public int Templateno { get; set; }
        public string Options { get; set; }
        public string Customize { get; set; }
        public TemplateOptions(int templateno, string options, string customize)
        {
            Templateno = templateno;
            Options = options;
            Customize = customize;
        }
    }
    public class Layout
    {
        public string LayoutName { get; set; }
        public string Operation { get; set; }
        public bool Delete { get; set; }
        public string NewLayoutName { get; set; }
        public string LayoutHolder { get; set; }
        public bool Create { get; set; }
        public Layout(string layoutname, string operation, bool delete, string newlayoutname, string layoutholder, bool create)
        {
            LayoutName = layoutname;
            Operation = operation;
            Delete = delete;
            NewLayoutName = newlayoutname;
            LayoutHolder = layoutholder;
            Create = create;
        }
    }
    public class General
    {
        public bool GeneralI { get; set; }
        public string Layout { get; set; }
        public CSSComponents CssComponents { get; set; }
        public bool RightToLeft { get; set; }
        public string GutterSpace { get; set; }
        public General(bool generalI, string layout, CSSComponents csscomponents, bool righttoleft, string gutterspace)
        {
            GeneralI = generalI;
            Layout = layout;
            CssComponents = csscomponents;
            RightToLeft = righttoleft;
            GutterSpace = gutterspace;
        }
    }
    public class CSSComponents
    {
        public bool Navigation { get; set; }
        public bool Forms { get; set; }
        public bool Tables { get; set; }
        public bool Pagination { get; set; }
        public CSSComponents(bool navigation, bool forms, bool tables, bool pagination)
        {
            Navigation = navigation;
            Forms = forms;
            Tables = tables;
            Pagination = pagination;
        }
    }
    public class Typography
    {
        public bool TypographyI { get; set; }
        public bool GoogleFont { get; set; }
        public string GoogleFontI { get; set; }
        public string HeadingFont { get; set; }
        public string BodyFont { get; set; }
        public string CustomFont { get; set; }
        public string BaseFontSize { get; set; }
        public string BaseLineHeight { get; set; }
        public string H1Size { get; set; }
        public string H2Size { get; set; }
        public string H3Size { get; set; }
        public string H4Size { get; set; }
        public string H5Size { get; set; }
        public string H6Size { get; set; }
        public Typography(bool typographyI, bool googlefont, string googlefontI, string headingfont, string bodyfont, string customfont, string basefontsize, string baselineheight, string h1size, string h2size, string h3size, string h4size, string h5size, string h6size)
        {
            TypographyI = typographyI;
            GoogleFont = googlefont;
            GoogleFontI = googlefontI;
            HeadingFont = headingfont;
            BodyFont = bodyfont;
            CustomFont = customfont;
            BaseFontSize = basefontsize;
            BaseLineHeight = baselineheight;
            H1Size = h1size;
            H2Size = h2size;
            H3Size = h3size;
            H4Size = h4size;
            H5Size = h5size;
            H6Size = h6size;
        }
    }
    public class Images
    {
        public bool ImagesI { get; set; }
        public bool ChangeFavIcon { get; set; }
        public string FavIcon { get; set; }
        public bool ChangeBackgroundImage { get; set; }
        public string BackgroundImage { get; set; }
        public bool ChangePattern { get; set; }
        public string Pattern { get; set; }
        public Images(bool imagesI, bool changefavicon, string favicon, bool changebackgroundimage, string backgroundimage, bool changepattern, string pattern)
        {
            ImagesI = imagesI;
            ChangeFavIcon = changefavicon;
            FavIcon = favicon;
            ChangeBackgroundImage = changebackgroundimage;
            BackgroundImage = backgroundimage;
            ChangePattern = changepattern;
            Pattern = pattern;
        }
    }
    public class Colors
    {
        public bool ColorsI { get; set; }
        public string BodyTextColor { get; set; }
        public string BodyBackgroundColor { get; set; }
        public string LinkTextColor { get; set; }
        public string LinkHoverColor { get; set; }
        public bool UnderlineLinkHover { get; set; }
        public string H1TextColor { get; set; }
        public string H2TextColor { get; set; }
        public string H3TextColor { get; set; }
        public string H4TextColor { get; set; }
        public string H5TextColor { get; set; }
        public string H6TextColor { get; set; }
        public string PrimaryButtonColor { get; set; }
        public string SuccessButtonColor { get; set; }
        public string InfoButtonColor { get; set; }
        public string ErrorButtonColor { get; set; }
        public string WarningButtonColor { get; set; }
        public Colors(bool colorsI, string bodytextcolor, string bodybackgroundcolor, string linktextcolor, string linkhovercolor, bool underlinelinkhover, string h1textcolor, string h2textcolor, string h3textcolor, string h4textcolor, string h5textcolor, string h6textcolor, string primarybuttoncolor, string successbuttoncolor, string infobuttoncolor, string errorbuttoncolor, string warningbuttoncolor)
        {
            ColorsI = colorsI;
            BodyTextColor = bodytextcolor;
            BodyBackgroundColor = bodybackgroundcolor;
            LinkTextColor = linktextcolor;
            LinkHoverColor = linkhovercolor;
            UnderlineLinkHover = underlinelinkhover;
            H1TextColor = h1textcolor;
            H2TextColor = h2textcolor;
            H3TextColor = h3textcolor;
            H4TextColor = h4textcolor;
            H5TextColor = h5textcolor;
            H6TextColor = h6textcolor;
            PrimaryButtonColor = primarybuttoncolor;
            SuccessButtonColor = successbuttoncolor;
            InfoButtonColor = infobuttoncolor;
            ErrorButtonColor = errorbuttoncolor;
            WarningButtonColor = warningbuttoncolor;
        }
    }
    public class Header
    {
        public bool HeaderI { get; set; }
        public bool HeaderSticky { get; set; }
        public bool DisableHeaderSmallScreens { get; set; }
        public bool HeaderTransparent { get; set; }
        public string TransparentValue { get; set; }
        public bool LeftSideHeader { get; set; }
        public Header(bool headerI, bool headersticky, bool disableheadersmallscreens, bool headertransparent, string transparentvalue, bool leftsideheader)
        {
            HeaderI = headerI;
            HeaderSticky = headersticky;
            DisableHeaderSmallScreens = disableheadersmallscreens;
            HeaderTransparent = headertransparent;
            TransparentValue = transparentvalue;
            LeftSideHeader = leftsideheader;
        }
    }
    public class CustomCSS
    {
        public bool CustomCSSI { get; set; }
        public string CustomCssValue { get; set; }
        public CustomCSS(bool customcssI, string customcssvalue)
        {
            CustomCSSI = customcssI;
            CustomCssValue = customcssvalue;
        }
    }
    public class ThemeOptions
    {
        public General General { get; set; }
        public Typography Typography { get; set; }
        public Images Images { get; set; }
        public Colors Colors { get; set; }
        public Header Header { get; set; }
        public CustomCSS CustomCSS { get; set; }
        public bool Reset { get; set; }
        public bool Save { get; set; }
        public ThemeOptions(General general, Typography typography, Images images, Colors colors, Header header, CustomCSS customcss, bool reset, bool save)
        {
            General = general;
            Typography = typography;
            Images = images;
            Colors = colors;
            Header = header;
            CustomCSS = customcss;
            Reset = reset;
            Save = save;
        }
    }
    #endregion
    public class Templates : Page
    {
        public static string TemplateUrl = "Admin/Templates.aspx";
        protected readonly static string[] LocatorValue = { "sfTemplatethumb", "ctl19_fupUploadTemp", "icon-upload", "Create Template", "txtNewTemplate", "btnSaveTemplate", "sfViewDemo", "activate", "sfTemplateCustomize", "sfEditfiles", "sfPages", "templatePreset", "templateLayout", "lnkThemes", "ddlLayoutList", "imgAddLayout", "imgAddModernLayout", "imgEditLayout_Visual", "btnDeleteLayout", "popup_ok", "popup_cancel", "lblCancelEditMode", "lblSaveLayoutChange", "ddlClonebleLayouts", "txtNewLayoutName", ".CodeMirror-lines>div>div>pre", "btnCreateLayout", "InsertCode", "CreateNewTemplate", "cancelTemplateList", "toogleTemplateList", "txtlayoutname", "goBack", "divPropOpen", "createParentContainer", "EmptyParentContainer", "viewDOM", "btnSaveLayout", "btnSaveExitLayout", "btnResetTolast", "divName", "divClass", "divStyle", "divWidth", "saveProperties", "divPropClose", "spnGeneral", "spnTypography", "spnImages", "spnColors", "spnHeader", "spnCustom", "spnReset", "btnSaveThemeOptions", "lblCancelEditMode", "layout", "chkNavigation", "chkForms", "chkTable", "chkPagination", "chkRightToLeft", "txtGutterSpace", "chkGoogleFont", "googleFont", "ddlHeadingFont", "ddlBodyFont", "customFont", "txtBaseFontSize", "txtBaseLineHeight", "txtH1", "txtH2", "txtH3", "txtH4", "txtH5", "txtH6", "favicon", "fullImageBg", "cncBgImage", "customPattern", "txtBodyTextColor", "txtBodyBgColor", "txtLinkTextColor", "txtLinkHoverColor", "textDecoration", "H1color", "H2color", "H3color", "H4color", "H5color", "H6color", "txtPrimarybtncolor", "txtBtnSuccess", "txtBtnInfo", "txtBtnError", "txtBtnWarning", "stickyH", "stickyHmobile", "transHeader", "txtTransparencyValue", "headAtSide", "CodeMirror-lines", "btnReset" };
        private SetElement[] TemplatePageElements = {
                                                        //Templates
                                                        new SetElement(Locator[1], LocatorValue[0]), //Template List
                                                        new SetElement(Locator[0], LocatorValue[1]), //Browse Template
                                                        new SetElement(Locator[1], LocatorValue[2]), //Upload Template
                                                        new SetElement(Locator[2], LocatorValue[3]), //Create Template
                                                        new SetElement(Locator[0], LocatorValue[4]), //New Template Name Text Box
                                                        new SetElement(Locator[0], LocatorValue[5]), //Save Template
                                                        //Template Options
                                                        new SetElement(Locator[1], LocatorValue[6]), //View Demo
                                                        new SetElement(Locator[1], LocatorValue[7]), //Activate
                                                        new SetElement(Locator[1], LocatorValue[8]), //Customize
                                                        new SetElement(Locator[1], LocatorValue[9]), //File Edit
                                                        //Customize Options
                                                        new SetElement(Locator[1], LocatorValue[10]), //Pages
                                                        new SetElement(Locator[1], LocatorValue[11]), //Preset
                                                        new SetElement(Locator[1], LocatorValue[12]), //Layout
                                                        new SetElement(Locator[1], LocatorValue[13]), //Theme Options
                                                        //Layout
                                                        new SetElement(Locator[0], LocatorValue[14]), //Layout DropDown
                                                        new SetElement(Locator[0], LocatorValue[15]), //Create Layout Btn
                                                        new SetElement(Locator[0], LocatorValue[16]), //Create Modern Layout Btn
                                                        new SetElement(Locator[0], LocatorValue[17]), //Edit Layout
                                                        new SetElement(Locator[0], LocatorValue[18]), //Delete Layout
                                                        new SetElement(Locator[0], LocatorValue[19]), //Delete Btn
                                                        new SetElement(Locator[0], LocatorValue[20]), //Cancel Delete Btn
                                                        new SetElement(Locator[0], LocatorValue[21]), //Cancel Btn
                                                        new SetElement(Locator[0], LocatorValue[22]), //Save Btn
                                                        //Create Edit Layout
                                                        new SetElement(Locator[0], LocatorValue[23]), //clone Dropdown
                                                        new SetElement(Locator[0], LocatorValue[24]), //Layout Name TextBox
                                                        new SetElement(Locator[7], LocatorValue[25]), //Layout Text Editor
                                                        new SetElement(Locator[0], LocatorValue[26]), //Save Layout Btn
                                                        //Modern Layout
                                                        new SetElement(Locator[0], LocatorValue[27]), //Insert Code
                                                        new SetElement(Locator[0], LocatorValue[28]), //Blank Template
                                                        new SetElement(Locator[0], LocatorValue[29]), //Close
                                                        new SetElement(Locator[0], LocatorValue[30]), //Toggle View
                                                        new SetElement(Locator[0], LocatorValue[31]), //LayoutName Text Box
                                                        new SetElement(Locator[0], LocatorValue[32]), //Go Back
                                                        new SetElement(Locator[0], LocatorValue[33]), //Properties Div Open
                                                        new SetElement(Locator[0], LocatorValue[34]), //Parent Container
                                                        new SetElement(Locator[0], LocatorValue[35]), //Clear Layout
                                                        new SetElement(Locator[0], LocatorValue[36]), //View DOM
                                                        new SetElement(Locator[0], LocatorValue[37]), //Save Layout
                                                        new SetElement(Locator[0], LocatorValue[38]), //Save and Exit
                                                        new SetElement(Locator[0], LocatorValue[39]), //Reset To Last Saved
                                                        new SetElement(Locator[0], LocatorValue[40]), //Name TextBox
                                                        new SetElement(Locator[0], LocatorValue[41]), //Class TextBox
                                                        new SetElement(Locator[0], LocatorValue[42]), //Style TextBox
                                                        new SetElement(Locator[0], LocatorValue[43]), //Width TextBox
                                                        new SetElement(Locator[0], LocatorValue[44]), //Save Layout
                                                        new SetElement(Locator[0], LocatorValue[45]), //Close Properties
                                                        //ThemeOptions
                                                        new SetElement(Locator[0], LocatorValue[46]), //General Tab
                                                        new SetElement(Locator[0], LocatorValue[47]), //Typhography Tab
                                                        new SetElement(Locator[0], LocatorValue[48]), //Images Tab
                                                        new SetElement(Locator[0], LocatorValue[49]), //Color Tab
                                                        new SetElement(Locator[0], LocatorValue[50]), //Header Tab
                                                        new SetElement(Locator[0], LocatorValue[51]), //CustomCSS Tab
                                                        new SetElement(Locator[0], LocatorValue[52]), //Reset Tab
                                                        new SetElement(Locator[0], LocatorValue[53]), //Save Options
                                                        new SetElement(Locator[0], LocatorValue[54]), //Cancel Options
                                                        //General Tab
                                                        new SetElement(Locator[0], LocatorValue[55]), //Layout DropDown
                                                        new SetElement(Locator[0], LocatorValue[56]), //Navigation CheckBox
                                                        new SetElement(Locator[0], LocatorValue[57]), //Form CheckBox
                                                        new SetElement(Locator[0], LocatorValue[58]), //Tables CheckBox
                                                        new SetElement(Locator[0], LocatorValue[59]), //Pagination CheckBox
                                                        new SetElement(Locator[0], LocatorValue[60]), //Right To Left CheckBox
                                                        new SetElement(Locator[0], LocatorValue[61]), //GutterSpace TextBox
                                                        //Typhography Tab
                                                        new SetElement(Locator[0], LocatorValue[62]), //Google Font CheckBox
                                                        new SetElement(Locator[0], LocatorValue[63]), //Google Font TextBox
                                                        new SetElement(Locator[0], LocatorValue[64]), //Heading Font
                                                        new SetElement(Locator[0], LocatorValue[65]), //Body Font
                                                        new SetElement(Locator[0], LocatorValue[66]), //Custom Font Upload
                                                        new SetElement(Locator[0], LocatorValue[67]), //Base Font Size TextBox
                                                        new SetElement(Locator[0], LocatorValue[68]), //Base Line Height TextBox
                                                        new SetElement(Locator[0], LocatorValue[69]), //H1 Font Size TextBox
                                                        new SetElement(Locator[0], LocatorValue[70]), //H2 Font Size TextBox
                                                        new SetElement(Locator[0], LocatorValue[71]), //H3 Font Size TextBox
                                                        new SetElement(Locator[0], LocatorValue[72]), //H4 Font Size TextBox
                                                        new SetElement(Locator[0], LocatorValue[73]), //H5 Font Size TextBox
                                                        new SetElement(Locator[0], LocatorValue[74]), //H6 Font Size TextBox
                                                        //Images Tab
                                                        new SetElement(Locator[0], LocatorValue[75]), //FavIcon Upload
                                                        new SetElement(Locator[0], LocatorValue[76]), //Background Image Upload
                                                        new SetElement(Locator[0], LocatorValue[77]), //Background Image Cancel
                                                        new SetElement(Locator[0], LocatorValue[78]), //Pattern Upload
                                                        //Colors Tab
                                                        new SetElement(Locator[0], LocatorValue[79]), //Body Text Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[80]), //Body Background Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[81]), //Link Text Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[82]), //Link Hover Text Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[83]), //Underline Link Hover CheckBox
                                                        new SetElement(Locator[0], LocatorValue[84]), //H1 Text Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[85]), //H2 Text Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[86]), //H3 Text Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[87]), //H4 Text Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[88]), //H5 Text Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[89]), //H6 Text Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[90]), //Primary Button Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[91]), //Success Button Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[92]), //Info Button Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[93]), //Error Button Color TextBox
                                                        new SetElement(Locator[0], LocatorValue[94]), //Warning Button Color TextBox
                                                        //Header Tab
                                                        new SetElement(Locator[0], LocatorValue[95]), //Fixed Header Sticky CheckBox
                                                        new SetElement(Locator[0], LocatorValue[96]), //Disable Header Sticky in Small ScreensCheckBox
                                                        new SetElement(Locator[0], LocatorValue[97]), //Make Header Transparent CheckBox
                                                        new SetElement(Locator[0], LocatorValue[98]), //Header Transparency Value TextBox
                                                        new SetElement(Locator[0], LocatorValue[99]), //Enable Header Left Side CheckBox
                                                        //Custom Css
                                                        new SetElement(Locator[1], LocatorValue[100]), //Custom CSS TextBox
                                                        //Reset
                                                        new SetElement(Locator[0], LocatorValue[101]), //Reset Button
                                                };
        public Templates(IWebDriver Driver) : base(Driver) { }
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
        public Page TemplateOptions(TemplateOptions TemplateOptions)
        {
            try
            {
                By TemplateListLocator = this.SetElement(TemplatePageElements[0]);
                IList<IWebElement> TemplateList = Driver.FindElements(TemplateListLocator);
                MouseOperations HoverTemplate = new MouseOperations(TemplateList[TemplateOptions.Templateno], "Hover");
                this.MouseOperations(HoverTemplate);
                switch (TemplateOptions.Options)
                {
                    case "View Demo":
                        By ViewDemoLocator = this.SetElement(TemplatePageElements[6]);
                        this.SetElementValue(ViewDemoLocator, true);
                        break;
                    case "Activate":
                        By ActivateLocator = this.SetElement(TemplatePageElements[7]);
                        this.SetElementValue(ActivateLocator, true);
                        break;
                    case "Customize":
                        By CustomizeLocator = this.SetElement(TemplatePageElements[8]);
                        IWebElement CustomizeBtn = Driver.FindElement(CustomizeLocator);
                        MouseOperations HoverCustomize = new MouseOperations(CustomizeBtn, "Hover");
                        this.MouseOperations(HoverCustomize);
                        switch (TemplateOptions.Customize)
                        {
                            case "Pages":
                                By PagesLocator = this.SetElement(TemplatePageElements[10]);
                                this.SetElementValue(PagesLocator, true); 
                                break;
                            case "Preset":
                                By PresetLocator = this.SetElement(TemplatePageElements[11]);
                                this.SetElementValue(PresetLocator, true); 
                                break;
                            case "Layout Manager":
                                By LayoutMangerLocator = this.SetElement(TemplatePageElements[12]);
                                this.SetElementValue(LayoutMangerLocator, true);
                                break;
                            case "Theme Options":
                                By ThemeOptionsLocator = this.SetElement(TemplatePageElements[13]);
                                this.SetElementValue(ThemeOptionsLocator, true);
                                break;
                        }
                        break;
                    case "Edit Files":
                        By EditFilesLocator = this.SetElement(TemplatePageElements[9]);
                        this.SetElementValue(EditFilesLocator, true); 
                        break;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page Layout(Layout Layout)
        {
            try
            {
                By LayoutDropDownLocator = this.SetElement(TemplatePageElements[14]);
                this.SetElementValue(LayoutDropDownLocator, Layout.LayoutName);
                switch(Layout.Operation)
                {                
                    case "Edit":
                        By EditLayoutBtnLocator = this.SetElement(TemplatePageElements[17]);
                        this.SetElementValue(EditLayoutBtnLocator, true); 
                        break;
                    case "Delete":
                        By DeleteLayoutBtnLocator = this.SetElement(TemplatePageElements[18]);
                        this.SetElementValue(DeleteLayoutBtnLocator, true);
                        switch(Layout.Delete)
                        {
                            case true:
                                By DeleteOkBtnLocator = this.SetElement(TemplatePageElements[19]);
                                this.SetElementValue(DeleteOkBtnLocator, true);
                                break;
                            default:
                                By DeleteCancelBtnLocator = this.SetElement(TemplatePageElements[20]);
                                this.SetElementValue(DeleteCancelBtnLocator, true);
                                break;
                        }
                        break;
                    case "Create":
                        By CreateLayoutBtnLocator = this.SetElement(TemplatePageElements[15]);
                        this.SetElementValue(CreateLayoutBtnLocator, true);
                        By CloneLayoutDropDownLocator = this.SetElement(TemplatePageElements[23]);
                        this.SetElementValue(CloneLayoutDropDownLocator, Layout.LayoutName);
                        By LayoutNameTextBoxLocator = this.SetElement(TemplatePageElements[24]);
                        this.SetElementValue(LayoutNameTextBoxLocator, Layout.NewLayoutName);
                        By LayoutEditorLocator = this.SetElement(TemplatePageElements[25]);
                        IWebElement LayoutEditorText = Driver.FindElement(LayoutEditorLocator);
                        LayoutEditorText.Clear();
                        this.SetElementValue(LayoutEditorLocator, Layout.LayoutHolder);
                        By SaveLayoutBtnLocator = this.SetElement(TemplatePageElements[26]);
                        this.SetElementValue(SaveLayoutBtnLocator, Layout.Create);
                        break;
                    case "Create Modern":
                        By CreateModernLayoutBtnLocator = this.SetElement(TemplatePageElements[16]);
                        this.SetElementValue(CreateModernLayoutBtnLocator, true); 
                        break;
                }        
            }
            catch (Exception)
            {
                throw;
            }
            return new Page(Driver);
        }
        public Page ThemeOptions(ThemeOptions ThemeOptions)
        {
            try
            {
                if (ThemeOptions.General.GeneralI)
                {
                    By GeneralTabLocator = this.SetElement(TemplatePageElements[46]);
                    this.SetElementValue(GeneralTabLocator, true);
                    By LayoutSelectLocator = this.SetElement(TemplatePageElements[55]);
                    this.SetElementValue(LayoutSelectLocator, ThemeOptions.General.Layout);
                    By NavigationCheckBoxLocator = this.SetElement(TemplatePageElements[56]);
                    this.SetElementValue(NavigationCheckBoxLocator, ThemeOptions.General.CssComponents.Navigation);
                    By FormsCheckBoxLocator = this.SetElement(TemplatePageElements[57]);
                    this.SetElementValue(FormsCheckBoxLocator, ThemeOptions.General.CssComponents.Forms);
                    By TablesCheckBoxLocator = this.SetElement(TemplatePageElements[58]);
                    this.SetElementValue(TablesCheckBoxLocator, ThemeOptions.General.CssComponents.Tables);
                    By PaginationCheckBoxLocator = this.SetElement(TemplatePageElements[59]);
                    this.SetElementValue(PaginationCheckBoxLocator, ThemeOptions.General.CssComponents.Pagination);
                    By RightToLeftCheckBoxLocator = this.SetElement(TemplatePageElements[60]);
                    this.SetElementValue(RightToLeftCheckBoxLocator, ThemeOptions.General.RightToLeft);
                    By GutterSpaceTextBoxLocator = this.SetElement(TemplatePageElements[61]);
                    this.SetElementValue(GutterSpaceTextBoxLocator, ThemeOptions.General.GutterSpace); 
                }
                if (ThemeOptions.Typography.TypographyI)
                {
                    By TypographyTabLocator = this.SetElement(TemplatePageElements[47]);
                    this.SetElementValue(TypographyTabLocator, true);
                    By GoogleFontCheckBoxLocator = this.SetElement(TemplatePageElements[62]);
                    this.SetElementValue(GoogleFontCheckBoxLocator, ThemeOptions.Typography.GoogleFont);
                    switch(ThemeOptions.Typography.GoogleFont)
                    {
                        case true:                        
                            By GoogleFontTextBoxLocator = this.SetElement(TemplatePageElements[63]);
                            this.SetElementValue(GoogleFontTextBoxLocator, ThemeOptions.Typography.GoogleFontI);
                            break;
                        default:
                            By CustomFontUploadLocator = this.SetElement(TemplatePageElements[66]);
                            this.SetElementValue(CustomFontUploadLocator, ThemeOptions.Typography.CustomFont);
                            By HeadingFontSelectLocator = this.SetElement(TemplatePageElements[64]);
                            this.SetElementValue(HeadingFontSelectLocator, ThemeOptions.Typography.HeadingFont);
                            By BodyFontSelectLocator = this.SetElement(TemplatePageElements[65]);
                            this.SetElementValue(BodyFontSelectLocator, ThemeOptions.Typography.BodyFont); 
                            break;
                    }
                    By BaseFontSizeTextBoxLocator = this.SetElement(TemplatePageElements[67]);
                    this.SetElementValue(BaseFontSizeTextBoxLocator, ThemeOptions.Typography.BaseFontSize);
                    By BaseLineHeightTextBoxLocator = this.SetElement(TemplatePageElements[68]);
                    this.SetElementValue(BaseLineHeightTextBoxLocator, ThemeOptions.Typography.BaseLineHeight);
                    By H1FontSizeTextBoxLocator = this.SetElement(TemplatePageElements[69]);
                    this.SetElementValue(H1FontSizeTextBoxLocator, ThemeOptions.Typography.H1Size);
                    By H2FontSizeTextBoxLocator = this.SetElement(TemplatePageElements[70]);
                    this.SetElementValue(H2FontSizeTextBoxLocator, ThemeOptions.Typography.H2Size);
                    By H3FontSizeTextBoxLocator = this.SetElement(TemplatePageElements[71]);
                    this.SetElementValue(H3FontSizeTextBoxLocator, ThemeOptions.Typography.H3Size);
                    By H4FontSizeTextBoxLocator = this.SetElement(TemplatePageElements[72]);
                    this.SetElementValue(H4FontSizeTextBoxLocator, ThemeOptions.Typography.H4Size);
                    By H5FontSizeTextBoxLocator = this.SetElement(TemplatePageElements[73]);
                    this.SetElementValue(H5FontSizeTextBoxLocator, ThemeOptions.Typography.H5Size);
                    By H6FontSizeTextBoxLocator = this.SetElement(TemplatePageElements[74]);
                    this.SetElementValue(H6FontSizeTextBoxLocator, ThemeOptions.Typography.H6Size);
                }
                if (ThemeOptions.Images.ImagesI)
                {
                    By ImagesTabLocator = this.SetElement(TemplatePageElements[48]);
                    this.SetElementValue(ImagesTabLocator, true);
                    if(ThemeOptions.Images.ChangeFavIcon)
                    {
                        By FavIconUploadLocator = this.SetElement(TemplatePageElements[75]);
                        this.SetElementValue(FavIconUploadLocator, ThemeOptions.Images.FavIcon);
                    }
                    if (ThemeOptions.Images.ChangeBackgroundImage)
                    {
                        By BackgroundImageUploadLocator = this.SetElement(TemplatePageElements[76]);
                        this.SetElementValue(BackgroundImageUploadLocator, ThemeOptions.Images.BackgroundImage);
                    }
                    if (ThemeOptions.Images.ChangePattern)
                    {
                        By PatternUploadLocator = this.SetElement(TemplatePageElements[78]);
                        this.SetElementValue(PatternUploadLocator, ThemeOptions.Images.Pattern);
                    }
                }
                if (ThemeOptions.Colors.ColorsI)
                {
                    By ColorTabLocator = this.SetElement(TemplatePageElements[49]);
                    this.SetElementValue(ColorTabLocator, true); 
                    By BodyTextColorTextBoxLocator = this.SetElement(TemplatePageElements[79]);
                    this.SetElementValue(BodyTextColorTextBoxLocator, ThemeOptions.Colors.BodyTextColor);
                    By BodyBackgroundColorTextBoxLocator = this.SetElement(TemplatePageElements[80]);
                    this.SetElementValue(BodyBackgroundColorTextBoxLocator, ThemeOptions.Colors.BodyBackgroundColor);
                    By LinkTextColorTextBoxLocator = this.SetElement(TemplatePageElements[81]);
                    this.SetElementValue(LinkTextColorTextBoxLocator, ThemeOptions.Colors.LinkTextColor);
                    By LinkHoverColorTextBoxLocator = this.SetElement(TemplatePageElements[82]);
                    this.SetElementValue(LinkHoverColorTextBoxLocator, ThemeOptions.Colors.LinkHoverColor);
                    By UnderLineLinkHoverCheckBoxLocator = this.SetElement(TemplatePageElements[83]);
                    this.SetElementValue(UnderLineLinkHoverCheckBoxLocator, ThemeOptions.Colors.UnderlineLinkHover);
                    By H1ColorTextBoxLocator = this.SetElement(TemplatePageElements[84]);
                    this.SetElementValue(H1ColorTextBoxLocator, ThemeOptions.Colors.H1TextColor);
                    By H2ColorTextBoxLocator = this.SetElement(TemplatePageElements[85]);
                    this.SetElementValue(H2ColorTextBoxLocator, ThemeOptions.Colors.H2TextColor);
                    By H3ColorTextBoxLocator = this.SetElement(TemplatePageElements[86]);
                    this.SetElementValue(H3ColorTextBoxLocator, ThemeOptions.Colors.H3TextColor);
                    By H4ColorTextBoxLocator = this.SetElement(TemplatePageElements[87]);
                    this.SetElementValue(H4ColorTextBoxLocator, ThemeOptions.Colors.H4TextColor);
                    By H5ColorTextBoxLocator = this.SetElement(TemplatePageElements[88]);
                    this.SetElementValue(H5ColorTextBoxLocator, ThemeOptions.Colors.H5TextColor);
                    By H6ColorTextBoxLocator = this.SetElement(TemplatePageElements[89]);
                    this.SetElementValue(H6ColorTextBoxLocator, ThemeOptions.Colors.H6TextColor);
                    By PrimaryButtonTextBoxLocator = this.SetElement(TemplatePageElements[90]);
                    this.SetElementValue(PrimaryButtonTextBoxLocator, ThemeOptions.Colors.PrimaryButtonColor);
                    By SuccessButtonTextBoxLocator = this.SetElement(TemplatePageElements[91]);
                    this.SetElementValue(SuccessButtonTextBoxLocator, ThemeOptions.Colors.SuccessButtonColor);
                    By InfoButtonTextBoxLocator = this.SetElement(TemplatePageElements[92]);
                    this.SetElementValue(InfoButtonTextBoxLocator, ThemeOptions.Colors.InfoButtonColor);
                    By ErrorButtonTextBoxLocator = this.SetElement(TemplatePageElements[93]);
                    this.SetElementValue(ErrorButtonTextBoxLocator, ThemeOptions.Colors.ErrorButtonColor);
                    By WarningButtonTextBoxLocator = this.SetElement(TemplatePageElements[94]);
                    this.SetElementValue(WarningButtonTextBoxLocator, ThemeOptions.Colors.WarningButtonColor);
                }
                if (ThemeOptions.Header.HeaderI)
                {
                    By HeaderTabLocator = this.SetElement(TemplatePageElements[50]);
                    this.SetElementValue(HeaderTabLocator, true); 
                    By HeaderStickyCheckBoxLocator = this.SetElement(TemplatePageElements[95]);
                    this.SetElementValue(HeaderStickyCheckBoxLocator, ThemeOptions.Header.HeaderSticky);
                    By DisableHeaderStikyCheckBoxLocator = this.SetElement(TemplatePageElements[96]);
                    this.SetElementValue(DisableHeaderStikyCheckBoxLocator, ThemeOptions.Header.DisableHeaderSmallScreens);
                    By TransparentHeaderCheckBoxLocator = this.SetElement(TemplatePageElements[97]);
                    this.SetElementValue(TransparentHeaderCheckBoxLocator, ThemeOptions.Header.HeaderTransparent);
                    if (ThemeOptions.Header.HeaderTransparent)
                    {
                        By HeaderTransparentValueTextBoxLocator = this.SetElement(TemplatePageElements[98]);
                        this.SetElementValue(HeaderTransparentValueTextBoxLocator, ThemeOptions.Header.TransparentValue);
                    }
                    By LeftSideHeaderCheckBoxLocator = this.SetElement(TemplatePageElements[99]);
                    this.SetElementValue(LeftSideHeaderCheckBoxLocator, ThemeOptions.Header.LeftSideHeader); 
                }
                if (ThemeOptions.CustomCSS.CustomCSSI)
                {
                    By CustomCSSTabLocator = this.SetElement(TemplatePageElements[51]);
                    this.SetElementValue(CustomCSSTabLocator, true);
                    By CustomCSSTextBoxLocator = this.SetElement(TemplatePageElements[100]);
                    this.SetElementValue(CustomCSSTextBoxLocator, ThemeOptions.CustomCSS.CustomCssValue); 
                }
                if (ThemeOptions.Reset)
                {
                    By ResetTabLocator = this.SetElement(TemplatePageElements[52]);
                    this.SetElementValue(ResetTabLocator, true);
                    By ResetButtonLocator = this.SetElement(TemplatePageElements[101]);
                    this.SetElementValue(ResetButtonLocator, ThemeOptions.Reset); 
                }
                switch(ThemeOptions.Save)
                {
                    case true:
                        By SaveButtonLocator = this.SetElement(TemplatePageElements[53]);
                        this.SetElementValue(SaveButtonLocator, ThemeOptions.Save);
                        break;
                    default:
                        By CancelButtonLocator = this.SetElement(TemplatePageElements[54]);
                        this.SetElementValue(CancelButtonLocator, ThemeOptions.Save); 
                        break;
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
