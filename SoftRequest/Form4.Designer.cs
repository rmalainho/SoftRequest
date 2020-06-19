namespace SoftRequest
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.realizar_pedido = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.entrada_ementa = new System.Windows.Forms.ListBox();
            this.alterar_ementa = new System.Windows.Forms.Button();
            this.caixa_texto = new System.Windows.Forms.TextBox();
            this.pratos_ementa = new System.Windows.Forms.ListBox();
            this.sobremesa_ementa = new System.Windows.Forms.ListBox();
            this.bebidas_ementa = new System.Windows.Forms.ListBox();
            this.alterar_ementa2 = new System.Windows.Forms.Button();
            this.alterar_ementa3 = new System.Windows.Forms.Button();
            this.alterar_ementa4 = new System.Windows.Forms.Button();
            this.caixa_texto2 = new System.Windows.Forms.TextBox();
            this.caixa_texto3 = new System.Windows.Forms.TextBox();
            this.caixa_texto4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // realizar_pedido
            // 
            this.realizar_pedido.BackColor = System.Drawing.Color.Transparent;
            this.realizar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.realizar_pedido.ForeColor = System.Drawing.Color.Transparent;
            this.realizar_pedido.Image = ((System.Drawing.Image)(resources.GetObject("realizar_pedido.Image")));
            this.realizar_pedido.Location = new System.Drawing.Point(848, 30);
            this.realizar_pedido.Name = "realizar_pedido";
            this.realizar_pedido.Size = new System.Drawing.Size(400, 86);
            this.realizar_pedido.TabIndex = 0;
            this.realizar_pedido.UseVisualStyleBackColor = false;
            this.realizar_pedido.Click += new System.EventHandler(this.realizar_pedido_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.Transparent;
            this.voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltar.BackgroundImage")));
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltar.ForeColor = System.Drawing.Color.Transparent;
            this.voltar.Location = new System.Drawing.Point(442, 27);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(400, 92);
            this.voltar.TabIndex = 1;
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(147, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTRADAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(724, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "SOBREMESAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(404, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "PRATOS PRINCIPAIS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(1049, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "BEBIDAS";
            // 
            // entrada_ementa
            // 
            this.entrada_ementa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.entrada_ementa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrada_ementa.ForeColor = System.Drawing.SystemColors.Window;
            this.entrada_ementa.FormattingEnabled = true;
            this.entrada_ementa.ItemHeight = 20;
            this.entrada_ementa.Items.AddRange(new object[] {
            "Entrada 1",
            "Entrada 2",
            "Entrada 3",
            "Entrada 4",
            "Entrada 5",
            "Entrada 6",
            "Entrada 7",
            "Entrada 8",
            "Entrada 9",
            "Entrada 10"});
            this.entrada_ementa.Location = new System.Drawing.Point(70, 245);
            this.entrada_ementa.Name = "entrada_ementa";
            this.entrada_ementa.Size = new System.Drawing.Size(250, 224);
            this.entrada_ementa.TabIndex = 7;
            this.entrada_ementa.SelectedIndexChanged += new System.EventHandler(this.entrada_ementa_SelectedIndexChanged);
            // 
            // alterar_ementa
            // 
            this.alterar_ementa.BackColor = System.Drawing.Color.Transparent;
            this.alterar_ementa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alterar_ementa.BackgroundImage")));
            this.alterar_ementa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterar_ementa.ForeColor = System.Drawing.Color.Transparent;
            this.alterar_ementa.Location = new System.Drawing.Point(89, 521);
            this.alterar_ementa.Name = "alterar_ementa";
            this.alterar_ementa.Size = new System.Drawing.Size(200, 45);
            this.alterar_ementa.TabIndex = 8;
            this.alterar_ementa.UseVisualStyleBackColor = false;
            this.alterar_ementa.Click += new System.EventHandler(this.alterar_ementa_Click);
            // 
            // caixa_texto
            // 
            this.caixa_texto.Location = new System.Drawing.Point(70, 495);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(250, 20);
            this.caixa_texto.TabIndex = 9;
            // 
            // pratos_ementa
            // 
            this.pratos_ementa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.pratos_ementa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pratos_ementa.ForeColor = System.Drawing.SystemColors.Window;
            this.pratos_ementa.FormattingEnabled = true;
            this.pratos_ementa.ItemHeight = 20;
            this.pratos_ementa.Items.AddRange(new object[] {
            "Prato 1",
            "Prato 2",
            "Prato 3",
            "Prato 4",
            "Prato 5",
            "Prato 6",
            "Prato 7",
            "Prato 8",
            "Prato 9",
            "Prato 10"});
            this.pratos_ementa.Location = new System.Drawing.Point(366, 245);
            this.pratos_ementa.Name = "pratos_ementa";
            this.pratos_ementa.Size = new System.Drawing.Size(250, 224);
            this.pratos_ementa.TabIndex = 10;
            this.pratos_ementa.SelectedIndexChanged += new System.EventHandler(this.pratos_ementa_SelectedIndexChanged);
            // 
            // sobremesa_ementa
            // 
            this.sobremesa_ementa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.sobremesa_ementa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobremesa_ementa.ForeColor = System.Drawing.SystemColors.Window;
            this.sobremesa_ementa.FormattingEnabled = true;
            this.sobremesa_ementa.ItemHeight = 20;
            this.sobremesa_ementa.Items.AddRange(new object[] {
            "Sobremesa 1",
            "Sobremesa 2",
            "Sobremesa 3",
            "Sobremesa 4",
            "Sobremesa 5",
            "Sobremesa 6",
            "Sobremesa 7",
            "Sobremesa 8",
            "Sobremesa 9",
            "Sobremesa 10"});
            this.sobremesa_ementa.Location = new System.Drawing.Point(668, 245);
            this.sobremesa_ementa.Name = "sobremesa_ementa";
            this.sobremesa_ementa.Size = new System.Drawing.Size(250, 224);
            this.sobremesa_ementa.TabIndex = 11;
            this.sobremesa_ementa.SelectedIndexChanged += new System.EventHandler(this.sobremesa_ementa_SelectedIndexChanged);
            // 
            // bebidas_ementa
            // 
            this.bebidas_ementa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.bebidas_ementa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bebidas_ementa.ForeColor = System.Drawing.SystemColors.Menu;
            this.bebidas_ementa.FormattingEnabled = true;
            this.bebidas_ementa.ItemHeight = 20;
            this.bebidas_ementa.Items.AddRange(new object[] {
            "Bebida 1",
            "Bebida 2",
            "Bebida 3",
            "Bebida 4",
            "Bebida 5",
            "Bebida 6",
            "Bebida 7",
            "Bebida 8",
            "Bebida 9",
            "Bebida 10"});
            this.bebidas_ementa.Location = new System.Drawing.Point(963, 245);
            this.bebidas_ementa.Name = "bebidas_ementa";
            this.bebidas_ementa.Size = new System.Drawing.Size(250, 224);
            this.bebidas_ementa.TabIndex = 12;
            this.bebidas_ementa.SelectedIndexChanged += new System.EventHandler(this.bebidas_ementa_SelectedIndexChanged);
            // 
            // alterar_ementa2
            // 
            this.alterar_ementa2.BackColor = System.Drawing.Color.Transparent;
            this.alterar_ementa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alterar_ementa2.BackgroundImage")));
            this.alterar_ementa2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterar_ementa2.ForeColor = System.Drawing.Color.Transparent;
            this.alterar_ementa2.Location = new System.Drawing.Point(388, 521);
            this.alterar_ementa2.Name = "alterar_ementa2";
            this.alterar_ementa2.Size = new System.Drawing.Size(200, 45);
            this.alterar_ementa2.TabIndex = 13;
            this.alterar_ementa2.UseVisualStyleBackColor = false;
            this.alterar_ementa2.Click += new System.EventHandler(this.alterar_ementa2_Click);
            // 
            // alterar_ementa3
            // 
            this.alterar_ementa3.BackColor = System.Drawing.Color.Transparent;
            this.alterar_ementa3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alterar_ementa3.BackgroundImage")));
            this.alterar_ementa3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterar_ementa3.ForeColor = System.Drawing.Color.Transparent;
            this.alterar_ementa3.Location = new System.Drawing.Point(692, 521);
            this.alterar_ementa3.Name = "alterar_ementa3";
            this.alterar_ementa3.Size = new System.Drawing.Size(200, 45);
            this.alterar_ementa3.TabIndex = 14;
            this.alterar_ementa3.UseVisualStyleBackColor = false;
            this.alterar_ementa3.Click += new System.EventHandler(this.alterar_ementa3_Click);
            // 
            // alterar_ementa4
            // 
            this.alterar_ementa4.BackColor = System.Drawing.Color.Transparent;
            this.alterar_ementa4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alterar_ementa4.BackgroundImage")));
            this.alterar_ementa4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterar_ementa4.ForeColor = System.Drawing.Color.Transparent;
            this.alterar_ementa4.Location = new System.Drawing.Point(989, 519);
            this.alterar_ementa4.Name = "alterar_ementa4";
            this.alterar_ementa4.Size = new System.Drawing.Size(200, 45);
            this.alterar_ementa4.TabIndex = 15;
            this.alterar_ementa4.UseVisualStyleBackColor = false;
            this.alterar_ementa4.Click += new System.EventHandler(this.alterar_ementa4_Click);
            // 
            // caixa_texto2
            // 
            this.caixa_texto2.Location = new System.Drawing.Point(366, 495);
            this.caixa_texto2.Name = "caixa_texto2";
            this.caixa_texto2.Size = new System.Drawing.Size(250, 20);
            this.caixa_texto2.TabIndex = 16;
            // 
            // caixa_texto3
            // 
            this.caixa_texto3.Location = new System.Drawing.Point(668, 495);
            this.caixa_texto3.Name = "caixa_texto3";
            this.caixa_texto3.Size = new System.Drawing.Size(250, 20);
            this.caixa_texto3.TabIndex = 17;
            // 
            // caixa_texto4
            // 
            this.caixa_texto4.Location = new System.Drawing.Point(963, 493);
            this.caixa_texto4.Name = "caixa_texto4";
            this.caixa_texto4.Size = new System.Drawing.Size(250, 20);
            this.caixa_texto4.TabIndex = 18;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 715);
            this.Controls.Add(this.caixa_texto4);
            this.Controls.Add(this.caixa_texto3);
            this.Controls.Add(this.caixa_texto2);
            this.Controls.Add(this.alterar_ementa4);
            this.Controls.Add(this.alterar_ementa3);
            this.Controls.Add(this.alterar_ementa2);
            this.Controls.Add(this.bebidas_ementa);
            this.Controls.Add(this.sobremesa_ementa);
            this.Controls.Add(this.pratos_ementa);
            this.Controls.Add(this.caixa_texto);
            this.Controls.Add(this.alterar_ementa);
            this.Controls.Add(this.entrada_ementa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.realizar_pedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button realizar_pedido;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox entrada_ementa;
        private System.Windows.Forms.Button alterar_ementa;
        private System.Windows.Forms.TextBox caixa_texto;
        private System.Windows.Forms.ListBox pratos_ementa;
        private System.Windows.Forms.ListBox sobremesa_ementa;
        private System.Windows.Forms.ListBox bebidas_ementa;
        private System.Windows.Forms.Button alterar_ementa2;
        private System.Windows.Forms.Button alterar_ementa3;
        private System.Windows.Forms.Button alterar_ementa4;
        private System.Windows.Forms.TextBox caixa_texto2;
        private System.Windows.Forms.TextBox caixa_texto3;
        private System.Windows.Forms.TextBox caixa_texto4;
    }
}