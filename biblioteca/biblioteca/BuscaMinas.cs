//Guillermo Pérez Lorenzo 16637958B
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class BuscaMinas : UserControl
    {
        private Button[,] mapa;
        private int tamaño;
        public BuscaMinas(int casillas, int dificultad)
        {
            tamaño = casillas;
            InitializeComponent();
            crearBotones(casillas, dificultad);
        }
        private void crearBotones(int casillas, int dificultad)//crea los botones en funcion de la dimension para jugar al buscaminas
        {
            mapa = new Button[casillas, casillas];
            this.Size = new Size(casillas * 40, casillas * 40);
            for(int i = 0; i < casillas; i++)
            {
                for(int j = 0; j < casillas; j++)
                {
                    mapa[i, j] = new Button();
                    mapa[i, j].Width = 40;
                    mapa[i, j].Height = 40;
                    mapa[i, j].Name = String.Format(i+" "+j);
                    mapa[i, j].Top = i * 40;
                    mapa[i, j].Left = j * 40;
                    mapa[i, j].Click += mapa_Click;
                    this.Controls.Add(mapa[i, j]);
                }
            }
            colocarBombas(casillas, dificultad);//coloca las bombas
        }

        private void mapa_Click(object sender, EventArgs e)
        {
            Button aux = sender as Button;
            if ((String)aux.Tag == "Bomba")//si el boton era una bomba
            {
                aux.Image = Image.FromFile("mina.png");
                MessageBox.Show("BUMMMMM!!!!!!! has perdido la partida.");
                Application.Restart();
                //aux.Tag = "clickado";
            }
            else//si el boton no era una bomba
            {
                aux.Tag = "clickado";//se le da el estatus de comprobado
                aux.Text = bombasCerca(aux);
                if (aux.Text == "0")//se le da color en funcion del numero de bombas cercanas
                {
                    aux.BackColor = Color.Beige;
                    aux.Text = "";
                }
                if (aux.Text == "1")
                {
                    aux.BackColor = Color.LightYellow;
                }
                if (aux.Text == "2")
                {
                    aux.BackColor = Color.Orange;
                }
                if (aux.Text == "3")
                {
                    aux.BackColor = Color.Red;
                }
                if (aux.Text == "4")
                {
                    aux.BackColor = Color.Purple;
                }
                if (aux.Text == "5")
                {
                    aux.BackColor = Color.Gray;
                }
                if (aux.Text == "6")
                {
                    aux.BackColor = Color.Gold;
                }
                if (aux.Text == "7")
                {
                    aux.BackColor = Color.Fuchsia;
                }
                if (aux.Text == "8")
                {
                    aux.BackColor = Color.DeepSkyBlue;
                }
                if (aux.Text == "9")
                {
                    aux.BackColor = Color.Black;
                }
                victoria();//comprobamos si hemos acabado la partida
            }
            
        }
        private void victoria()//comprobamos si la partida ha acabado porque has destapado todo lo que no son bombas
        {
            bool victoria = true;
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    if ((String)mapa[i, j].Tag != "Bomba" && (String)mapa[i, j].Tag != "clickado")//si todos los elementos estan clicados o son bombas
                    {
                        victoria = false;
                    }

                }
            }
            if (victoria)
            {
                MessageBox.Show("Has ganado la partida");
                Application.Exit();
            }
        }


        private String bombasCerca(Button aux)//calcula el numero de bombas que hay cerca de una casilla
        {
            
            char[] delimiterChars = { ' '};
            string[] coordenadas = aux.Name.Split(delimiterChars);
            int iaux = Int32.Parse(coordenadas[0]);
            int jaux = Int32.Parse(coordenadas[1]);
            int contadorBombas = 0;
            for(int i = iaux - 1; i < iaux + 2; i++)
            {
                for(int j = jaux -1; j < jaux + 2; j++)
                {
                    if (i>=0 && j>=0 && i<tamaño && j< tamaño)
                    {
                        if (mapa[i, j].Name != aux.Name)
                        {
                            if ((String)mapa[i, j].Tag == "Bomba")
                            {
                                contadorBombas++;
                            }
                        }
                    }
                }
            }
            if (contadorBombas == 0)//si no hay bombas al rededor llamamos a abrir bloque
            {
                abrirbloque(aux);
            }
            String nBombas = contadorBombas.ToString();
            return nBombas;
        }
        private void abrirbloque(Button aux)//Cuando encontramos un cero(una casilla sin minas alrededor) comprobamos todas esas casillas que son seguras
        {
            char[] delimiterChars = { ' ' };
            string[] coordenadas = aux.Name.Split(delimiterChars);//obtenemos del nombre del boton las coordenadas
            int iaux = Int32.Parse(coordenadas[0]);
            int jaux = Int32.Parse(coordenadas[1]);
            for (int i = iaux - 1; i < iaux + 2; i++)
            {
                for (int j = jaux - 1; j < jaux + 2; j++)
                {
                    if (i >= 0 && j >= 0 && i < tamaño && j < tamaño)
                    {
                        if (mapa[i, j].Name != aux.Name)
                        {
                            if ((String)mapa[i, j].Tag != "clickado")//para no comprobar casillas que ya hemos comprobado
                            {
                                mapa[i, j].PerformClick();//clicamos en esas cosillas de alrededor porque son seguras
                            }
                        }
                    }
                }
            }
        }

        private void colocarBombas(int casillas, int dificultad)//coloca las bombas en la matriz de botones en funcion de las casillas y  dificultad
        {
            Random minas = new Random();
            int iaux;
            int jaux;
            if (dificultad == 1)//PRINCIPIANTE
            {
                int nBombas = casillas * casillas *10/100;//nº de bombas ha colocar con ese tamaño y dificultad
                for(int i=0; i < nBombas; i++)
                {
                    iaux = minas.Next(0,casillas-1);//obtenemos las coordenadas de la bomba
                    jaux = minas.Next(0,casillas-1);
                    if ((string)mapa[iaux, jaux].Tag != "Bomba")
                    {
                        mapa[iaux, jaux].Tag = "Bomba";
                    }
                    else
                    {
                        i--; //si da la casualidad de que la funcion random devuelve dos veces la misma posición necesitamos repetir
                    }
                    
                }
            }
            if (dificultad == 2)//INTERMEDIO
            {
                int nBombas = casillas * casillas *15/100;//nº de bombas ha colocar con ese tamaño y dificultad
                for (int i = 0; i < nBombas; i++)
                {
                    iaux = minas.Next(0, casillas - 1);
                    jaux = minas.Next(0, casillas - 1);
                    if ((string)mapa[iaux, jaux].Tag != "Bomba")
                    {
                        mapa[iaux, jaux].Tag = "Bomba";
                    }
                    else
                    {
                        i--; //si da la casualidad de que la funcion random devuelve dos veces la misma posición necesitamos repetir
                    }
                }
            }
            if (dificultad == 3)//AVANZADO
            {
                int nBombas = casillas * casillas *20/100;//nº de bombas ha colocar con ese tamaño y dificultad
                for (int i = 0; i < nBombas; i++)
                {
                    iaux = minas.Next(0, casillas - 1);
                    jaux = minas.Next(0, casillas - 1);
                    if ((string)mapa[iaux, jaux].Tag != "Bomba")
                    {
                        mapa[iaux, jaux].Tag = "Bomba";//colocamos la bomba en la casilla que nos dice la funcion random
                    }
                    else
                    {
                        i--; //si da la casualidad de que la funcion random devuelve dos veces la misma posición necesitamos repetir
                    }

                }

            }
        }
    }
}
