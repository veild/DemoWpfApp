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
        private bool mCollapseMode;

        /// <summary>
        /// Relay command for the collapsing command.
        /// </summary>
        public ICommand Cmd_Collapsing { get; set; }

        /// <summary>
        /// Relay command for the collapsing mode.
        /// </summary>
        public ICommand Cmd_Collapsing_Mode { get; set; }

        /// <summary>
        /// Content of the collapsing buttons.
        /// </summary>
        public String Btn_Collapse_Content_1 { get; set; }

        /// <summary>
        /// Content of the collapsing buttons.
        /// </summary>
        public String Btn_Collapse_Content_2 { get; set; }

        /// <summary>
        /// Content of the collapsing buttons.
        /// </summary>
        public String Btn_Collapse_Content_3 { get; set; }

        /// <summary>
        /// Content of the collapsing mode button.
        /// </summary>
        public String Btn_Collapse_Mode { get; set; }

        private String mVisOne;

        /// <summary>
        /// Visibility properties for the first element.
        /// </summary>
        public String StackPanelVisibilityOne
        {
            get
            {
                return mVisOne;
            }

            set
            {
                mVisOne = value;
                Btn_Collapse_Content_1 = mVisOne == "Collapsed" ? "+" : "-";
            }
        }

        private String mVisTwo;

        /// <summary>
        /// Visibility properties for the second element.
        /// </summary>
        public String StackPanelVisibilityTwo
        {
            get
            {
                return mVisTwo;
            }

            set
            {
                mVisTwo = value;
                Btn_Collapse_Content_2 = mVisTwo == "Collapsed" ? "+" : "-";
            }
        }

        private String mVisThree;

        /// <summary>
        /// Visibility properties for the third element.
        /// </summary>
        public String StackPanelVisibilityThree
        {
            get
            {
                return mVisThree;
            }

            set
            {
                mVisThree = value;
                Btn_Collapse_Content_3 = mVisThree == "Collapsed" ? "+" : "-";
            }
        }

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
            Cmd_Collapsing_Mode = new RelayCommand(CollapseMode);
            Btn_Collapse_Content_1 = "+";
            Btn_Collapse_Content_2 = "+";
            Btn_Collapse_Content_3 = "+";
            Btn_Collapse_Mode = "1";
            mCollapseMode = true;
            StackPanelVisibilityOne = "Collapsed";
            StackPanelVisibilityTwo = "Collapsed";
            StackPanelVisibilityThree = "Collapsed";
        }

        /// <summary>
        /// Switches the collapsing mode.
        /// </summary>
        private void CollapseMode()
        {
            mCollapseMode = mCollapseMode ? false : true;
            Btn_Collapse_Mode = mCollapseMode ? "1" : "2";
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
                    if(!mCollapseMode)
                    {
                        StackPanelVisibilityTwo = "Collapsed";
                        StackPanelVisibilityThree = "Collapsed";
                    }
                    break;
                case "2":
                    StackPanelVisibilityTwo = StackPanelVisibilityTwo == "Collapsed" ? "Visible" : "Collapsed";
                    if (!mCollapseMode)
                    {
                        StackPanelVisibilityOne = "Collapsed";
                        StackPanelVisibilityThree = "Collapsed";
                    }
                    break;
                case "3":
                    StackPanelVisibilityThree = StackPanelVisibilityThree == "Collapsed" ? "Visible" : "Collapsed";
                    if (!mCollapseMode)
                    {
                        StackPanelVisibilityTwo = "Collapsed";
                        StackPanelVisibilityOne = "Collapsed";
                    }
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
