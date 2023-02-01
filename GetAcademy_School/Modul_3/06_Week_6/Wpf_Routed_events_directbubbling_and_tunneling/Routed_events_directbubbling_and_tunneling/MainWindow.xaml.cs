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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Routed_events_directbubbling_and_tunneling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Notes.
        // routed events.
        // Tunneling events. - Tunneling events moves downwards in the visual tree.
        // Bubbling events. - Bubling events moves upwards in the visual tree.

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Button clicked, < Direct Event > , Direct event are handled by the item itself,
                < Direct Event > , Direct event are handled by the item itself,
                < Direct Event > , Direct event are handled by the item itself,
                < Direct Event > , Direct event are handled by the item itself
                < Direct Event > , Direct event are handled by the item itself");
        }

        

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button went up / was released - Tunneling event");
        }
    }
}
