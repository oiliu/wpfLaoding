﻿#pragma checksum "..\..\Second.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "98BAE099E5BFACE9467977B6F5524A02"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WpfApplication1 {
    
    
    /// <summary>
    /// Second
    /// </summary>
    public partial class Second : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\Second.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Second.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb thumb1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Second.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle RectangleLinear;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Second.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelText;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Second.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider1;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/second.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Second.xaml"
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
            
            #line 4 "..\..\Second.xaml"
            ((WpfApplication1.Second)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            
            #line 5 "..\..\Second.xaml"
            this.LayoutRoot.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.thumb1 = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 17 "..\..\Second.xaml"
            this.thumb1.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.DragDelta);
            
            #line default
            #line hidden
            
            #line 17 "..\..\Second.xaml"
            this.thumb1.DragStarted += new System.Windows.Controls.Primitives.DragStartedEventHandler(this.DragStarted);
            
            #line default
            #line hidden
            
            #line 17 "..\..\Second.xaml"
            this.thumb1.DragCompleted += new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.DragCompleted);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RectangleLinear = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.labelText = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.slider1 = ((System.Windows.Controls.Slider)(target));
            return;
            case 7:
            
            #line 47 "..\..\Second.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            
            #line 47 "..\..\Second.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
