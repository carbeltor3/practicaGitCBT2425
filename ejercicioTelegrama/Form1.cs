using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama 
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rbtUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else if(rbtOrdinario.Checked)
            {
                //si no esta marcado chkUrgente el tipoTelegrama es o
                tipoTelegrama = 'o';
            }
            //Obtengo el número de palabras que forma el telegrama
            //primero separamos las palabras 
            string[] palabras = textoTelegrama.Split(' ');
            //y despues contamos el numero de palabras
            numPalabras = palabras.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 3;
                }
                else
                {
                    coste = 0.5 * numPalabras;
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 6;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
                txtPrecio.Text = coste.ToString() + " euros";
            }

        
    }
    }

