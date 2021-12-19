using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Sim_workers : Form
    {
        public Sim_workers()
        {
            InitializeComponent();
        }

        Func f = new Func();

        private bool flag;

        string[] Name_worker = { "Иван", "Александр", "Алексей", "Дмитрий", "Никита", "Сергей", "Денис" };
        string[] Surname_worker = { "Иванов", "Алексеев", "Демидов", "Васечкин", "Васильев", "Иванов", "Приходько", "Петров" };
        string[] Age_worker = { "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", };
        string[] Telephone_number = { "5430761", "7707899", "8626514", "5443917", "8204560", "3404411", "7662223", "3168287", "6848187" };

        Random rng = new Random();
        int count = 0;

        public void NewWorker()
        {
            while (flag)
            {
                string name_worker = Name_worker[rng.Next(0, Name_worker.Length)];
                string surname_worker = Surname_worker[rng.Next(0, Surname_worker.Length)];
                string age_worker = Age_worker[rng.Next(0, Age_worker.Length)];
                string telephone_number = Telephone_number[rng.Next(0, Telephone_number.Length)];
                f.Add_to_Workers(name_worker, surname_worker, age_worker, telephone_number);
                count++;
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(5000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            Task.Run(() => NewWorker());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void Sim_workers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.Workers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.Workers();
        }
    }
}
