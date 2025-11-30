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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonejercicio1_Click(object sender, EventArgs e)
        {
            ejercicio1 form = new ejercicio1();
            form.Show();
            this.Hide();
        }

        private void buttonejercicio2_Click(object sender, EventArgs e)
        {
            ejercicio2 form = new ejercicio2();
            form.Show();
            this.Hide();
        }

        private void buttonejercicio3_Click(object sender, EventArgs e)
        {
            ejercicio3 form = new ejercicio3();
            form.Show();
            this.Hide();
        }

        private void buttonEjercicio4_Click(object sender, EventArgs e)
        {
            ejercicio4 form = new ejercicio4();
            form.Show();
            this.Hide();
        }

        private void bnEjercicio5_Click(object sender, EventArgs e)
        {
            Ejercicio5 form = new Ejercicio5();
            form.Show();
            this.Hide();
        }
    }
}
