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
    public partial class ejercicio1 : Form
    {
        public ejercicio1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "";

                int numero = int.Parse(textBox1.Text);

                label1.ForeColor = Color.Green;
                label1.Text = "Se ha ingresado un valor correcto: " + numero;
            }
            catch (FormatException)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Se ha ingresado un valor invalido, por favor ingresa un numero entero (int).";
            }
            catch (OverflowException)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Se ha provocado un desvordammiento, por favor ingresa un numero mas pequeño.";
            }
            catch (Exception ex)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Se ha producido un error, por favor ingresa un numero entero." + ex.Message;
            }
        }

        //aparecen 2 tipos de errorees, uno es el FormatException que ocurre cuando se ingresa un valor 
        //que no puede convertirse a entero, como una letras o un caracter especial, y el otro es el OverflowException
        //que ocurre cuando se ingresa un numero que es demasiado grande y salta el limite del tipo de dato int(entero).


        private void buttonREGRESAR_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
