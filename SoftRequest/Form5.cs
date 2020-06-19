using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftRequest
{
    public partial class Form5 : Form
    {


        public Form5()
        {
            InitializeComponent();

        }

        private void dinheiro_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja confirmar o pagamento?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                recibo_lista.Visible = true;
                dinheiro_button.Enabled = false;
                mb_button.Enabled = false;
                mbway_button.Enabled = false;
            }
            else
            { }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           recibo_lista.Text = Form3.SetValueForText1;
        }

        private void sair_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja voltar para o menu princpial?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                var menuprincipal = new Form2();
                menuprincipal.Show();
            }
            else
            { }
        }

        private void recibo_lista2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mb_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja confirmar o pagamento?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                recibo_lista2.Visible = true;
                dinheiro_button.Enabled = false;
                mb_button.Enabled = false;
                mbway_button.Enabled = false;
            }
            else
            { }
        }

        private void mbway_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja confirmar o pagamento?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                recibo_lista3.Visible = true;
                dinheiro_button.Enabled = false;
                mb_button.Enabled = false;
                mbway_button.Enabled = false;
            }
            else
            { }
        }

        private void recibo_lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
