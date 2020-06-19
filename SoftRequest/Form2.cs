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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void realizar_pedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            var realizarpedido = new Form3();
            realizarpedido.Show();
        }

        private void vizualizar_ementa_Click(object sender, EventArgs e)
        {
            this.Hide();
            var vizualizarementa = new Form4();
            vizualizarementa.Show();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }
    }
}
