namespace Principal
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.casillas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dificultad = new System.Windows.Forms.GroupBox();
            this.avanzado = new System.Windows.Forms.RadioButton();
            this.intermedio = new System.Windows.Forms.RadioButton();
            this.principiante = new System.Windows.Forms.RadioButton();
            this.dificultad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Con qué dimensión quieres jugar?";
            // 
            // casillas
            // 
            this.casillas.Location = new System.Drawing.Point(192, 13);
            this.casillas.Name = "casillas";
            this.casillas.Size = new System.Drawing.Size(34, 20);
            this.casillas.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dificultad
            // 
            this.dificultad.Controls.Add(this.avanzado);
            this.dificultad.Controls.Add(this.intermedio);
            this.dificultad.Controls.Add(this.principiante);
            this.dificultad.Location = new System.Drawing.Point(16, 42);
            this.dificultad.Name = "dificultad";
            this.dificultad.Size = new System.Drawing.Size(301, 47);
            this.dificultad.TabIndex = 4;
            this.dificultad.TabStop = false;
            this.dificultad.Text = "Nivel";
            // 
            // avanzado
            // 
            this.avanzado.AutoSize = true;
            this.avanzado.Location = new System.Drawing.Point(201, 19);
            this.avanzado.Name = "avanzado";
            this.avanzado.Size = new System.Drawing.Size(73, 17);
            this.avanzado.TabIndex = 3;
            this.avanzado.TabStop = true;
            this.avanzado.Text = "Avanzado";
            this.avanzado.UseVisualStyleBackColor = true;
            // 
            // intermedio
            // 
            this.intermedio.AutoSize = true;
            this.intermedio.Location = new System.Drawing.Point(109, 19);
            this.intermedio.Name = "intermedio";
            this.intermedio.Size = new System.Drawing.Size(74, 17);
            this.intermedio.TabIndex = 2;
            this.intermedio.TabStop = true;
            this.intermedio.Text = "Intermedio";
            this.intermedio.UseVisualStyleBackColor = true;
            // 
            // principiante
            // 
            this.principiante.AutoSize = true;
            this.principiante.Checked = true;
            this.principiante.Location = new System.Drawing.Point(6, 19);
            this.principiante.Name = "principiante";
            this.principiante.Size = new System.Drawing.Size(80, 17);
            this.principiante.TabIndex = 1;
            this.principiante.TabStop = true;
            this.principiante.Text = "Principiante";
            this.principiante.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 251);
            this.Controls.Add(this.dificultad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.casillas);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.dificultad.ResumeLayout(false);
            this.dificultad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox casillas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox dificultad;
        private System.Windows.Forms.RadioButton principiante;
        private System.Windows.Forms.RadioButton avanzado;
        private System.Windows.Forms.RadioButton intermedio;
    }
}

