﻿#pragma checksum "C:\DoWapp\Jobs\256237.jbhfcg\src\WP8App\Controls\FlipControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "80D5AD56622B9A880DE2D4D0F7531128"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WPAppStudio.Controls {
    
    
    public partial class FlipControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl UserControl;
        
        internal System.Windows.Media.Animation.Storyboard SlideLeft;
        
        internal System.Windows.Media.Animation.Storyboard SlideLeftReset;
        
        internal System.Windows.Media.Animation.Storyboard SlideRight;
        
        internal System.Windows.Media.Animation.Storyboard SlideRightReset;
        
        internal System.Windows.Media.Animation.Storyboard SlideTopLeft;
        
        internal System.Windows.Media.Animation.Storyboard SlideTopRight;
        
        internal System.Windows.Media.Animation.Storyboard SlideTopLeftReset;
        
        internal System.Windows.Media.Animation.Storyboard SlideTopRightReset;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button PrevButton;
        
        internal System.Windows.Controls.Button NextButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WPAppStudio;component/Controls/FlipControl.xaml", System.UriKind.Relative));
            this.UserControl = ((System.Windows.Controls.UserControl)(this.FindName("UserControl")));
            this.SlideLeft = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SlideLeft")));
            this.SlideLeftReset = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SlideLeftReset")));
            this.SlideRight = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SlideRight")));
            this.SlideRightReset = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SlideRightReset")));
            this.SlideTopLeft = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SlideTopLeft")));
            this.SlideTopRight = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SlideTopRight")));
            this.SlideTopLeftReset = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SlideTopLeftReset")));
            this.SlideTopRightReset = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SlideTopRightReset")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PrevButton = ((System.Windows.Controls.Button)(this.FindName("PrevButton")));
            this.NextButton = ((System.Windows.Controls.Button)(this.FindName("NextButton")));
        }
    }
}

