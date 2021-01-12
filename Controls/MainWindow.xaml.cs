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

namespace Controls
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

        private void Btn_KlickMich_Click(object sender, RoutedEventArgs e)
        {
            //Lbl_Output.Content = (Cbb_Auswahl.SelectedItem as ComboBoxItem).Content;

            //Wnd_Main.Background = new SolidColorBrush(Colors.Blue);

            //MessageBox.Show(Tbx_Input.Text);

            MessageBox.Show(Sdr_Wert.Value.ToString());
        }

        private void Neu_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow neuesFenster = new MainWindow();

            neuesFenster.ShowDialog();
        }

        private void Beenden_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            Application.Current.Shutdown();
        }
    }
}
