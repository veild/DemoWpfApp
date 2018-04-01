using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DemoWpfApp.Modules
{
    /// <summary>
    /// Interaktionslogik für Collapsing.xaml
    /// </summary>
    public partial class Collapsing : Window
    {
        public Collapsing()
        {
            InitializeComponent();
            DataContext = new CollapsingViewModel();
        }
    }
}
