﻿#pragma checksum "..\..\loginpage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4AE3CE70932DE549110BEDBB5EB780161802F822A6707B99AF823C8216584967"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace CourseWork {
    
    
    /// <summary>
    /// login
    /// </summary>
    public partial class login : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\loginpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CourseWork.login Page;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\loginpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\loginpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse User;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\loginpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Admin;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\loginpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginn;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\loginpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\loginpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Enter;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\loginpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Reg;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseWork;component/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\loginpage.xaml"
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
            this.Page = ((CourseWork.login)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.User = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 4:
            this.Admin = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 5:
            
            #line 92 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.U1_Click);
            
            #line default
            #line hidden
            
            #line 92 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.U1_MouseEnter);
            
            #line default
            #line hidden
            
            #line 92 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.U1_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 93 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.A1_Click);
            
            #line default
            #line hidden
            
            #line 93 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.A1_MouseEnter);
            
            #line default
            #line hidden
            
            #line 93 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.A1_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.loginn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            
            #line 117 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 117 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.R1_MouseEnter);
            
            #line default
            #line hidden
            
            #line 117 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.R1_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Enter = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 125 "..\..\loginpage.xaml"
            this.Enter.MouseEnter += new System.Windows.Input.MouseEventHandler(this.R1_MouseEnter);
            
            #line default
            #line hidden
            
            #line 125 "..\..\loginpage.xaml"
            this.Enter.MouseLeave += new System.Windows.Input.MouseEventHandler(this.R1_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 130 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reg_Click);
            
            #line default
            #line hidden
            
            #line 130 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.R2_MouseEnter);
            
            #line default
            #line hidden
            
            #line 130 "..\..\loginpage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.R2_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Reg = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 138 "..\..\loginpage.xaml"
            this.Reg.MouseEnter += new System.Windows.Input.MouseEventHandler(this.R2_MouseEnter);
            
            #line default
            #line hidden
            
            #line 138 "..\..\loginpage.xaml"
            this.Reg.MouseLeave += new System.Windows.Input.MouseEventHandler(this.R2_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

