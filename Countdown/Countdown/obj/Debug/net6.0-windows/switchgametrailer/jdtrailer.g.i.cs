﻿#pragma checksum "..\..\..\..\switchgametrailer\jdtrailer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3DC0A8F0C422F15F4552B8D7EE866C767B389627"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Countdown.switchgametrailer;
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


namespace Countdown.switchgametrailer {
    
    
    /// <summary>
    /// jdtrailer
    /// </summary>
    public partial class jdtrailer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement trailer;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button play;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stop;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pause;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volume;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Countdown;V1.0.0.0;component/switchgametrailer/jdtrailer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.trailer = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 2:
            this.play = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
            this.play.Click += new System.Windows.RoutedEventHandler(this.trailer_play);
            
            #line default
            #line hidden
            return;
            case 3:
            this.stop = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
            this.stop.Click += new System.Windows.RoutedEventHandler(this.trailer_stop);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pause = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
            this.pause.Click += new System.Windows.RoutedEventHandler(this.trailer_pause);
            
            #line default
            #line hidden
            return;
            case 5:
            this.volume = ((System.Windows.Controls.Slider)(target));
            
            #line 66 "..\..\..\..\switchgametrailer\jdtrailer.xaml"
            this.volume.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

