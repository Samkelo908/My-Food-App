﻿#pragma checksum "..\..\..\FilterRecipesPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3503E7CA30CCA804FCFC655FD428EA342F10870D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Receipts {
    
    
    /// <summary>
    /// FilterRecipesPage
    /// </summary>
    public partial class FilterRecipesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\FilterRecipesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IngredientTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\FilterRecipesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FoodGroupComboBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\FilterRecipesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaxCaloriesTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\FilterRecipesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilterButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\FilterRecipesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FilteredRecipesListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Receipts;component/filterrecipespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FilterRecipesPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.IngredientTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\FilterRecipesPage.xaml"
            this.IngredientTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.IngredientTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\FilterRecipesPage.xaml"
            this.IngredientTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.IngredientTextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\FilterRecipesPage.xaml"
            this.IngredientTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.IngredientTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FoodGroupComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\FilterRecipesPage.xaml"
            this.FoodGroupComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FoodGroupComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MaxCaloriesTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\FilterRecipesPage.xaml"
            this.MaxCaloriesTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.MaxCaloriesTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\FilterRecipesPage.xaml"
            this.MaxCaloriesTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.MaxCaloriesTextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\FilterRecipesPage.xaml"
            this.MaxCaloriesTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.MaxCaloriesTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FilterButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\FilterRecipesPage.xaml"
            this.FilterButton.Click += new System.Windows.RoutedEventHandler(this.FilterButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FilteredRecipesListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

