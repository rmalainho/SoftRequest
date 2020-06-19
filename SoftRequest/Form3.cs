using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftRequest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cancelar_pedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuprincipal = new Form2();
            menuprincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var finalizarpedido = new Form5();
            finalizarpedido.Show();
        }

        public static string SetValueForText1 = "";

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
