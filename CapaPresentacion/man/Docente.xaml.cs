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
    /// Lógica de interacción para Docente.xaml
    /// </summary>
    public partial class Docente : Window
    {
        public Docente()
        {
            InitializeComponent();
        }
        static CapaNegocio.Docente  docente = new CapaNegocio.Docente();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();
            docente.LugarNac = txtLugarNac.Text.Trim();
            docente.Nombres = txtNombres.Text.Trim();
            docente.Afp  = txtAfp .Text.Trim();
            docente.Estudios  = txtEstudios .Text.Trim();
            docente.Profesion = txtProfesion.Text.Trim();
            MessageBox.Show("Los datos del objeto alumno fueron registrasdos correctamente", "Agregar docente ");
        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Codigo: " + docente.Codigo + "\nCorreo: " + docente.Correo + "\nApellidos: " + docente.Apellidos +
                            "\nNombres:" + docente.Nombres + "\nDomicilio:" + docente.Domicilio + "\nLugarNac: " + docente.LugarNac +
                            "\nProfesion: " + docente.Profesion  +
                             "\nEstudios: " + docente.Estudios + "\nAfp:" + docente.Afp .ToString());
        }

        private void btnAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Asistir());
        }

        private void bttnExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Exisistir ());
        }
    }
}
