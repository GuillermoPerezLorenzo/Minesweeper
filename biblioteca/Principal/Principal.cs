//Guillermo Pérez Lorenzo 16637958B
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteca;

namespace Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nCasillas;
            int nDificultad=1;
            int minas = 0;
            if (int.TryParse(casillas.Text, out nCasillas) && nCasillas>4 && nCasillas< 14)
            {
                foreach(Control ctrl in dificultad.Controls)
                {
                    if(ctrl is RadioButton)
                    {
                        RadioButton dif = ctrl as RadioButton;
                        if (dif.Checked)
                        {
                            if (dif.Name == "principiante")
                            {
                                nDificultad = 1;
                                minas = nCasillas*nCasillas * 10 / 100;
                            }
                            if (dif.Name == "intermedio")
                            {
                                nDificultad = 2;
                                minas = nCasillas * nCasillas * 15 / 100;
                            }
                            if (dif.Name == "avanzado")
                            {
                                nDificultad = 3;
                                minas = nCasillas * nCasillas * 20 / 100;
                            }
                        }
                    }
                }
                dificultad.Enabled = false;//desabilita las opciones que ya han sido recogidos los datos
                casillas.Enabled = false;
                button1.Enabled = false;
                BuscaMinas aux1 = new BuscaMinas(nCasillas, nDificultad);//crea un buscaminas a partir de los datos recogidos
                //cambia el tamaño
                aux1.Location = new Point(13, 100);
                this.Controls.Add(aux1);
                int ancho = 40 * nCasillas + 40;
                if (this.Size.Width > ancho)
                    ancho = this.Size.Width;
                int largo = 40 * nCasillas + 150;
                this.Size = new System.Drawing.Size(ancho, largo);
                MessageBox.Show("Jugaras al buscaminas con "+nCasillas*nCasillas+" casillas y con "+minas+" minas");
            }
            else
            {
                MessageBox.Show("No has introducido los valores adecuados (entre 5 y 13)");
            }
        }
    }
}
