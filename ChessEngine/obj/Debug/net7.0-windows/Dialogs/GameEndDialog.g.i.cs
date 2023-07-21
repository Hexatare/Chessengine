﻿#pragma checksum "..\..\..\..\Dialogs\GameEndDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74A2962727BBA878BD96B3A01473EA3FF59ED19F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using ChessEngine.Dialogs;
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


namespace ChessEngine.Dialogs {
    
    
    /// <summary>
    /// GameEndDialog
    /// </summary>
    public partial class GameEndDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Dialogs\GameEndDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ChessLogo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Dialogs\GameEndDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdOk;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Dialogs\GameEndDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblWinner;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Dialogs\GameEndDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblMoves;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Dialogs\GameEndDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTime;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Dialogs\GameEndDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboPiece;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Dialogs\GameEndDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblReason;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ChessEngine;V1.0.0.0;component/dialogs/gameenddialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\GameEndDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ChessLogo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.cmdOk = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Dialogs\GameEndDialog.xaml"
            this.cmdOk.Click += new System.Windows.RoutedEventHandler(this.cmdOk_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LblWinner = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.LblMoves = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.LblTime = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.CboPiece = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.LblReason = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
