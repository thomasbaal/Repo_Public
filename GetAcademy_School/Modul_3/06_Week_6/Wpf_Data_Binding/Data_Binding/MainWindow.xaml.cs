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

namespace Data_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // we are in the same class as the slider (because we are inheriting from window: witch we again have our code)

            // So if we set it here. it will have a default value of "30" , and also it is set to OneWayToSource, so the the new rules applies after runtime, slider wil not change value, but textbox can change the slider value!
            InitializeComponent();
            MySlider.Value = 30; // using data binding with "oneTime" we set it here, at the constructor, so it runs on initialization.
            MyTextbox.Text = MySlider.Value.ToString(); // converts value from slider to string and show it in MyTextbox.Text Property.
        }
    }
}
