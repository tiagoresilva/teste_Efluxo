
namespace Teste_Efluxo
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Selecao = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ativos_tabela_cliente = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo_cliente = new System.Windows.Forms.TextBox();
            this.idade_cliente = new System.Windows.Forms.TextBox();
            this.nome_cliente = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sair = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comprar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Selecao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ativos_tabela_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Selecao
            // 
            this.Selecao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Selecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.Selecao.Controls.Add(this.minimizar);
            this.Selecao.Controls.Add(this.maximizar);
            this.Selecao.Controls.Add(this.button1);
            this.Selecao.Controls.Add(this.textBox6);
            this.Selecao.Controls.Add(this.ativos_tabela_cliente);
            this.Selecao.Controls.Add(this.saldo_cliente);
            this.Selecao.Controls.Add(this.idade_cliente);
            this.Selecao.Controls.Add(this.nome_cliente);
            this.Selecao.Controls.Add(this.textBox5);
            this.Selecao.Controls.Add(this.label3);
            this.Selecao.Controls.Add(this.comboBox1);
            this.Selecao.Controls.Add(this.textBox1);
            this.Selecao.Controls.Add(this.textBox4);
            this.Selecao.Controls.Add(this.sair);
            this.Selecao.Controls.Add(this.textBox3);
            this.Selecao.Controls.Add(this.label2);
            this.Selecao.Controls.Add(this.vender);
            this.Selecao.Controls.Add(this.label1);
            this.Selecao.Controls.Add(this.comprar);
            this.Selecao.Controls.Add(this.textBox2);
            this.Selecao.Controls.Add(this.pictureBox1);
            this.Selecao.Location = new System.Drawing.Point(0, 0);
            this.Selecao.Name = "Selecao";
            this.Selecao.Size = new System.Drawing.Size(1600, 800);
            this.Selecao.TabIndex = 1;
            this.Selecao.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            this.Selecao.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizar.ForeColor = System.Drawing.SystemColors.Window;
            this.minimizar.Location = new System.Drawing.Point(1455, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(43, 38);
            this.minimizar.TabIndex = 49;
            this.minimizar.Text = "-";
            this.minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.ForeColor = System.Drawing.SystemColors.Window;
            this.maximizar.Location = new System.Drawing.Point(1504, 3);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(43, 42);
            this.maximizar.TabIndex = 48;
            this.maximizar.Text = "O";
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(1553, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 42);
            this.button1.TabIndex = 47;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.fechar_Click_1);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(19, 417);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(476, 41);
            this.textBox6.TabIndex = 46;
            this.textBox6.Text = "Ativos";
            // 
            // ativos_tabela_cliente
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ativos_tabela_cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ativos_tabela_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ativos_tabela_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Grupo,
            this.Valor});
            this.ativos_tabela_cliente.Location = new System.Drawing.Point(19, 478);
            this.ativos_tabela_cliente.Name = "ativos_tabela_cliente";
            this.ativos_tabela_cliente.RowHeadersWidth = 62;
            this.ativos_tabela_cliente.RowTemplate.Height = 33;
            this.ativos_tabela_cliente.Size = new System.Drawing.Size(1536, 293);
            this.ativos_tabela_cliente.TabIndex = 45;
            this.ativos_tabela_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "ativo";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 500;
            this.Nome.Name = "Nome";
            this.Nome.Width = 500;
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "grupo";
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.MinimumWidth = 500;
            this.Grupo.Name = "Grupo";
            this.Grupo.Width = 500;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 500;
            this.Valor.Name = "Valor";
            this.Valor.Width = 500;
            // 
            // saldo_cliente
            // 
            this.saldo_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.saldo_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saldo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saldo_cliente.ForeColor = System.Drawing.SystemColors.Window;
            this.saldo_cliente.Location = new System.Drawing.Point(1184, 417);
            this.saldo_cliente.Margin = new System.Windows.Forms.Padding(0);
            this.saldo_cliente.Name = "saldo_cliente";
            this.saldo_cliente.Size = new System.Drawing.Size(364, 41);
            this.saldo_cliente.TabIndex = 44;
            this.saldo_cliente.Text = "30";
            this.saldo_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // idade_cliente
            // 
            this.idade_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.idade_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idade_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idade_cliente.ForeColor = System.Drawing.SystemColors.Window;
            this.idade_cliente.Location = new System.Drawing.Point(1504, 203);
            this.idade_cliente.Margin = new System.Windows.Forms.Padding(0);
            this.idade_cliente.Name = "idade_cliente";
            this.idade_cliente.Size = new System.Drawing.Size(87, 41);
            this.idade_cliente.TabIndex = 43;
            this.idade_cliente.Text = "30";
            this.idade_cliente.TextChanged += new System.EventHandler(this.idade_cliente_TextChanged);
            // 
            // nome_cliente
            // 
            this.nome_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.nome_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nome_cliente.ForeColor = System.Drawing.SystemColors.Window;
            this.nome_cliente.Location = new System.Drawing.Point(1237, 203);
            this.nome_cliente.Margin = new System.Windows.Forms.Padding(0);
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.Size = new System.Drawing.Size(253, 41);
            this.nome_cliente.TabIndex = 42;
            this.nome_cliente.Text = "Nome";
            this.nome_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nome_cliente.TextChanged += new System.EventHandler(this.nome_cliente_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(815, 259);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(261, 28);
            this.textBox5.TabIndex = 41;
            this.textBox5.Text = "Valor R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(1411, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "|";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(715, 37);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(1279, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 28);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Cliente";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(19, 259);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(476, 28);
            this.textBox4.TabIndex = 39;
            this.textBox4.Text = "Ativos para compra e venda";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // sair
            // 
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(130)))), ((int)(((byte)(38)))));
            this.sair.Location = new System.Drawing.Point(1436, 66);
            this.sair.Margin = new System.Windows.Forms.Padding(0);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(112, 43);
            this.sair.TabIndex = 11;
            this.sair.Text = "sair";
            this.sair.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(815, 295);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 39);
            this.textBox3.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(367, 266);
            this.label2.MaximumSize = new System.Drawing.Size(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 0);
            this.label2.TabIndex = 10;
            // 
            // vender
            // 
            this.vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vender.Location = new System.Drawing.Point(1391, 293);
            this.vender.Name = "vender";
            this.vender.Size = new System.Drawing.Size(157, 39);
            this.vender.TabIndex = 37;
            this.vender.Text = "Vender";
            this.vender.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(19, 148);
            this.label1.MaximumSize = new System.Drawing.Size(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 2);
            this.label1.TabIndex = 9;
            // 
            // comprar
            // 
            this.comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comprar.Location = new System.Drawing.Point(1209, 293);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(157, 39);
            this.comprar.TabIndex = 36;
            this.comprar.Text = "Comprar";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(19, 189);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(476, 41);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = "Minha Carteira";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Teste_Efluxo.Properties.Resources.logo_e;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 138);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.Selecao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Selecao.ResumeLayout(false);
            this.Selecao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ativos_tabela_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel Selecao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button vender;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox idade_cliente;
        private System.Windows.Forms.TextBox nome_cliente;
        private System.Windows.Forms.TextBox saldo_cliente;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView ativos_tabela_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button button1;
    }
}