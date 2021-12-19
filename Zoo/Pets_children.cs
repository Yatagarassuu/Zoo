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
    public partial class Pets_children : Form
    {
        public Pets_children()
        {
            InitializeComponent();
        }

        Func f = new Func();

        MySqlConnection connection = new MySqlConnection("server=dalekslu.beget.tech;user=dalekslu_zoo;password=Lbvflbvf007.;database=dalekslu_zoo");

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand($"INSERT INTO Pets_children(Name, Age, First_parent, Second_parent, Place) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}' )", connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());

            connection.Close();
        }

        private void Pets_children_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.Pets_children();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.Pets_children();
        }
    }
}
