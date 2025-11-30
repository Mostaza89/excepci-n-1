using excepción_1.Clase_ejercicio_5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excepción_1
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void Ejercicio5_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnSubir_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string correo = txtCorreo.Text;

                int edad = int.Parse(txtEdad.Text);

                Clasevalidardatos miValidador = new Clasevalidardatos();
                miValidador.ValidarDatos(nombre, edad, correo);

                MessageBox.Show("Todo bien mi rey");
            }
            catch (DatoInvalidoException ex)
            {
                MessageBox.Show(ex.Message + " Error de Validación");

                listBox1.Items.Add(ex.Message);
            }
            catch (FormatException)
            {
                string mensajeError = "La edad debe ser un número entero.";
                MessageBox.Show(mensajeError + " Error de Formato");
                listBox1.Items.Add(mensajeError);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //¿En qué ayuda separar errores del negocio de los errores técnicos?
        //Ayuda a tener un mejor control sobre los errores que pueden surgir
        //y permite mostrar mensajes más específicos y útiles para el usuario.

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
