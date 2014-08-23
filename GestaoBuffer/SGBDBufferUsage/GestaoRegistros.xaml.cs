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
using System.Windows.Shapes;

namespace SGBDBufferUsage
{
    /// <summary>
    /// Interaction logic for GestaoRegistros.xaml
    /// </summary>
    public partial class GestaoRegistros : Window
    {
        public GestaoRegistros()
        {
            InitializeComponent();
        }

        private void btnNovoRegistro_Click(object sender, RoutedEventArgs e)
        {
            this.pnlInclusao.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
