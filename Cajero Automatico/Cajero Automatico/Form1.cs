using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(txtcantidad.Text);
            sbyte n = 0;
            string respuesta = " Respuesta: \n ";
            foreach (double denominación in denominaciones)
            {
                while (denominación <= Math.Round(cantidad, 2))
                {
                    n++;
                    cantidad -= denominación;
                }
                if (n > 0)
                {
                    respuesta += n + (denominación > 1 ? " Billetes " : " Monedas ") + denominación + " \n ";
                }
                n = 0;
            }
            lblrespuesta.Text = respuesta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnrealizar_Click(object sender, EventArgs e)
        {
            int a = 0, i, n;
            n = int.Parse(txtnumprimo.Text);
            a = 0;
            for (i = 1; i < (n + 1); i++)

                if (n % i == 0)
                    a++;
            lblprimoresp.Text = ((a != 2) ? n + "  No es primo " : n + "  Si es primo");
                txtnumprimo.Text = "";

        }

        private void btnreali_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtfibocci.Text), a = 0, b = 1, au, i;
            string respuesta = "";
            for (i = 0; i < n; i++)
            { }
                au = a;
                a = b;
            b = au + a;
                respuesta += "la suma de " + a + " es " + b + "\n";
                lblfiboresp.Visible = true;
                lblfiboresp.Text = "" + respuesta;
                txtfibocci.Text = "";





            }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            double cantidad = double.Parse(txtcan.Text);
            double cm = double.Parse(txtefectivo.Text);
            sbyte n = 0;
            double cm2;
            cm2 = cm - cantidad;
            string cambio = "Su cambio es de : \n ";
            foreach (double denominacion in denominaciones)
            { 
            while (denominacion <= Math.Round(cm2, 2))
                { 
            n++;
            cm2 -= denominacion;
            }
            if (n > 0)
            { 
            cambio += n + (denominacion > 1 ? "billetes " : " Monedas ") + denominacion + "\n";
            }
            n = 0;
             }
             lblcambio.Text = cambio;

                                }
    }
    }

      
    