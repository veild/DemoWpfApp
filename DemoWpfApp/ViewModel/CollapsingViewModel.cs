using System;
using System.Windows;
using System.Windows.Input;

namespace DemoWpfApp
{
    /// <summary>
    /// ViewModel for the collapsing module.
    /// </summary>
    public class CollapsingViewModel : BaseViewModel, IWindowInterface
    {
        /// <summary>
        /// Relay command for the collapsing command.
        /// </summary>
        public ICommand Cmd_Collapsing { get; set; }

        /// <summary>
        /// Content of the collapsing buttons.
        /// </summary>
        public String Btn_Collapse_Content { get; set; }

        /// <summary>
        /// Visibility properties for the elements.
        /// </summary>
        public String StackPanelVisibilityOne { get; set; }
        public String StackPanelVisibilityTwo { get; set; }
        public String StackPanelVisibilityThree { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public CollapsingViewModel()
        {
            WindowTitle = "DemoApp_Collapsing";
            WindowBackground = Global.BackgroundColor;
            WindowFontSize = "30";
            Cmd_Close = new RelayCommand(param => Close(param));
            Cmd_Collapsing = new RelayCommand(param => Collapse(param));
            Btn_Collapse_Content = "[+]";
            StackPanelVisibilityOne = "Collapsed";
            StackPanelVisibilityTwo = "Collapsed";
            StackPanelVisibilityThree = "Collapsed";
        }

        /// <summary>
        /// Collapses the clicked item.
        /// </summary>
        /// <param name="param">Item clicked.</param>
        private void Collapse(object param)
        {
            switch ((string)param)
            {
                case "1":
                    StackPanelVisibilityOne = StackPanelVisibilityOne == "Collapsed" ? "Visible" : "Collapsed";
                    break;
                case "2":
                    StackPanelVisibilityTwo = StackPanelVisibilityTwo == "Collapsed" ? "Visible" : "Collapsed";
                    break;
                case "3":
                    StackPanelVisibilityThree = StackPanelVisibilityThree == "Collapsed" ? "Visible" : "Collapsed";
                    break;
                default:
                    StackPanelVisibilityOne = "Collapsed";
                    StackPanelVisibilityTwo = "Collapsed";
                    StackPanelVisibilityThree = "Collapsed";
                    break;
            }
        }

        /// <summary>
        /// Closes the current window.
        /// </summary>
        /// <param name="param">The window to close.</param>
        private void Close(object param)
        {
            Window window = (Window)param;
            window.Close();
        }

        /// <summary>
        /// Properties of the IWindowInterface.
        /// </summary>
        public string WindowTitle { get; set; }
        public string WindowBackground { get; set; }
        public string WindowFontSize { get; set; }
        public ICommand Cmd_Close { get; set; }
    }
}
