using DemoWpfApp.Modules;
using System;
using System.Windows;
using System.Windows.Input;

namespace DemoWpfApp
{
    /// <summary>
    /// ViewModel for the main window.
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        /// <summary>
        /// Title of the main window.
        /// </summary>
        public String MainWindowTitle { get; set; }

        /// <summary>
        /// Background color of the main window.
        /// </summary>
        public String MainWindowBackground { get; set; }

        /// <summary>
        /// Opens the collapsing module.
        /// </summary>
        public ICommand Cmd_Collapsing { get; set; }

        /// <summary>
        /// Closes the application.
        /// </summary>
        public ICommand Cmd_Close { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainWindowViewModel()
        {
            MainWindowTitle = "Demo Application";
            MainWindowBackground = Global.BackgroundColor;
            Cmd_Collapsing = new RelayCommand(Collapsing);
            Cmd_Close = new RelayCommand(param => Close(param));
        }

        /// <summary>
        /// Opens the collapsing module.
        /// </summary>
        private void Collapsing()
        {
            Collapsing collapsing = new Collapsing();
            collapsing.ShowDialog();
        }

        /// <summary>
        /// Closes the main window.
        /// </summary>
        /// <param name="param"></param>
        private void Close(object param)
        {
            Window window = (Window)param;
            window.Close();
        }

    }
}
