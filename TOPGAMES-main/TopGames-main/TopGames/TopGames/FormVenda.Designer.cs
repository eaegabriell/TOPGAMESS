namespace TopGames
{
    partial class FormVenda
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxProdutos = new System.Windows.Forms.ComboBox();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAttVenda = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Location = new System.Drawing.Point(490, 278);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(264, 23);
            this.btnLimpar.TabIndex = 87;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxProdutos
            // 
            this.cbxProdutos.FormattingEnabled = true;
            this.cbxProdutos.Location = new System.Drawing.Point(15, 203);
            this.cbxProdutos.Name = "cbxProdutos";
            this.cbxProdutos.Size = new System.Drawing.Size(423, 21);
            this.cbxProdutos.TabIndex = 84;
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.GridColor = System.Drawing.Color.Thistle;
            this.dgvVenda.Location = new System.Drawing.Point(10, 342);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.Size = new System.Drawing.Size(454, 140);
            this.dgvVenda.TabIndex = 83;
            this.dgvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellContentClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Location = new System.Drawing.Point(636, 307);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 23);
            this.btnVoltar.TabIndex = 82;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Red;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletar.Location = new System.Drawing.Point(490, 307);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(140, 23);
            this.btnDeletar.TabIndex = 81;
            this.btnDeletar.Text = "Deletar Venda";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAttVenda
            // 
            this.btnAttVenda.BackColor = System.Drawing.Color.Red;
            this.btnAttVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttVenda.Location = new System.Drawing.Point(490, 249);
            this.btnAttVenda.Name = "btnAttVenda";
            this.btnAttVenda.Size = new System.Drawing.Size(264, 23);
            this.btnAttVenda.TabIndex = 80;
            this.btnAttVenda.Text = "Editar Venda";
            this.btnAttVenda.UseVisualStyleBackColor = false;
            this.btnAttVenda.Click += new System.EventHandler(this.btnAttVenda_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Yellow;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.Location = new System.Drawing.Point(490, 220);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(264, 23);
            this.btnVender.TabIndex = 79;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(181, 20);
            this.txtID.TabIndex = 75;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 13);
            this.lblID.TabIndex = 74;
            this.lblID.Text = "ID Venda";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalizar.Location = new System.Drawing.Point(202, 23);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 73;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(15, 92);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(423, 21);
            this.cbxClientes.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Clientes";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(15, 265);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(87, 20);
            this.txtQuantidade.TabIndex = 91;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Quantidade";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(265, 265);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(164, 35);
            this.txtTotal.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Total";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 95;
            this.checkBox1.Text = "Jogo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Selecione o tipo de produto";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 177);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 17);
            this.checkBox2.TabIndex = 97;
            this.checkBox2.Text = "Artigo";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.MouseCaptureChanged += new System.EventHandler(this.checkBox2_MouseCaptureChanged);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.BackColor = System.Drawing.Color.Red;
            this.btnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovaVenda.Location = new System.Drawing.Point(283, 23);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(155, 23);
            this.btnNovaVenda.TabIndex = 98;
            this.btnNovaVenda.Text = "Iniciar venda";
            this.btnNovaVenda.UseVisualStyleBackColor = false;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 99;
            this.label5.Text = "R$";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::TopGames.Properties.Resources._8;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(490, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(285, 201);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 108;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::TopGames.Properties.Resources._1111111111111111111111111111111111;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(503, 336);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(66, 57);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 107;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::TopGames.Properties.Resources._1111111111111111111111111111111111;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(71, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 103;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TopGames.Properties.Resources._1111111111111111111111111111111111;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(108, 255);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 102;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TopGames.Properties.Resources._111111111111111111111111111111111;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(167, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 101;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TopGames.Properties.Resources._1111111111111111111111111111111111;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(415, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TopGames.Properties.Resources._11;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(490, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::TopGames.Properties.Resources._1111111111111111111111111111111111;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(490, 177);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 109;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::TopGames.Properties.Resources._1111111111111111111111111111111111;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(428, 307);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 110;
            this.pictureBox8.TabStop = false;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(769, 505);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cbxClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cbxProdutos);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAttVenda);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnLocalizar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxProdutos;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAttVenda;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}