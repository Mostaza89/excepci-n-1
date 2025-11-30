namespace excepción_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonejercicio1 = new System.Windows.Forms.Button();
            this.buttonejercicio2 = new System.Windows.Forms.Button();
            this.buttonejercicio3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonejercicio1
            // 
            this.buttonejercicio1.Location = new System.Drawing.Point(69, 78);
            this.buttonejercicio1.Name = "buttonejercicio1";
            this.buttonejercicio1.Size = new System.Drawing.Size(89, 40);
            this.buttonejercicio1.TabIndex = 0;
            this.buttonejercicio1.Text = "Ejercicio 1";
            this.buttonejercicio1.UseVisualStyleBackColor = true;
            this.buttonejercicio1.Click += new System.EventHandler(this.buttonejercicio1_Click);
            // 
            // buttonejercicio2
            // 
            this.buttonejercicio2.Location = new System.Drawing.Point(69, 172);
            this.buttonejercicio2.Name = "buttonejercicio2";
            this.buttonejercicio2.Size = new System.Drawing.Size(89, 40);
            this.buttonejercicio2.TabIndex = 1;
            this.buttonejercicio2.Text = "Ejercicio 2";
            this.buttonejercicio2.UseVisualStyleBackColor = true;
            this.buttonejercicio2.Click += new System.EventHandler(this.buttonejercicio2_Click);
            // 
            // buttonejercicio3
            // 
            this.buttonejercicio3.Location = new System.Drawing.Point(69, 260);
            this.buttonejercicio3.Name = "buttonejercicio3";
            this.buttonejercicio3.Size = new System.Drawing.Size(89, 40);
            this.buttonejercicio3.TabIndex = 2;
            this.buttonejercicio3.Text = "Ejercicio 3";
            this.buttonejercicio3.UseVisualStyleBackColor = true;
            this.buttonejercicio3.Click += new System.EventHandler(this.buttonejercicio3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonejercicio3);
            this.Controls.Add(this.buttonejercicio2);
            this.Controls.Add(this.buttonejercicio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonejercicio1;
        private System.Windows.Forms.Button buttonejercicio2;
        private System.Windows.Forms.Button buttonejercicio3;
    }
}

