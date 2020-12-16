using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertir_numeros_arabigos_a_romanos
{
    public partial class Form1 : Form
    {
        Arabigo mArabigo;
        Romano mRomano;    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mArabigo = new Arabigo();
            string romanNumber = txtboxRomano.Text.ToString();
            int arabigo = mArabigo.Simplerconverter(romanNumber);
            lblRomanoAArabigo.Text = "" + arabigo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mRomano = new Romano();
            int arab = int.Parse(txtBoxArabigo.Text.ToString());
            string roman = mRomano.ConvertirArabigoaRomano(arab);
            lblArabigoARomano.Text = roman;

        }

      

        private void botonSalida_Click(object sender, EventArgs e)
        {
            Close();
        }


        }
    }
    



