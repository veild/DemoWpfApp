using System;
using System.Windows.Input;

namespace DemoWpfApp
{
    /// <summary>
    /// Interface for window properties.
    /// </summary>
    interface IWindowInterface
    {
        /// <summary>
        /// Title of the window.
        /// </summary>
        String WindowTitle { get; set; }

        /// <summary>
        /// Background color of the window.
        /// </summary>
        String WindowBackground { get; set; }

        /// <summary>
        /// Fontsize of the window.
        /// </summary>
        String WindowFontSize { get; set; }

        /// <summary>
        /// Closes the window.
        /// </summary>
        ICommand Cmd_Close { get; set; }
    }
}
