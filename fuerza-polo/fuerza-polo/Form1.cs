using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuerza_polo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaramos las variables
            double angulo1, angulo2, fuerza1, fuerza2,fx,fy, absolutoF, anguloTotal, radianes;

            angulo1 = Convert.ToDouble(txtAngulo1.Text);
            angulo2 = Convert.ToDouble(txtAngulo2.Text);
            fuerza1 = Convert.ToDouble(txtFuerza1.Text);
            fuerza2 = Convert.ToDouble(txtFuerza2.Text);

            //calculaos las sumatorias de fx y fy, el valor absoluto de f 
            fx = fuerza1 * Math.Cos(angulo1) + fuerza2 * Math.Cos(angulo2);
            txtFx.Text = fx.ToString();

            fy = fuerza1 * Math.Sin(angulo1) + fuerza2 * Math.Sin(angulo2);
            txtFy.Text = fy.ToString();

            anguloTotal = Math.Atan(fy/fx);
            txtAnguloTotal.Text = anguloTotal.ToString();
            //convertimos en radianes 

            radianes = (anguloTotal * Math.PI) / 180;
            txtRadianes.Text = radianes.ToString();
          
            //calculamos el valor absoluto de f
            absolutoF = Math.Pow((fx*fx + fy*fy),0.5);
            txtAbsolutoF.Text = absolutoF.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Image = Image.FromFile("grafica.png");
        }
    }
}