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

                ResultadoLB.Text = "Precio costo: " + Math.Round(precioCosto, 2).ToString() + "\n" + "IVA: " + Math.Round(iva).ToString();
            } else
            {
                ResultadoLB.Text = "Ingresa un valor primero.";
            }
            
        }
    }
}
