﻿#pragma checksum "..\..\addNewCategory.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D9C2082FFA484886D81849AE575B5EAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Helper;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Helper {
    
    
    /// <summary>
    /// addNewCategory
    /// </summary>
    public partial class addNewCategory : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\addNewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView categoriesListView;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\addNewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox categoryTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\addNewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox1;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\addNewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\addNewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\addNewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid InputBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\addNewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editCategoryTextBox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\addNewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button YesButton;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\addNewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Helper;component/addnewcategory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addNewCategory.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\addNewCategory.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.RemoveCategory_CanExecute);
            
            #line default
            #line hidden
            
            #line 7 "..\..\addNewCategory.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.RemoveCategory_Execute);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 8 "..\..\addNewCategory.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AddNewCategory_CanExecute);
            
            #line default
            #line hidden
            
            #line 8 "..\..\addNewCategory.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.AddNewCategory_Execute);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 9 "..\..\addNewCategory.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.RemoveCategory_CanExecute);
            
            #line default
            #line hidden
            
            #line 9 "..\..\addNewCategory.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ShowEditPanelCategory_Execute);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 10 "..\..\addNewCategory.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.EditCategory_CanExecute);
            
            #line default
            #line hidden
            
            #line 10 "..\..\addNewCategory.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.EditCategory_Execute);
            
            #line default
            #line hidden
            return;
            case 5:
            this.categoriesListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.categoryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.checkBox1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.okButton = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.InputBox = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.editCategoryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.YesButton = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.NoButton = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\addNewCategory.xaml"
            this.NoButton.Click += new System.Windows.RoutedEventHandler(this.NoButton_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

