﻿#pragma checksum "C:\Jukebox\repo\client2\Jukebox.Client2\PlayAndPauseButton.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CABC4AF6935CD14C1F677044DBAF4AC8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
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


namespace Jukebox.Client2 {
    
    
    public partial class PlayAndPauseButton : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle Rectangle1;
        
        internal System.Windows.Media.PlaneProjection Plane1;
        
        internal System.Windows.Shapes.Path Play;
        
        internal System.Windows.Shapes.Path Pause;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Jukebox.Client2;component/PlayAndPauseButton.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Rectangle1 = ((System.Windows.Shapes.Rectangle)(this.FindName("Rectangle1")));
            this.Plane1 = ((System.Windows.Media.PlaneProjection)(this.FindName("Plane1")));
            this.Play = ((System.Windows.Shapes.Path)(this.FindName("Play")));
            this.Pause = ((System.Windows.Shapes.Path)(this.FindName("Pause")));
        }
    }
}

