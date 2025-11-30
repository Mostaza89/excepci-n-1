using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excepción_1
{
    public partial class ejercicio3 : Form
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                int divisor = int.Parse(textBox1.Text);

                string ruta = textBox2.Text;

                if (!File.Exists(ruta))
                {
                    throw new FileNotFoundException("No se encontró el archivo en la ruta indicada.");
                }

                pictureBox1.Image = Image.FromFile(ruta);

                int resultado = 100 / divisor;

                MessageBox.Show($"¡Imagen cargada y cálculo realizado!\nResultado: {resultado}");

            }
            catch (FormatException)
            {
                MessageBox.Show("El divisor debe ser un número entero");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "Archivo no encontrado");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir entre cero mi rey.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado" + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio3_Load(object sender, EventArgs e)
        {

        }
    }
}
