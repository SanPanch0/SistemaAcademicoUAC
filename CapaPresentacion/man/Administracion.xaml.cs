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
using System.Windows.Shapes;

namespace CapaPresentacion.man
{
    /// <summary>
    /// Lógica de interacción para Administracion.xaml
    /// </summary>
    public partial class Administracion : Window
    {
        public Administracion()
        {
            InitializeComponent();
        }
        // declarar el objeto
        static CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btmEscribir_Click(object sender, RoutedEventArgs e)
        {
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();
            administrativo.LugarNac = txtLugarNac.Text.Trim();
            administrativo.Nombres = txtNombres.Text.Trim();
            administrativo.Experiencia = txtExperiencia.Text.Trim();
            administrativo.Sueldo = txtSueldo.Text.Trim();
            MessageBox.Show("Los datos del objeto alumno fueron registrasdos correctamente", "Agregar administracion ");
        }

        private void btmLeer_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Codigo: " + administrativo.Codigo + "\nCorreo: " + administrativo.Correo + "\nApellidos: " + administrativo.Apellidos +
                            "\nNombres:" + administrativo.Nombres + "\nDomicilio:" + administrativo.Domicilio + "\nLugarNac: " + administrativo.LugarNac +
                             "\nExperiencia: " + administrativo.Experiencia + "\nSueldo:" + administrativo.Sueldo.ToString());

        }

        private void btmAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Asistir());
        }

        private void btmExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Exisistir());
        }

        private void btmActualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btmActualizar1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btmEliminar_Click(object sender, RoutedEventArgs e)
        {
        
        }
        

        private void btmEstudiar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btmListar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Listar ());
        }

        private void btmAgregar_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
