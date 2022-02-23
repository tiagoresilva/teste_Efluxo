using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teste_Efluxo
{
    public partial class Form6 : Form
    {
        public SqlConnection connection = new SqlConnection(@"Server=DESKTOP-BMEGNLU\TESTE_EFLUXOSSQL;" +
                   "Database=master;Trusted_Connection = True");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        

        public Form6()
        {
            InitializeComponent();
            BindData();
            nome_cliente.Text = Form1.nome + ",";
            idade_cliente.Text = Form1.idade;
            saldo_cliente.Text = "R$ " + Form1.saldo;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)        
        {
            
            
            
        }
        public void BindData()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from ativos", connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(String.Format("{1} / {0}", reader["nome"], reader["grupo"]));
                    }
                    reader.Close();
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

        private void nome_cliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void idade_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void atualizarTabela()
        {
            string query = "Select * from " + Form1.username;
            SqlDataAdapter sqlDa = new SqlDataAdapter(query, connection);
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
            ativos_tabela_cliente.AutoGenerateColumns = false;
            ativos_tabela_cliente.DataSource = ativos_table;

            
            //query = "SELECT SUM (valor) " + Form1.username;
            //SqlCommand cmd = new SqlCommand(query, connection);
            //saldo_cliente.Text = "R$ " + cmd.ExecuteScalar().ToString();
            

        }
        private void inserirTabela()
        {
            
            string ativoComposto = comboBox1.SelectedItem.ToString();
            string[] words = ativoComposto.Split(' ');
            string ativo = words[2].Trim();
            string grupo = words[0].Trim();
            float valor = float.Parse(textBox3.Text);


            string query = "INSERT INTO " + Form1.username + " VALUES(@ativo, @grupo, @valor)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ativo", ativo);
            cmd.Parameters.AddWithValue("@grupo", grupo);
            cmd.Parameters.AddWithValue("@valor", valor);

            cmd.ExecuteScalar();


        }

        private void comprar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                //SqlCommand cmd = new SqlCommand("Select * from ativo", connection);
                //cmd.Parameters.AddWithValue("@username", username);
                if (TableExists(connection, "master", Form1.username))
                {
                    inserirTabela();

                }
                else 
                {
                    string query = "CREATE TABLE " + Form1.username +
                        " ([Id] INT IDENTITY (1, 1) NOT NULL,ativo varchar(50) NOT NULL,grupo varchar(50) NOT NULL,valor float NOT NULL,PRIMARY KEY CLUSTERED ([Id] ASC));";
                    
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteScalar();
                    inserirTabela();

                }
                
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
        private bool TableExists(SqlConnection conn, string database, string name)
        {
            string strCmd = null;
            SqlCommand sqlCmd = null;

            try
            {
                strCmd = "select case when exists((select '['+SCHEMA_NAME(schema_id)+'].['+name+']' As name FROM [" + database + "].sys.tables WHERE name = '" + name + "')) then 1 else 0 end";
                sqlCmd = new SqlCommand(strCmd, conn);

                return (int)sqlCmd.ExecuteScalar() == 1;
            }
            catch { return false; }
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
