﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// addNewCar - Use 'addNewCarParams' to pass parameters into this method.
        /// </summary>
        public void addNewCar()
        {
            #region Variable Declarations
            HtmlHyperlink uIPojazdyHyperlink = this.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument.UIBsexamplenavbarcollaPane.UIPojazdyHyperlink;
            HtmlHyperlink uICreateNewHyperlink = this.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument1.UICreateNewHyperlink;
            HtmlEdit uIModelEdit = this.UIIndexMyASPNETApplicaWindow.UICreateMyASPNETApplicDocument.UIModelEdit;
            HtmlEdit uIRokprodukcjiEdit = this.UIIndexMyASPNETApplicaWindow.UICreateMyASPNETApplicDocument.UIRokprodukcjiEdit;
            HtmlEdit uIVinEdit = this.UIIndexMyASPNETApplicaWindow.UICreateMyASPNETApplicDocument.UIVinEdit;
            HtmlInputButton uICreateButton = this.UIIndexMyASPNETApplicaWindow.UICreateMyASPNETApplicDocument.UICreateButton;
            #endregion

            // Click 'Pojazdy' link
            Mouse.Click(uIPojazdyHyperlink, new Point(44, 32));

            // Click 'Create New' link
            Mouse.Click(uICreateNewHyperlink, new Point(56, 6));

            // Type 'Bmw' in 'Model' text box
            uIModelEdit.Text = this.addNewCarParams.UIModelEditText;

            // Type '{Tab}' in 'Model' text box
            Keyboard.SendKeys(uIModelEdit, this.addNewCarParams.UIModelEditSendKeys, ModifierKeys.None);

            // Type '2016' in 'Rok produkcji' text box
            uIRokprodukcjiEdit.Text = this.addNewCarParams.UIRokprodukcjiEditText;

            // Type 'znxmskndut' in 'Vin' text box
            uIVinEdit.Text = this.addNewCarParams.UIVinEditText;

            // Click 'Create' button
            Mouse.Click(uICreateButton, new Point(36, 15));
        }
        
        /// <summary>
        /// assertAddCar - Use 'assertAddCarExpectedValues' to pass parameters into this method.
        /// </summary>
        public void assertAddCar()
        {
            #region Variable Declarations
            HtmlInputButton uICreateButton = this.UIIndexMyASPNETApplicaWindow.UICreateMyASPNETApplicDocument.UICreateButton;
            #endregion

            // Verify that the 'Type' property of 'Create' button equals 'submit'
            Assert.AreEqual(this.assertAddCarExpectedValues.UICreateButtonType, uICreateButton.Type, "blad");
        }
        
        /// <summary>
        /// addCar2 - Use 'addCar2Params' to pass parameters into this method.
        /// </summary>
        public void addCar2()
        {
            #region Variable Declarations
            HtmlHyperlink uIPojazdyHyperlink = this.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument.UIBsexamplenavbarcollaPane.UIPojazdyHyperlink;
            HtmlDiv uIIndexCreateNewNameMoPane = this.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument1.UIIndexCreateNewNameMoPane;
            HtmlHyperlink uICreateNewHyperlink = this.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument1.UICreateNewHyperlink;
            HtmlEdit uIModelEdit = this.UIIndexMyASPNETApplicaWindow.UICreateMyASPNETApplicDocument.UIModelEdit;
            HtmlEdit uIRokprodukcjiEdit = this.UIIndexMyASPNETApplicaWindow.UICreateMyASPNETApplicDocument.UIRokprodukcjiEdit;
            HtmlEdit uIVinEdit = this.UIIndexMyASPNETApplicaWindow.UICreateMyASPNETApplicDocument.UIVinEdit;
            HtmlInputButton uICreateButton = this.UIIndexMyASPNETApplicaWindow.UICreateMyASPNETApplicDocument.UICreateButton;
            #endregion

            // Click 'Pojazdy' link
            Mouse.Click(uIPojazdyHyperlink, new Point(48, 34));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'Index Create New Name Model' pane at (1, 1)
            Mouse.Hover(uIIndexCreateNewNameMoPane, new Point(1, 1));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Create New' link
            Mouse.Click(uICreateNewHyperlink, new Point(14, 5));

            // Type 'opel' in 'Model' text box
            uIModelEdit.Text = this.addCar2Params.UIModelEditText;

            // Type '{Tab}' in 'Model' text box
            Keyboard.SendKeys(uIModelEdit, this.addCar2Params.UIModelEditSendKeys, ModifierKeys.None);

            // Type '2008' in 'Rok produkcji' text box
            uIRokprodukcjiEdit.Text = this.addCar2Params.UIRokprodukcjiEditText;

            // Type '{Tab}' in 'Rok produkcji' text box
            Keyboard.SendKeys(uIRokprodukcjiEdit, this.addCar2Params.UIRokprodukcjiEditSendKeys, ModifierKeys.None);

            // Type 'bndmioksndhg' in 'Vin' text box
            uIVinEdit.Text = this.addCar2Params.UIVinEditText;

            // Click 'Create' button
            Mouse.Click(uICreateButton, new Point(38, 24));
        }
        
        /// <summary>
        /// assertAddCar2 - Use 'assertAddCar2ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void assertAddCar2()
        {
            #region Variable Declarations
            HtmlHyperlink uICreateNewHyperlink = this.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument1.UICreateNewHyperlink;
            #endregion

            // Verify that the 'InnerText' property of 'Create New' link equals 'Create New'
            Assert.AreEqual(this.assertAddCar2ExpectedValues.UICreateNewHyperlinkInnerText, uICreateNewHyperlink.InnerText);
        }
        
        #region Properties
        public virtual addNewCarParams addNewCarParams
        {
            get
            {
                if ((this.maddNewCarParams == null))
                {
                    this.maddNewCarParams = new addNewCarParams();
                }
                return this.maddNewCarParams;
            }
        }
        
        public virtual assertAddCarExpectedValues assertAddCarExpectedValues
        {
            get
            {
                if ((this.massertAddCarExpectedValues == null))
                {
                    this.massertAddCarExpectedValues = new assertAddCarExpectedValues();
                }
                return this.massertAddCarExpectedValues;
            }
        }
        
        public virtual addCar2Params addCar2Params
        {
            get
            {
                if ((this.maddCar2Params == null))
                {
                    this.maddCar2Params = new addCar2Params();
                }
                return this.maddCar2Params;
            }
        }
        
        public virtual assertAddCar2ExpectedValues assertAddCar2ExpectedValues
        {
            get
            {
                if ((this.massertAddCar2ExpectedValues == null))
                {
                    this.massertAddCar2ExpectedValues = new assertAddCar2ExpectedValues();
                }
                return this.massertAddCar2ExpectedValues;
            }
        }
        
        public UIIndexMyASPNETApplicaWindow UIIndexMyASPNETApplicaWindow
        {
            get
            {
                if ((this.mUIIndexMyASPNETApplicaWindow == null))
                {
                    this.mUIIndexMyASPNETApplicaWindow = new UIIndexMyASPNETApplicaWindow();
                }
                return this.mUIIndexMyASPNETApplicaWindow;
            }
        }
        #endregion
        
        #region Fields
        private addNewCarParams maddNewCarParams;
        
        private assertAddCarExpectedValues massertAddCarExpectedValues;
        
        private addCar2Params maddCar2Params;
        
        private assertAddCar2ExpectedValues massertAddCar2ExpectedValues;
        
        private UIIndexMyASPNETApplicaWindow mUIIndexMyASPNETApplicaWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'addNewCar'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class addNewCarParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Bmw' in 'Model' text box
        /// </summary>
        public string UIModelEditText = "Bmw";
        
        /// <summary>
        /// Type '{Tab}' in 'Model' text box
        /// </summary>
        public string UIModelEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '2016' in 'Rok produkcji' text box
        /// </summary>
        public string UIRokprodukcjiEditText = "2016";
        
        /// <summary>
        /// Type 'znxmskndut' in 'Vin' text box
        /// </summary>
        public string UIVinEditText = "znxmskndut";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'assertAddCar'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class assertAddCarExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Type' property of 'Create' button equals 'submit'
        /// </summary>
        public string UICreateButtonType = "submit";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'addCar2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class addCar2Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'opel' in 'Model' text box
        /// </summary>
        public string UIModelEditText = "opel";
        
        /// <summary>
        /// Type '{Tab}' in 'Model' text box
        /// </summary>
        public string UIModelEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '2008' in 'Rok produkcji' text box
        /// </summary>
        public string UIRokprodukcjiEditText = "2008";
        
        /// <summary>
        /// Type '{Tab}' in 'Rok produkcji' text box
        /// </summary>
        public string UIRokprodukcjiEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type 'bndmioksndhg' in 'Vin' text box
        /// </summary>
        public string UIVinEditText = "bndmioksndhg";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'assertAddCar2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class assertAddCar2ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Create New' link equals 'Create New'
        /// </summary>
        public string UICreateNewHyperlinkInnerText = "Create New";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIIndexMyASPNETApplicaWindow : BrowserWindow
    {
        
        public UIIndexMyASPNETApplicaWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Index - My ASP.NET Application";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Index - My ASP.NET Application");
            this.WindowTitles.Add("Create - My ASP.NET Application");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIIndexMyASPNETApplicaDocument UIIndexMyASPNETApplicaDocument
        {
            get
            {
                if ((this.mUIIndexMyASPNETApplicaDocument == null))
                {
                    this.mUIIndexMyASPNETApplicaDocument = new UIIndexMyASPNETApplicaDocument(this);
                }
                return this.mUIIndexMyASPNETApplicaDocument;
            }
        }
        
        public UIIndexMyASPNETApplicaDocument1 UIIndexMyASPNETApplicaDocument1
        {
            get
            {
                if ((this.mUIIndexMyASPNETApplicaDocument1 == null))
                {
                    this.mUIIndexMyASPNETApplicaDocument1 = new UIIndexMyASPNETApplicaDocument1(this);
                }
                return this.mUIIndexMyASPNETApplicaDocument1;
            }
        }
        
        public UICreateMyASPNETApplicDocument UICreateMyASPNETApplicDocument
        {
            get
            {
                if ((this.mUICreateMyASPNETApplicDocument == null))
                {
                    this.mUICreateMyASPNETApplicDocument = new UICreateMyASPNETApplicDocument(this);
                }
                return this.mUICreateMyASPNETApplicDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIIndexMyASPNETApplicaDocument mUIIndexMyASPNETApplicaDocument;
        
        private UIIndexMyASPNETApplicaDocument1 mUIIndexMyASPNETApplicaDocument1;
        
        private UICreateMyASPNETApplicDocument mUICreateMyASPNETApplicDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIIndexMyASPNETApplicaDocument : HtmlDocument
    {
        
        public UIIndexMyASPNETApplicaDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Index - My ASP.NET Application";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:2120/";
            this.WindowTitles.Add("Index - My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public UIBsexamplenavbarcollaPane UIBsexamplenavbarcollaPane
        {
            get
            {
                if ((this.mUIBsexamplenavbarcollaPane == null))
                {
                    this.mUIBsexamplenavbarcollaPane = new UIBsexamplenavbarcollaPane(this);
                }
                return this.mUIBsexamplenavbarcollaPane;
            }
        }
        #endregion
        
        #region Fields
        private UIBsexamplenavbarcollaPane mUIBsexamplenavbarcollaPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIBsexamplenavbarcollaPane : HtmlDiv
    {
        
        public UIBsexamplenavbarcollaPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "bs-example-navbar-collapse-2";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Logowanie\r\n\r\n\r\nRejestracja\r\n\r\n\r\nHome\r\n\r\n";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "collapse navbar-collapse";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"collapse navbar-collapse\" id=\"bs-example-navbar-collapse-2\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "4";
            this.WindowTitles.Add("Index - My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIPojazdyHyperlink
        {
            get
            {
                if ((this.mUIPojazdyHyperlink == null))
                {
                    this.mUIPojazdyHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIPojazdyHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIPojazdyHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIPojazdyHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIPojazdyHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Pojazdy";
                    this.mUIPojazdyHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Cars";
                    this.mUIPojazdyHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIPojazdyHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:2120/Cars";
                    this.mUIPojazdyHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIPojazdyHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Cars\"";
                    this.mUIPojazdyHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "9";
                    this.mUIPojazdyHyperlink.WindowTitles.Add("Index - My ASP.NET Application");
                    #endregion
                }
                return this.mUIPojazdyHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIPojazdyHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIIndexMyASPNETApplicaDocument1 : HtmlDocument
    {
        
        public UIIndexMyASPNETApplicaDocument1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Index - My ASP.NET Application";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Cars";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:2120/Cars";
            this.WindowTitles.Add("Index - My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UICreateNewHyperlink
        {
            get
            {
                if ((this.mUICreateNewHyperlink == null))
                {
                    this.mUICreateNewHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICreateNewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUICreateNewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUICreateNewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUICreateNewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Create New";
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Cars/Create";
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:2120/Cars/Create";
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Cars/Create\"";
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "12";
                    this.mUICreateNewHyperlink.WindowTitles.Add("Index - My ASP.NET Application");
                    #endregion
                }
                return this.mUICreateNewHyperlink;
            }
        }
        
        public HtmlDiv UIIndexCreateNewNameMoPane
        {
            get
            {
                if ((this.mUIIndexCreateNewNameMoPane == null))
                {
                    this.mUIIndexCreateNewNameMoPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIIndexCreateNewNameMoPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIIndexCreateNewNameMoPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIIndexCreateNewNameMoPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Index\r\n\r\nCreate New \r\n\r\n\r\nName \r\n\r\nModel";
                    this.mUIIndexCreateNewNameMoPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIIndexCreateNewNameMoPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "container body-content";
                    this.mUIIndexCreateNewNameMoPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"container body-content\"";
                    this.mUIIndexCreateNewNameMoPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "5";
                    this.mUIIndexCreateNewNameMoPane.WindowTitles.Add("Index - My ASP.NET Application");
                    #endregion
                }
                return this.mUIIndexCreateNewNameMoPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUICreateNewHyperlink;
        
        private HtmlDiv mUIIndexCreateNewNameMoPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICreateMyASPNETApplicDocument : HtmlDocument
    {
        
        public UICreateMyASPNETApplicDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Create - My ASP.NET Application";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Cars/Create";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:2120/Cars/Create";
            this.WindowTitles.Add("Create - My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIModelEdit
        {
            get
            {
                if ((this.mUIModelEdit == null))
                {
                    this.mUIModelEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIModelEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Model";
                    this.mUIModelEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Model";
                    this.mUIModelEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Model";
                    this.mUIModelEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIModelEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIModelEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control text-box single-line";
                    this.mUIModelEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"Model\" class=\"form-control text-bo";
                    this.mUIModelEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "2";
                    this.mUIModelEdit.WindowTitles.Add("Create - My ASP.NET Application");
                    #endregion
                }
                return this.mUIModelEdit;
            }
        }
        
        public HtmlEdit UIRokprodukcjiEdit
        {
            get
            {
                if ((this.mUIRokprodukcjiEdit == null))
                {
                    this.mUIRokprodukcjiEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIRokprodukcjiEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Yop";
                    this.mUIRokprodukcjiEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Yop";
                    this.mUIRokprodukcjiEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Rok produkcji";
                    this.mUIRokprodukcjiEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIRokprodukcjiEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIRokprodukcjiEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control text-box single-line";
                    this.mUIRokprodukcjiEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"Yop\" class=\"form-control text-box ";
                    this.mUIRokprodukcjiEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "3";
                    this.mUIRokprodukcjiEdit.WindowTitles.Add("Create - My ASP.NET Application");
                    #endregion
                }
                return this.mUIRokprodukcjiEdit;
            }
        }
        
        public HtmlEdit UIVinEdit
        {
            get
            {
                if ((this.mUIVinEdit == null))
                {
                    this.mUIVinEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIVinEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Vin";
                    this.mUIVinEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Vin";
                    this.mUIVinEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Vin";
                    this.mUIVinEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIVinEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIVinEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control text-box single-line";
                    this.mUIVinEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"Vin\" class=\"form-control text-box ";
                    this.mUIVinEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "4";
                    this.mUIVinEdit.WindowTitles.Add("Create - My ASP.NET Application");
                    #endregion
                }
                return this.mUIVinEdit;
            }
        }
        
        public HtmlInputButton UICreateButton
        {
            get
            {
                if ((this.mUICreateButton == null))
                {
                    this.mUICreateButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUICreateButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUICreateButton.SearchProperties[HtmlButton.PropertyNames.Name] = "create";
                    this.mUICreateButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Create";
                    this.mUICreateButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUICreateButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUICreateButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-default";
                    this.mUICreateButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"create\" class=\"btn btn-default\" ty";
                    this.mUICreateButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "5";
                    this.mUICreateButton.WindowTitles.Add("Create - My ASP.NET Application");
                    #endregion
                }
                return this.mUICreateButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIModelEdit;
        
        private HtmlEdit mUIRokprodukcjiEdit;
        
        private HtmlEdit mUIVinEdit;
        
        private HtmlInputButton mUICreateButton;
        #endregion
    }
}
