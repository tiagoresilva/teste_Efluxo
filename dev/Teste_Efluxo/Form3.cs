using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Teste_Efluxo
{
    public partial class Form3 : Form
    {
        public SqlConnection connection = new SqlConnection(@"Server=DESKTOP-BMEGNLU\TESTE_EFLUXOSSQL;" +
                   "Database=master;Trusted_Connection = True");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form3()
        {
            InitializeComponent();
            try 
            {
                connection.Open();
                atualizarTabela();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                connection.Close();

            }


        }
        public void atualizarTabela()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from dados_do_usuario where tipo='gerente'", connection);
            DataTable cadastro_de_gerente_table = new DataTable();
            foreach (DataRow row in cadastro_de_gerente_table.Rows)
            {
                foreach (DataColumn column in cadastro_de_gerente_table.Columns)
                {
                    if (row[column] != null) // This will check the null values also (if you want to check).
                    {

                    }
                }
            }
            sqlDa.Fill(cadastro_de_gerente_table);
            cadastro_de_gerente.AutoGenerateColumns = false;
            cadastro_de_gerente.DataSource = cadastro_de_gerente_table;

        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 255, 255, 255));
            e.Graphics.DrawLine(pen, 20, 150, 1580, 150);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastro_de_gerente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public int get_age(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                connection.Open();
                string nome = textBox3.Text;
                int idade = get_age(dateTimePicker1.Value.Date);
                string username = textBox6.Text;
                string senha = textBox7.Text;

                string query = "INSERT INTO dados_do_usuario VALUES( @nome, @idade, @username, @senha, @tipo, @saldo)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.Parameters.AddWithValue("@username", username);              
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@tipo", "gerente");
                cmd.Parameters.AddWithValue("@saldo", 0);
                cmd.ExecuteScalar();
                atualizarTabela();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                connection.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string nome = textBox3.Text;
                if (nome != null)
                {
                    string query = "DELETE FROM dados_do_usuario WHERE nome=@nome";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteScalar();
                    atualizarTabela();

                }
                else
                {
                    MessageBox.Show("Favor preencher o campo nome com o usuário a excluir");

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                connection.Close();

            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            { this.WindowState = FormWindowState.Maximized; }
            else { this.WindowState = FormWindowState.Normal; }
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
