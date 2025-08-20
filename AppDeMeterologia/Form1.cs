using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeMeterologia
{
    public partial class fmTela : Form
    {
        public fmTela()
        {
            InitializeComponent();
        }

        private void txbClima_TextChanged(object sender, EventArgs e)
        {
   
            
        }

        private void txbClima_KeyPress(object sender, KeyPressEventArgs e)
        {
            //impedir a pessoa de colocar letras no peso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            if (txbClima.Text == "")
            {
                //mostrar erro se o usuário não adicionar nada
                MessageBox.Show("O valor não pode estar vazio!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //mudar cor de fundo para deixar claro o erro do usuário
                txbClima.BackColor = Color.IndianRed;
                txbClima.ForeColor = Color.WhiteSmoke;

                return;
            }
            else
            {
                //retornar ao normal se estiver certo
                txbClima.BackColor = Color.White;
                txbClima.ForeColor = Color.Black;
            }

            double Clima = double.Parse(txbClima.Text);
            if (Clima <= 15)
            {
                picboxClima.Image = Properties.Resources.Neve;
            }
            else if (Clima >= 15 & Clima <= 30)
            {
                picboxClima.Image = Properties.Resources.SolNuvem;
            }
            else
            {
                picboxClima.Image = Properties.Resources.SolEscaldante;
            }

            lblData.Text = DateTime.Now.ToString();
        }

        private void txbClima_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnVerificar.PerformClick();
            }
        }
    }
}
