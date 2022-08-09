using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PomodoroTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sound sound = new Sound(1, "Fire", "../../../../Sounds/fireplace.wav");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(Environment.CurrentDirectory);
            Trace.WriteLine(Environment.CurrentDirectory);
            sound.play();
        }
    }
}
