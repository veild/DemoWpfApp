using System.ComponentModel;

namespace DemoWpfApp
{
    /// <summary>
    /// A base view model that fires Property Changed events as needed.
    /// </summary>
    /// // [AddINotifyPropertyChangedInterface]
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
