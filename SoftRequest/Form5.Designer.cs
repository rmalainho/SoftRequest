namespace SoftRequest
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nome = new System.Windows.Forms.Label();
            this.mb_button = new System.Windows.Forms.Button();
            this.mbway_button = new System.Windows.Forms.Button();
            this.dinheiro_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recibo_lista = new System.Windows.Forms.ListBox();
            this.sair = new System.Windows.Forms.Button();
            this.recibo_lista2 = new System.Windows.Forms.ListBox();
            this.recibo_lista3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.nome.Location = new System.Drawing.Point(266, 69);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(755, 156);
            this.nome.TabIndex = 7;
            this.nome.Text = "EFETUAR PAGAMENTO";
            // 
            // mb_button
            // 
            this.mb_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mb_button.BackgroundImage")));
            this.mb_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mb_button.ForeColor = System.Drawing.Color.Black;
            this.mb_button.Location = new System.Drawing.Point(87, 346);
            this.mb_button.Name = "mb_button";
            this.mb_button.Size = new System.Drawing.Size(210, 195);
            this.mb_button.TabIndex = 9;
            this.mb_button.UseVisualStyleBackColor = true;
            this.mb_button.Click += new System.EventHandler(this.mb_button_Click);
            // 
            // mbway_button
            // 
            this.mbway_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbway_button.BackgroundImage")));
            this.mbway_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbway_button.ForeColor = System.Drawing.Color.Black;
            this.mbway_button.Location = new System.Drawing.Point(317, 346);
            this.mbway_button.Name = "mbway_button";
            this.mbway_button.Size = new System.Drawing.Size(210, 195);
            this.mbway_button.TabIndex = 10;
            this.mbway_button.UseVisualStyleBackColor = true;
            this.mbway_button.Click += new System.EventHandler(this.mbway_button_Click);
            // 
            // dinheiro_button
            // 
            this.dinheiro_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dinheiro_button.BackgroundImage")));
            this.dinheiro_button.Location = new System.Drawing.Point(547, 346);
            this.dinheiro_button.Name = "dinheiro_button";
            this.dinheiro_button.Size = new System.Drawing.Size(210, 195);
            this.dinheiro_button.TabIndex = 11;
            this.dinheiro_button.UseVisualStyleBackColor = true;
            this.dinheiro_button.Click += new System.EventHandler(this.dinheiro_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selecionar método de pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Multibanco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "MBWay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dinheiro";
            // 
            // recibo_lista
            // 
            this.recibo_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.recibo_lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recibo_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recibo_lista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.recibo_lista.FormattingEnabled = true;
            this.recibo_lista.ItemHeight = 20;
            this.recibo_lista.Items.AddRange(new object[] {
            "Soft Request",
            "",
            "Número de empregado:",
            "",
            "Pedido:",
            "",
            "\tEntradas:",
            "\tPratos:",
            "\tSobremesas:",
            "\tBebidas:",
            "",
            "Total a pagar:",
            "",
            ""});
            this.recibo_lista.Location = new System.Drawing.Point(832, 288);
            this.recibo_lista.Name = "recibo_lista";
            this.recibo_lista.Size = new System.Drawing.Size(339, 282);
            this.recibo_lista.TabIndex = 16;
            this.recibo_lista.Visible = false;
            this.recibo_lista.SelectedIndexChanged += new System.EventHandler(this.recibo_lista_SelectedIndexChanged);
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.Transparent;
            this.sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sair.BackgroundImage")));
            this.sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sair.ForeColor = System.Drawing.Color.Transparent;
            this.sair.Location = new System.Drawing.Point(1168, 12);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(100, 100);
            this.sair.TabIndex = 17;
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // recibo_lista2
            // 
            this.recibo_lista2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.recibo_lista2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recibo_lista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recibo_lista2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.recibo_lista2.FormattingEnabled = true;
            this.recibo_lista2.ItemHeight = 20;
            this.recibo_lista2.Items.AddRange(new object[] {
            "Soft Request",
            "",
            "Número de empregado:",
            "",
            "Pedido:",
            "",
            "\tEntradas:",
            "\tPratos:",
            "\tSobremesas:",
            "\tBebidas:",
            "",
            "Total a pagar:",
            "",
            "Entidade:",
            "Referência:",
            "Valor:",
            ""});
            this.recibo_lista2.Location = new System.Drawing.Point(832, 288);
            this.recibo_lista2.Name = "recibo_lista2";
            this.recibo_lista2.Size = new System.Drawing.Size(339, 342);
            this.recibo_lista2.TabIndex = 18;
            this.recibo_lista2.Visible = false;
            this.recibo_lista2.SelectedIndexChanged += new System.EventHandler(this.recibo_lista2_SelectedIndexChanged);
            // 
            // recibo_lista3
            // 
            this.recibo_lista3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.recibo_lista3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recibo_lista3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recibo_lista3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.recibo_lista3.FormattingEnabled = true;
            this.recibo_lista3.ItemHeight = 20;
            this.recibo_lista3.Items.AddRange(new object[] {
            "Soft Request",
            "",
            "Número de empregado:",
            "",
            "Pedido:",
            "",
            "\tEntradas:",
            "\tPratos:",
            "\tSobremesas:",
            "\tBebidas:",
            "",
            "Total a pagar:",
            "",
            "Número de telemóvel:",
            "Valor:"});
            this.recibo_lista3.Location = new System.Drawing.Point(832, 288);
            this.recibo_lista3.Name = "recibo_lista3";
            this.recibo_lista3.Size = new System.Drawing.Size(339, 322);
            this.recibo_lista3.TabIndex = 19;
            this.recibo_lista3.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.recibo_lista3);
            this.Controls.Add(this.recibo_lista2);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.recibo_lista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dinheiro_button);
            this.Controls.Add(this.mbway_button);
            this.Controls.Add(this.mb_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nome);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Button mb_button;
        private System.Windows.Forms.Button mbway_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button dinheiro_button;
        public System.Windows.Forms.ListBox recibo_lista;
        private System.Windows.Forms.Button sair;
        public System.Windows.Forms.ListBox recibo_lista2;
        public System.Windows.Forms.ListBox recibo_lista3;
    }
}