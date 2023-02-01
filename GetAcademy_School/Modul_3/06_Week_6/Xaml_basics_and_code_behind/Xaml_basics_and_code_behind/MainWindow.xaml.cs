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

namespace Xaml_basics_and_code_behind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Note: This code is for showing what is happening behind the scenes. Also called "Code-Behind"
            // To check if this code works as intended(like the one designed), we have to comment out all xaml design code - exept for "window"
            InitializeComponent(); // Initialize required stuff!!
            Grid grid= new Grid();// Creating a new grid.
            this.Content = grid; //this.content in this case means what is between <window></window> => put it in grid. 
            Button btn = new Button();
            //btn.Height= 100;
            //btn.Width= 200;
            btn.FontSize = 26;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock textblock = new TextBlock();
            textblock.Text = "Multi";
            textblock.Foreground = Brushes.Blue; // Textcolor in xaml is done with "brushes"
            wrapPanel.Children.Add(textblock); // Adding one textblock to the wrap panel.

            textblock = new TextBlock();
            textblock.Text = "Color";
            textblock.Foreground = Brushes.Red; // Textcolor in xaml is done with "brushes"
            wrapPanel.Children.Add(textblock); // Adding one textblock to the wrap panel.

            textblock = new TextBlock();
            textblock.Text = "Button";
            textblock.Foreground = Brushes.White; // Textcolor in xaml is done with "brushes"
            wrapPanel.Children.Add(textblock); // Adding one textblock to the wrap panel.

            btn.Content = wrapPanel;
            grid.Children.Add(btn);



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
