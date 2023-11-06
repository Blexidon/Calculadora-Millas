using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Millas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            CargarTextBoxs();
        }

        #region VARIABLES GLOBALES
        double Kilometros = 0, Millas = 0, Centimetros = 0, Pulgadas = 0, Kilos = 0, Libras = 0, Grados = 0, Radianes = 0;
        #endregion

        #region EVENTOS BOTONES / SOLO NUMEROS 
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region BUTTON_CLICKS + LOGICA DE TRASNFORMACIONES
        private void button1_Click(object sender, EventArgs e)
        {
            
            Kilometros = Convert.ToInt32(textBox1.Text);
            label1.Text = Kilometros.ToString();
            Millas =  Kilometros * 0.621371;
            label8.Text = Millas.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Millas = Convert.ToInt32(textBox2.Text);
            label2.Text = Millas.ToString();
            Kilometros = Millas * 1.609;
            label7.Text = Kilometros.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Centimetros= Convert.ToInt32(textBox3.Text);
            label12.Text= Centimetros.ToString();
            Pulgadas = Centimetros * 0.393701;
            label9.Text = Pulgadas.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Pulgadas= Convert.ToInt32(textBox4.Text);
            label16.Text= Pulgadas.ToString();
            Centimetros = Pulgadas * 2.54;
            label13.Text= Centimetros.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kilos = Convert.ToInt32(textBox5.Text);
            label20.Text= Kilos.ToString();
            Libras = Kilos * 2.20462;
            label17.Text= Libras.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Libras= Convert.ToInt32(textBox6.Text);
            label24.Text= Libras.ToString();
            Kilos = Libras * 0.453592;
            label21.Text = Kilos.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Grados= Convert.ToInt32(textBox7.Text);
            label28.Text= Grados.ToString();
            Radianes = Grados* 0.0174533;
            label25.Text= Radianes.ToString();
                
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Radianes= Convert.ToInt32(textBox8.Text);

            label32.Text= Radianes.ToString();
            Grados = Radianes * 57.2958;
            label29.Text= Grados.ToString();
        }

        #endregion

        #region METODOS

        private void CargarTextBoxs()
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            label1.Text = "0";
            label2.Text = "0";
            label8.Text = "0";
            label7.Text = "0";
            label12.Text = "0";
            label9.Text  = "0";
            label16.Text = "0";
            label13.Text = "0";
            label20.Text = "0";
            label17.Text = "0";
            label24.Text = "0";
            label21.Text = "0";
            label28.Text = "0";
            label25.Text = "0";
            label32.Text = "0";
            label29.Text = "0";

        }

        #endregion

    }
}
