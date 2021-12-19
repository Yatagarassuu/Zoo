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
    public partial class Sim_animals : Form
    {
        public Sim_animals()
        {
            InitializeComponent();
        }
            Func f = new Func();

            private bool flag;

            string[] Name_animal = { "Слон", "Жираф", "Лев", "Носорог", "Бегемот", "Обезьяна", "Лиса", "Тигр", "Cтраус", "Павлин", "Лама" };
            string[] Age_pet = { "0", "1", "2", "3", "4", "5", "6", "7" };
            string[] Sex = { "м", "ж" };

            Random rng = new Random();
            int count = 0;

            public void NewAnimal()
            {
                while (flag)
                {
                    string name_animal = Name_animal[rng.Next(0, Name_animal.Length)];
                    string age_animal = Age_pet[rng.Next(0, Age_pet.Length)];
                    string sex_animal = Sex[rng.Next(0, Sex.Length)];
                    f.Add_to_Pets(name_animal, age_animal, sex_animal);
                    count++;
                    label1.Invoke(new Action(() => label1.Text = count.ToString()));
                    Thread.Sleep(5000);
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            Task.Run(() => NewAnimal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void Sim_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = f.Pets();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.Pets();
        }
    }
}
