using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using SGBDBuffer;

namespace SGBDBufferUsage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnGerenBuffer_Click(object sender, RoutedEventArgs e)
        {
            GestaoBuffer gbScreen = new GestaoBuffer();
            gbScreen.Show();
        }

        private void btnGerenRegistros_Click(object sender, RoutedEventArgs e)
        {
            GestaoRegistros grScreen = new GestaoRegistros();
            grScreen.Show();
        }       
    }
}
