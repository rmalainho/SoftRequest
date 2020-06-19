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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void realizar_pedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            var realizarpedido = new Form3();
            realizarpedido.Show();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var menuprincipal = new Form2();
            menuprincipal.Show();
        }

        

        private void entrada_ementa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                caixa_texto.Text = entrada_ementa.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void pratos_ementa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                caixa_texto2.Text = pratos_ementa.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void sobremesa_ementa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                caixa_texto3.Text = sobremesa_ementa.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void bebidas_ementa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                caixa_texto4.Text = bebidas_ementa.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void alterar_ementa_Click(object sender, EventArgs e)
        {

            int entrada = entrada_ementa.SelectedIndex;
            entrada_ementa.Items.RemoveAt(entrada);
            entrada_ementa.Items.Insert(entrada, caixa_texto.Text);

        }

        private void alterar_ementa2_Click(object sender, EventArgs e)
        {
            int pratos = pratos_ementa.SelectedIndex;
            pratos_ementa.Items.RemoveAt(pratos);
            pratos_ementa.Items.Insert(pratos, caixa_texto2.Text);
        }

        private void alterar_ementa3_Click(object sender, EventArgs e)
        {
            int sobremesa = sobremesa_ementa.SelectedIndex;
            sobremesa_ementa.Items.RemoveAt(sobremesa);
            sobremesa_ementa.Items.Insert(sobremesa, caixa_texto3.Text);
        }

        private void alterar_ementa4_Click(object sender, EventArgs e)
        {
            int bebidas = bebidas_ementa.SelectedIndex;
            bebidas_ementa.Items.RemoveAt(bebidas);
            bebidas_ementa.Items.Insert(bebidas, caixa_texto4.Text);
        }
    }
}
