using excepción_1.clase_ejercicio_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excepción_1
{
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clase_metodos proceso = new Clase_metodos ();

                proceso.IniciarProceso(textBox1.Text);

                MessageBox.Show("Todo bien mi rey");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }

        //¿Dónde ocurrió realmente el error?
        //El error ocurrio en el metodo convetir, por el int.parse, ya que se intento convertir una cadena no numerica a entero.

        //¿Dónde se manejó?
        //El error se manejo en el boton, donde se llamo al metodo iniciar proceso, y encontro el bloque try catch.

        //¿Por qué es útil este comportamiento?
        //Es util porque se evita el codigo saturado de bloques try catch, haciendo que el codigo sea mas limpio y facil de mantener al subir error hasta el nivel donde se pueda manejar de mejor manera.

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
