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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=dalekslu.beget.tech;user=dalekslu_zoo;password=Lbvflbvf007.;database=dalekslu_zoo");

        Func f = new Func();

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand($"INSERT INTO Event(Name, Event) VALUES ('{textBox1.Text}', '{textBox2.Text}')", connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());

            connection.Close();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.Events();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.Events();
        }
    }
}
