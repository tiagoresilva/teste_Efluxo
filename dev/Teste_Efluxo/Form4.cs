using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teste_Efluxo
{
    public partial class Form4 : Form
    {
        public SqlConnection connection = new SqlConnection(@"Server=DESKTOP-BMEGNLU\TESTE_EFLUXOSSQL;" +
                   "Database=master;Trusted_Connection = True");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Form4()
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
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from ativos", connection);
            DataTable ativos_table = new DataTable();
            foreach (DataRow row in ativos_table.Rows)
            {
                foreach (DataColumn column in ativos_table.Columns)
                {
                    if (row[column] != null) // This will check the null values also (if you want to check).
                    {

                    }
                }
            }
            sqlDa.Fill(ativos_table);
            ativos.AutoGenerateColumns = false;
            ativos.DataSource = ativos_table;

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

        private void sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string nome = textBox3.Text;                
                string grupo = comboBox1.SelectedItem.ToString();
                
                string query = "INSERT INTO ativos VALUES(@nome, @grupo)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@grupo", grupo);
                
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
                if ( nome != null)
                {
                    string query = "DELETE FROM ativos WHERE nome=@nome";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteScalar();
                    atualizarTabela();

                }
                else
                {
                    MessageBox.Show("Favor preencher o campo ativo");

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
