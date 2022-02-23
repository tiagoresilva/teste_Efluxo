
namespace Teste_Efluxo
{
    partial class Form1 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        
        

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechar = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassowrdBox = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.AutoSize = true;
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.Menu.Controls.Add(this.minimizar);
            this.Menu.Controls.Add(this.maximizar);
            this.Menu.Controls.Add(this.label4);
            this.Menu.Controls.Add(this.label3);
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.fechar);
            this.Menu.Controls.Add(this.buttonLogin);
            this.Menu.Controls.Add(this.textBoxPassowrdBox);
            this.Menu.Controls.Add(this.textBoxUsername);
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Location = new System.Drawing.Point(-6, -2);
            this.Menu.MinimumSize = new System.Drawing.Size(910, 504);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(910, 504);
            this.Menu.TabIndex = 0;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            this.Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.AutoSize = true;
            this.minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizar.ForeColor = System.Drawing.SystemColors.Window;
            this.minimizar.Location = new System.Drawing.Point(766, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(43, 48);
            this.minimizar.TabIndex = 15;
            this.minimizar.Text = "-";
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.AutoSize = true;
            this.maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.ForeColor = System.Drawing.SystemColors.Window;
            this.maximizar.Location = new System.Drawing.Point(815, 7);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(43, 42);
            this.maximizar.TabIndex = 14;
            this.maximizar.Text = "O";
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(455, 81);
            this.label4.MaximumSize = new System.Drawing.Size(2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 0);
            this.label4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(520, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "usando sua conta Info Invest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(468, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Entrar no aplicativo Info Invest";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(455, 53);
            this.label1.MaximumSize = new System.Drawing.Size(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 0);
            this.label1.TabIndex = 10;
            // 
            // fechar
            // 
            this.fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar.AutoSize = true;
            this.fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.ForeColor = System.Drawing.SystemColors.Window;
            this.fechar.Location = new System.Drawing.Point(864, 7);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(43, 42);
            this.fechar.TabIndex = 7;
            this.fechar.Text = "X";
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click_1);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(130)))), ((int)(((byte)(38)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(538, 358);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(284, 67);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "LOG IN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPassowrdBox
            // 
            this.textBoxPassowrdBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPassowrdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassowrdBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassowrdBox.Location = new System.Drawing.Point(538, 283);
            this.textBoxPassowrdBox.MaximumSize = new System.Drawing.Size(500, 500);
            this.textBoxPassowrdBox.Name = "textBoxPassowrdBox";
            this.textBoxPassowrdBox.PasswordChar = '*';
            this.textBoxPassowrdBox.PlaceholderText = "Entre com a senha";
            this.textBoxPassowrdBox.Size = new System.Drawing.Size(284, 39);
            this.textBoxPassowrdBox.TabIndex = 4;
            this.textBoxPassowrdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(538, 213);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "Entre com o username";
            this.textBoxUsername.Size = new System.Drawing.Size(284, 39);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Teste_Efluxo.Properties.Resources.logo_d;
            this.pictureBox1.Location = new System.Drawing.Point(122, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 275);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxPassowrdBox;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        protected System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
    }
}

