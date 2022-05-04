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
    /// Lógica de interacción para Alumno.xaml
    /// </summary>
    public partial class Alumno : Window
    {
        public Alumno()
        {
            InitializeComponent();
        }
        // declarar el objeto
        static CapaNegocio.Alumno  alumno  = new CapaNegocio.Alumno ();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            alumno.Codigo = txtCodigo.Text.Trim();
            alumno.Apellidos = txtApellidos.Text.Trim();
            alumno.Correo = txtCorreo.Text.Trim();
            alumno.Domicilio = txtDomicilio.Text.Trim();
            alumno.LugarNac = txtLuarNac .Text.Trim();
            alumno.Nombres = txtNombres.Text.Trim();
            alumno.Escuela  = txtEscuela .Text.Trim();
            alumno.Sede  = txtSede .Text.Trim();
            

            MessageBox.Show("Los datos del objeto alumno fueron registrasdos correctamente", "Agregar alumno ");
        }
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Codigo: " + alumno.Codigo + "\nCorreo: " + alumno.Correo + "\nApellidos: " + alumno.Apellidos +
                            "\nNombres:" + alumno.Nombres + "\nDomicilio:" + alumno.Domicilio + "\nLugarNac: " + alumno.LugarNac +
                             "\nEscuela: " + alumno.Escuela  + "\nSede:" + alumno.Sede.ToString());
        }

        private void btnAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Asistir());
        }

        private void btnExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Asistir());
        }
    }
}
