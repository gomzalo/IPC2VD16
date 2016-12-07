using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201318652_HojaDeTrabajo_IPC2VD16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IVAButton_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(XTB.Text);
            if (XTB.Text != null)
            {
                double precioCosto = precio / 1.12;
                double iva = precioCosto * 0.12;

                ResultadoLB.Text = "Precio costo: Q " + Math.Round(precioCosto, 2).ToString() + "\n" + "IVA: Q " + Math.Round(iva).ToString();
            } else
            {
                ResultadoLB.Text = "Ingresa un valor primero.";
            }
            
        }

        private void HipotenusaButton_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(XTB.Text);
            double c = Convert.ToDouble(YTB.Text);
            double a = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2));
            ResultadoLB.Text = "a: " + Math.Round(a, 2);
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            XTB.Text = "";
            YTB.Text = "";
            ZTB.Text = "";
        }

        private void DistanciaButton_Click(object sender, EventArgs e)
        {
            double d = ((Convert.ToDouble(XTB.Text) + Convert.ToDouble(YTB.Text)) / 2) * Convert.ToDouble(ZTB.Text);
            ResultadoLB.Text = "Distancia: " + d.ToString() + "metros.";
        }

        private void FCuadraticaButton_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(XTB.Text);
            double b = Convert.ToDouble(YTB.Text);
            double c = Convert.ToDouble(ZTB.Text);
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (a != 0)
            {
                if (d < 0)
                {
                    ResultadoLB.Text = "Tiene raices imaginarias";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    ResultadoLB.Text = "X1 = " + x1.ToString() + "\n X2 = " + x2.ToString();
                }
            }
        }
    }
}
