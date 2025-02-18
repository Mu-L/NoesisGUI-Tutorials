﻿#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows;
using System.Windows.Controls;
#endif

namespace Localization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.Initialized += OnInitialized;
            this.InitializeComponent();
        }

#if NOESIS
        void InitializeComponent()
        {
            Noesis.GUI.LoadComponent(this, "Assets/NoesisGUI/Samples/Localization/MainWindow.xaml");
        }
#endif

        private void OnInitialized(object sender, EventArgs args)
        {
            this.DataContext = new ViewModel();
        }
    }
}
