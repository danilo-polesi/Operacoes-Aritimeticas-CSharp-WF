using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm    {
        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200, TextShade.BLACK);


         
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtN1.Text = "0";
            txtN2.Text = "0";
            lblResultado.Text = " ";
        }

        private void btbAdicionar_Click(object sender, EventArgs e)
        {
            double n1, n2, result;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            result = n1 + n2;
            lblResultado.Text = (result.ToString());
            txtN1.Focus();

         }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double n1, n2, result;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            result = n1 - n2;
            lblResultado.Text = (result.ToString());
            txtN1.Focus();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double n1, n2, result;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            result = n1 * n2;
            lblResultado.Text = (result.ToString());
            txtN1.Focus();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double n1, n2, result;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            

            if (n2 != 0 && n1 >= 1) {

                result = n1 / n2;
                lblResultado.Text = (result.ToString());
                txtN1.Focus();

            } else {

                MessageBox.Show("Divizão impossível!", "Não estudou não né!?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtN2.Focus();

            }                    

        }

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
            
        }

        private void txtN2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
         
        }

        private void txtN1_MouseClick(object sender, MouseEventArgs e)
        {
            txtN1.Clear();
        }

        private void txtN2_MouseClick(object sender, MouseEventArgs e)
        {
            txtN2.Clear();
        }
    }
}
