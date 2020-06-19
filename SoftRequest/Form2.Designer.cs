namespace SoftRequest
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.realizar_pedido = new System.Windows.Forms.Button();
            this.vizualizar_ementa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numero = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // realizar_pedido
            // 
            this.realizar_pedido.BackColor = System.Drawing.Color.Transparent;
            this.realizar_pedido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.realizar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.realizar_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizar_pedido.ForeColor = System.Drawing.Color.Transparent;
            this.realizar_pedido.Image = ((System.Drawing.Image)(resources.GetObject("realizar_pedido.Image")));
            this.realizar_pedido.Location = new System.Drawing.Point(154, 313);
            this.realizar_pedido.Name = "realizar_pedido";
            this.realizar_pedido.Size = new System.Drawing.Size(780, 150);
            this.realizar_pedido.TabIndex = 0;
            this.realizar_pedido.UseVisualStyleBackColor = false;
            this.realizar_pedido.Click += new System.EventHandler(this.realizar_pedido_Click);
            // 
            // vizualizar_ementa
            // 
            this.vizualizar_ementa.BackColor = System.Drawing.Color.Transparent;
            this.vizualizar_ementa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vizualizar_ementa.ForeColor = System.Drawing.Color.Transparent;
            this.vizualizar_ementa.Image = ((System.Drawing.Image)(resources.GetObject("vizualizar_ementa.Image")));
            this.vizualizar_ementa.Location = new System.Drawing.Point(154, 469);
            this.vizualizar_ementa.Name = "vizualizar_ementa";
            this.vizualizar_ementa.Size = new System.Drawing.Size(780, 150);
            this.vizualizar_ementa.TabIndex = 1;
            this.vizualizar_ementa.UseVisualStyleBackColor = false;
            this.vizualizar_ementa.Click += new System.EventHandler(this.vizualizar_ementa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1120, 550);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 101);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.numero.Location = new System.Drawing.Point(1148, 656);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(67, 13);
            this.numero.TabIndex = 3;
            this.numero.Text = "253 000 000";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.email.Location = new System.Drawing.Point(1122, 669);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(117, 13);
            this.email.TabIndex = 4;
            this.email.Text = "softrequest@gmail.com";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(128)))));
            this.nome.Location = new System.Drawing.Point(266, 69);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(755, 156);
            this.nome.TabIndex = 5;
            this.nome.Text = "NOME DO RESTAURANTE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
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
            this.sair.TabIndex = 18;
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.email);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vizualizar_ementa);
            this.Controls.Add(this.realizar_pedido);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button realizar_pedido;
        private System.Windows.Forms.Button vizualizar_ementa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button sair;
    }
}

