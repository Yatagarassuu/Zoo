using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();

            this.textBox2.AutoSize = false;
            this.textBox2.Size = new Size(this.textBox2.Size.Width, 40);
        }

        MySqlConnection connection = new MySqlConnection("server=dalekslu.beget.tech;user=dalekslu_zoo;password=Lbvflbvf007.;database=dalekslu_zoo");

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String password = textBox2.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Logins Where Login = login AND Password = password", connection);
            command.Parameters.Add("login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    this.Hide();
                    Form1 main = new Form1();
                    main.Show();
                }

            else
            {
                if (textBox1.Text == "worker" && textBox2.Text == "worker")
                {
                    this.Hide();
                    Form1 main = new Form1();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Ошибка входа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
