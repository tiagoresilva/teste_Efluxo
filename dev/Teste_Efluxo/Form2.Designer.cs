
namespace Teste_Efluxo
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
            this.Selecao = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.Button();
            this.ativos = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.gerentes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Selecao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Selecao
            // 
            this.Selecao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Selecao.AutoSize = true;
            this.Selecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.Selecao.Controls.Add(this.minimizar);
            this.Selecao.Controls.Add(this.ativos);
            this.Selecao.Controls.Add(this.maximizar);
            this.Selecao.Controls.Add(this.fechar);
            this.Selecao.Controls.Add(this.gerentes);
            this.Selecao.Controls.Add(this.label3);
            this.Selecao.Controls.Add(this.textBox1);
            this.Selecao.Controls.Add(this.sair);
            this.Selecao.Controls.Add(this.label2);
            this.Selecao.Controls.Add(this.label1);
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
            this.minimizar.Location = new System.Drawing.Point(1456, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(43, 38);
            this.minimizar.TabIndex = 18;
            this.minimizar.Text = "-";
            this.minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // ativos
            // 
            this.ativos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.ativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ativos.ForeColor = System.Drawing.SystemColors.Window;
            this.ativos.Location = new System.Drawing.Point(683, 219);
            this.ativos.Name = "ativos";
            this.ativos.Size = new System.Drawing.Size(443, 121);
            this.ativos.TabIndex = 15;
            this.ativos.Text = "Ativos";
            this.ativos.UseVisualStyleBackColor = false;
            this.ativos.Click += new System.EventHandler(this.ativos_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.ForeColor = System.Drawing.SystemColors.Window;
            this.maximizar.Location = new System.Drawing.Point(1505, 3);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(43, 42);
            this.maximizar.TabIndex = 17;
            this.maximizar.Text = "O";
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // fechar
            // 
            this.fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.ForeColor = System.Drawing.SystemColors.Window;
            this.fechar.Location = new System.Drawing.Point(1554, 3);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(43, 42);
            this.fechar.TabIndex = 16;
            this.fechar.Text = "X";
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click_1);
            // 
            // gerentes
            // 
            this.gerentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.gerentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gerentes.ForeColor = System.Drawing.SystemColors.Window;
            this.gerentes.Location = new System.Drawing.Point(142, 219);
            this.gerentes.Name = "gerentes";
            this.gerentes.Size = new System.Drawing.Size(443, 121);
            this.gerentes.TabIndex = 14;
            this.gerentes.Text = "Gerentes";
            this.gerentes.UseVisualStyleBackColor = false;
            this.gerentes.Click += new System.EventHandler(this.gerentes_Click);
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
            this.textBox1.Text = "Admin";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.sair.Click += new System.EventHandler(this.sair_Click);
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(19, 148);
            this.label1.MaximumSize = new System.Drawing.Size(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 2);
            this.label1.TabIndex = 9;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.Selecao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Selecao.ResumeLayout(false);
            this.Selecao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel Selecao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gerentes;
        private System.Windows.Forms.Button ativos;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button fechar;
    }
}