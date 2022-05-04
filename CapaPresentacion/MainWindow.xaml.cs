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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            man .Administracion  frm = new man .Administracion ();
            frm.Show();
        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            man.Docente frm = new man.Docente();
            frm.Show();
          
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            man.Alumno frm = new man.Alumno();
            frm.Show();
        }
    }
}
