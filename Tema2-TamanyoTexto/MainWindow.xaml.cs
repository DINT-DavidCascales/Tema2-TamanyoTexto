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

namespace Tema2_TamanyoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pequeño.IsChecked = true;
        }
       

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            String rBoton = (sender as RadioButton).Tag.ToString();

            if (rBoton == "pequeño")
                texto.FontSize = 36;
            else if (rBoton == "mediano")
                texto.FontSize = 48;
            else
                texto.FontSize = 72;
        }
    }
}
