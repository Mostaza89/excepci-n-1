using excepción_1.Clase_ejercicio_3;
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
    public partial class ejercicio4 : Form
    {
        public ejercicio4()
        {
            InitializeComponent();
        }

        private void ejercicio4_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;

                int edad = int.Parse(txtEdad.Text);

                Clasemetodos miValidador = new Clasemetodos();
                miValidador.ValidarNombre(nombre);
                miValidador.ValidarEdad(edad);

                MessageBox.Show("Todo bien mi rey.");
            }
            catch (FormatException)
            {
                MessageBox.Show("La edad debe ser un número entero.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message + " Error de Rango");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message + " Error de Datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //¿Qué datos generan errores?
        //El tener un nombre vacio, una edad menos a 0 o muy
        //grande, y el ingresar un valor no numerico en la edad.

        //¿Por qué es mejor lanzar excepciones desde los métodos
        //en vez de manejar todo en el formulario?
        //Porque se puede reutizar el codigo y tener una mejor 
        //organizacion de codigo. 

        private void bnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
