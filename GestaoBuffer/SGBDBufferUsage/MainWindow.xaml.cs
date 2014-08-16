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
        private static object _syncLock = new object();
        private bool _shutdownThread = false;
        private bool _changeBuffer = false;
        private SGBDBuffer.Buffer _buffer;

        public MainWindow()
        {
            InitializeComponent();

            _buffer = new SGBDBuffer.Buffer();
            txtPaginas.Text = _buffer.PrintData();
        }

        private void btnIniciarAlteracoes_Click(object sender, RoutedEventArgs e)
        {
            _shutdownThread = false;

            new Thread(CarregarDados).Start();
            new Thread(AlterarBuffer).Start();

            btnIniciarAlteracoes.IsEnabled = false;
            btnPausarAlteracoes.Visibility = System.Windows.Visibility.Visible;
        }

        private void btnPausarAlteracoes_Click(object sender, RoutedEventArgs e)
        {
            _shutdownThread = true;

            btnIniciarAlteracoes.IsEnabled = true;
            btnPausarAlteracoes.Visibility = System.Windows.Visibility.Hidden;
        }

        private void CarregarDados()
        {
            while (!_shutdownThread)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    _buffer.LoadPageInMemory();
                    lblPagina.Content = _buffer.ChangeIndex;
                    txtPaginas.Text = _buffer.PrintData();

                    if (_changeBuffer)
                    {
                        _buffer.ChangePageInMemory();
                        txtPaginas.Text = _buffer.PrintData();

                        lock (_syncLock)
                        {
                            _changeBuffer = false;
                        }
                    }

                    _buffer.ReleasePageInMemory();
                    txtPaginas.Text = _buffer.PrintData();
                }));

                Thread.Sleep(1000);
            }
        }

        private void AlterarBuffer()
        {
            while (!_shutdownThread)
            {
                Thread.Sleep(2000);
                lock (_syncLock)
                {
                    _changeBuffer = true;
                }
            }
        }

        private void comboAlgoritmo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBox;
            var item = combo.SelectedItem as ComboBoxItem;

            if (item.Content != null)
                _buffer.ChangeAlgorithm(item.Content.ToString());
        }

        private void mainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _shutdownThread = true;
        }
    }
}
