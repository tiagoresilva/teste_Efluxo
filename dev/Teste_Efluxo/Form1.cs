using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace Teste_Efluxo
{
    public partial class Form1 : Form
    {

        public SqlConnection connection = new SqlConnection(@"Server=DESKTOP-BMEGNLU\TESTE_EFLUXOSSQL;" +
                   "Database=master;Trusted_Connection = True");
        public static string nome { get; set; }
        public static string idade { get; set; }
        public static string saldo { get; set; }
        public static string username { get; set; }
        public Form1()
        {            
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void loadForm(object Form)
        {
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            
        
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 255, 255, 255));
            e.Graphics.DrawLine(pen, 450, 50, 450, 450);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                connection.Open();
                username = textBoxUsername.Text;
                string password = textBoxPassowrdBox.Text;
                SqlCommand cmd = new SqlCommand("Select id from dados_do_usuario where username= @username", connection);
                cmd.Parameters.AddWithValue("@username", username);               

                var id = cmd.ExecuteScalar();

                if (id != null)
                {
                    SqlCommand command = new SqlCommand("Select * from dados_do_usuario where id=@id", connection);
                    command.Parameters.AddWithValue("@id", id);
                    // int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {
                            if (String.Format("{0}", reader["senha"]) == password)
                            {
                                nome = (String.Format("{0}", reader["nome"]));
                                idade = (String.Format("{0}", reader["idade"]));
                                saldo = (String.Format("{0}", reader["saldo"]));
                                if (String.Format("{0}", reader["tipo"]) == "admin")
                                {
                                    this.Hide();
                                    Form2 form2 = new Form2();
                                    form2.Show();

                                }
                                if (String.Format("{0}", reader["tipo"]) == "gerente")
                                {
                                    this.Hide();
                                    Form5 form5 = new Form5();
                                    form5.Show();

                                }
                                if (String.Format("{0}", reader["tipo"]) == "cliente")
                                {
                                    this.Hide();
                                    Form6 form6 = new Form6();
                                    form6.Show();

                                }



                            }
                            else
                            {
                                MessageBox.Show("senha errada");

                            }
                            
                        }
                        
                    }
                    
                }
                else
                {

                    MessageBox.Show("usuario inexistente");
                }
               


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                connection.Close();



            }
            
           
            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
