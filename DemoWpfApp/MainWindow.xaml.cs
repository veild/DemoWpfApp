﻿/**
 * Author: Denis Veil
 * 
 * NuGet-Packages:
 * Fody-Weavers PropertyChanged
 * 
 * Modules:
 * 
 */


using System.Windows;

namespace DemoWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
